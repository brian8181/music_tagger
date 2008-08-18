using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace music_tagger
{
    /// <summary>
    /// 
    /// </summary>
    class OrgProgressThread : ProgressThread
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
    class File2TagProgressThread : ProgressThread
    {
        public File2TagProgressThread( FileInfo[] infos, string format)
            : base( infos, format)
        {
        }

        public override void ThreadFunc()
        {
            base.ThreadFunc();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    class TagV12FileProgressThread : ProgressThread
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
}
