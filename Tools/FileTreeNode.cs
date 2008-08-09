using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tools
{
    public class FileTreeNode : TreeNodeExt
    {
        private System.IO.FileSystemInfo fi;
        private DriveInfo drive = null;

        public FileTreeNode( string name, FileSystemInfo fi, int img_idx, int sel_img )
            : base( name, img_idx, sel_img )
        {
            this.fi = fi;
            Initialize();
        }

        public FileTreeNode( string name, FileSystemInfo fi )
            : base( name )
        {
            this.fi = fi;
            Initialize();
        }

        public override void Initialize()
        {
            string root = Path.GetPathRoot( fi.FullName );
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
            {
                if(drive.RootDirectory.FullName == root)
                {
                    this.drive = drive;
                    break;
                }
            }
        }

        public System.IO.FileSystemInfo FileSystemInfo
        {
            get { return fi; }
            set { fi = value; }
        }

        public override void RefreshNode()
        {
            throw new Exception( "The method or operation is not implemented." );
        }
    }

    //public class DriveTreeNode : FileTreeNode
    //{
    //    //DirectoryInfo di = null;

    //    public override void Initialize()
    //    {
    //        throw new Exception( "The method or operation is not implemented." );
    //    }

    //    public override void RefreshNode()
    //    {
    //        throw new Exception( "The method or operation is not implemented." );
    //    }
    //}
}
