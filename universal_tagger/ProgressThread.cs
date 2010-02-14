using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace universal_tagger
{
    /// <summary>
    /// Isolate threading
    /// </summary>
    public abstract class ProgressThread 
    {
        /// <summary>
        /// Status Args
        /// </summary>
        public class StatusArgs : EventArgs
        {
            private string status = null;
            public string Status
            {
                get { return status; }
                set { status = value; }
            }
            public StatusArgs( string status )
            {
                this.status = status;
            }
        }

        /// <summary>
        /// Status Update Event
        /// </summary>
        public event EventHandler<StatusArgs> StatusUpdate;
        public event EventHandler<EventArgs> Finished;
        protected Thread thread = null;
        protected FileInfo[] infos = null;
        protected volatile bool cancel = false;
        protected bool running = false;
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public ProgressThread( FileInfo[] infos )
        {
            thread = new Thread( new ThreadStart( ThreadFunc ) );
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "ProgressThread";
            thread.IsBackground = true;
            this.infos = infos;
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Start()
        {
            if (running == true)
                    return;

            thread.Start();
            running = true;
         }

      
        /// <summary>
        /// 
        /// </summary>
        public abstract void ThreadFunc();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stext"></param>
        public delegate void StringDelegate(string stext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnStatusUpdate(string status)
        {
          if (StatusUpdate != null)
                StatusUpdate(this, new StatusArgs(status));
        }
        /// <summary>
        /// 
        /// </summary>
        protected delegate void SafeDelegate();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnFinished()
        {
            if (Finished != null)
                Finished(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Isolate threading
    /// </summary>
    public abstract class FormatProgressThread : ProgressThread
    {
        protected string format = null;
        protected string path = null;
        protected bool copy = false;
        protected bool overwrite = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public FormatProgressThread(FileInfo[] infos, string format)
            : base(infos)
        {
            this.format = format;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class OrgProgressThread : FormatProgressThread
    {
        public OrgProgressThread(FileInfo[] infos, string format, string path,
            bool copy,
            bool overwrite)
            : base(infos, format)
        {
            this.path = path;
            this.overwrite = overwrite;
            this.copy = copy;
        }

        public override void ThreadFunc()
        {
            foreach (FileInfo fi in infos)
            {
                OnStatusUpdate(fi.FullName);

                TagLib.File tag_file = TagLib.File.Create(fi.FullName);
                TagLib.Tag id3v1 = tag_file.GetTag(TagLib.TagTypes.Id3v1);
                OrganizeFormatEvaluator eval = new OrganizeFormatEvaluator(format, id3v1);
                string dir = String.Format("{0}\\{1}",
                    path.TrimEnd('\\'), eval.Value.TrimStart('\\'));
                if (!Directory.Exists(dir))
                {
                    //TODO MessageBox()
                    Directory.CreateDirectory(dir);
                }
                if (copy)
                {
                    fi.CopyTo(dir + "\\" + fi.Name, overwrite);
                }
                else
                {
                    Tools.Functions.MoveTo(fi, dir + "\\" + fi.Name, overwrite);
                }
            }

            // hold open for at least ...
            System.Threading.Thread.Sleep(1000);
            //SafeClose();
            OnFinished();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class File2TagProgressThread : FormatProgressThread
    {
        public File2TagProgressThread(FileInfo[] infos, string format)
            : base(infos, format)
        {
        }

        public override void ThreadFunc()
        {
            foreach (FileInfo fi in infos)
            {
                OnStatusUpdate(fi.Name);

                TagLib.File tag_file = TagLib.File.Create(fi.FullName);

                File2TagFormatEvaluator eval = new File2TagFormatEvaluator(format, tag_file);
            }

            OnStatusUpdate("Finished");

            // HACK!!
            System.Threading.Thread.Sleep(0);
            //SafeClose();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class TagV12FileProgressThread : FormatProgressThread
    {
        public TagV12FileProgressThread(FileInfo[] infos, string format)
            : base(infos, format)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public override void ThreadFunc()
        {
            foreach (FileInfo fi in infos)
            {
                OnStatusUpdate(fi.Name);

                TagLib.File tag_file = TagLib.File.Create(fi.FullName);
                TagLib.Tag id3v1 = tag_file.GetTag(TagLib.TagTypes.Id3v1);
                OrganizeFormatEvaluator eval = new OrganizeFormatEvaluator(format, id3v1);

                string fullname = String.Format("{0}\\{1}{2}",
                   fi.DirectoryName, eval.Value.TrimStart('\\'), fi.Extension);

                fi.MoveTo(fullname);
                //Tools.Functions.MoveTo( fi, dir.TrimEnd( '\\' ), false );
            }

            OnStatusUpdate("Finished");
            OnFinished();

            // HACK!!
            System.Threading.Thread.Sleep(0);
            //SafeClose();
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class TagV22FileProgressThread : FormatProgressThread
    {
        public TagV22FileProgressThread(FileInfo[] infos, string format)
            : base(infos, format)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public override void ThreadFunc()
        {
            foreach (FileInfo fi in infos)
            {
                OnStatusUpdate(fi.Name);

                TagLib.File tag_file = TagLib.File.Create(fi.FullName);
                TagLib.Tag id3v2 = tag_file.GetTag(TagLib.TagTypes.Id3v2);
                OrganizeFormatEvaluator eval = new OrganizeFormatEvaluator(format, id3v2);

                // HACK LOOK AT THIS!!!
                string fn = eval.Value.TrimStart('\\');
                char[] chars = System.IO.Path.GetInvalidFileNameChars();
                foreach (char c in chars)
                {
                    fn = fn.Replace(c, '_');
                }

                string fullname = String.Format("{0}\\{1}{2}",
                   fi.DirectoryName, fn, fi.Extension);

                fi.MoveTo(fullname);
                //Tools.Functions.MoveTo( fi, dir.TrimEnd( '\\' ), false );
            }

            OnStatusUpdate("Finished");
            OnFinished();
            // HACK!!
            System.Threading.Thread.Sleep(0);
            //SafeClose();
        }
    }

}
