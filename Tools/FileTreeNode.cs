using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tools
{
    public class FileTreeNode : TreeNodeExt
    {
        private System.IO.FileSystemInfo fi;
        private bool intialized = false;
        private DriveInfo drive = null;

        public FileTreeNode()
        {
        }
        public FileTreeNode( string name, FileSystemInfo fi )
            : base( name )
        {
            this.fi = fi;
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

        public bool Intialized
        {
            get
            {
                bool i = intialized;
                intialized = true;
                return i;
            }
            set
            {
                intialized = value;
            }

        }

        public System.IO.FileSystemInfo FileSystemInfo
        {
            get { return fi; }
            set { fi = value; }
        }

        public override void Initialize()
        {
            throw new Exception( "The method or operation is not implemented." );
        }

        public override void RefreshNode()
        {
            throw new Exception( "The method or operation is not implemented." );
        }
    }

    public class DriveTreeNode : FileTreeNode
    {
        //DirectoryInfo di = null;

        public override void Initialize()
        {
            throw new Exception( "The method or operation is not implemented." );
        }

        public override void RefreshNode()
        {
            throw new Exception( "The method or operation is not implemented." );
        }
    }
}
