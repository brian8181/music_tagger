using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace music_tagger
{
    class OrganizeThread : OrgProgressFrm 
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
        private Thread thread = null;
        private FileInfo[] infos = null;
        private string format = null;
        private string path = null;
        private bool copy = false;
        private bool overwrite = false;

        public OrganizeThread( FileInfo[] infos, string format, string path,
            bool copy, 
            bool overwrite)
        {
            thread = new Thread( new ThreadStart( ThreadFunc ) );
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "OrganizeThread";
            thread.IsBackground = true;

            this.infos = infos;
            this.format = format;
            this.path = path;
            this.overwrite = overwrite;
            this.copy = copy;
        }

        public void Start()
        {
            this.Show();
            thread.Start();    
        }
      
        public void ThreadFunc()
        {
            foreach(FileInfo fi in infos)
            {
                OnStatusUpdate( fi.FullName );

                TagLib.File tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                FormatEvaluator eval = new FormatEvaluator( format, id3v1 );
                string dir = String.Format( "{0}\\{1}",
                    path.TrimEnd( '\\' ), eval.Value.TrimStart( '\\' ) );
                if(!Directory.Exists( dir ))
                {
                    Directory.CreateDirectory( dir );
                }
                if(copy)
                {
                    fi.CopyTo( dir + "\\" + fi.Name, overwrite);
                }
                else
                {
                    Tools.Functions.MoveTo( fi, dir.TrimEnd( '\\' ) + fi.Name, overwrite );
                }
            }

            SafeClose();
        }

        private void OnStatusUpdate(string status)
        {
            this.progressCtrl.UpdateStatus( status );
            if( StatusUpdate != null ) 
                StatusUpdate( this, new StatusArgs( status ) );  
        }
    }
}
