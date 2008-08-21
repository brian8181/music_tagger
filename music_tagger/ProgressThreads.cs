using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace music_tagger
{
    /// <summary>
    /// 
    /// </summary>
    class OrgProgressThread : FormatProgressThread
    {
        public OrgProgressThread( FileInfo[] infos, string format, string path,
            bool copy, 
            bool overwrite) : base( infos, format)
        {
            this.path = path;
            this.overwrite = overwrite;
            this.copy = copy;
        }

        public override void ThreadFunc()
        {
            foreach(FileInfo fi in infos)
            {
                OnStatusUpdate( fi.FullName );

                TagLib.File tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                FormatEvaluator eval = new FormatEvaluator( format, id3v1 );
                string dir = String.Format( "{0}\\{1}",
                    path.TrimEnd( '\\' ), eval.Value.TrimStart('\\') );
                if(!Directory.Exists( dir ))
                {
                    Directory.CreateDirectory( dir );
                }
                if(copy)
                {
                    fi.CopyTo( dir + "\\" + fi.Name, overwrite );
                }
                else
                {
                    Tools.Functions.MoveTo( fi, dir + "\\" + fi.Name, overwrite );
                }
            }

            SafeClose();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class File2TagProgressThread : FormatProgressThread
    {
        public File2TagProgressThread( FileInfo[] infos, string format)
            : base( infos, format)
        {
        }

        public override void ThreadFunc()
        {
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class TagV12FileProgressThread : FormatProgressThread
    {
        public TagV12FileProgressThread( FileInfo[] infos, string format )
            : base( infos, format )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public override void ThreadFunc()
        {
            foreach(FileInfo fi in infos)
            {
                OnStatusUpdate( fi.Name );

                TagLib.File tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                FormatEvaluator eval = new FormatEvaluator( format, id3v1 );

                string fullname = String.Format( "{0}\\{1}{2}",
                   fi.DirectoryName, eval.Value.TrimStart( '\\' ), fi.Extension );

                //fi.MoveTo( fullname );
                //Tools.Functions.MoveTo( fi, dir.TrimEnd( '\\' ), false );
            }

            OnStatusUpdate( "Finished" );
            SafeClose();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class ScanProgressThread : ProgressThread
    {
        ListView lv = null;
        TagLib.TagTypes type = TagLib.TagTypes.Id3v2;

        public ScanProgressThread( FileInfo[] infos, ListView lv, TagLib.TagTypes type )
            : base( infos )
        {
            this.lv = lv;
            this.type = type;
            StartPosition = FormStartPosition.CenterParent;
        }
        ///// <summary>
        ///// 
        ///// </summary>
        //public override void Start()
        //{
           
        //    //lv.Clear();
        //    // call the base to start
        //    base.Start();
          
        //} 
        /// <summary>
        /// 
        /// </summary>
        public override void ThreadFunc()
        {
            // fill items
            foreach(FileInfo fi in infos)
            {
                OnStatusUpdate( fi.Name );

                TagListViewItem lvi = new TagListViewItem( lv, fi.FullName );
                lvi.Type = type;
                if(lvi.IntializeItem())
                {
                    // add it to listview
                    SafeAdd( lvi );
                }
            }

            SafeResize();

            OnFinished();
            SafeClose();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        private delegate void SafeDelegate();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeResize()
        {
            if(InvokeRequired)
            {
                this.Invoke(
                    new SafeDelegate( SafeResize ) );
                return;
            }

            if(infos.Length > 0)
            {
                int len = lv.Columns.Count;
                for(int i = 0; i < len; ++i)
                {
                    lv.Columns[i].AutoResize( ColumnHeaderAutoResizeStyle.ColumnContent );
                }
            }
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        private delegate void SafeAddDelegate( TagListViewItem lvi );
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeAdd( TagListViewItem lvi )
        {
            if(InvokeRequired)
            {
                this.Invoke(
                    new SafeAddDelegate( SafeAdd ), lvi );
                return;
            }
            lv.Items.Add( lvi );
        }
    }
}
