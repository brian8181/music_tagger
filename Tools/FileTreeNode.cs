using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Tools
{
    /// <summary>
    /// a file tree node
    /// </summary>
    public class FileTreeNode : TreeNodeExt
    {
        private System.IO.FileSystemInfo fi;
        private DriveInfo drive = null;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fi"></param>
        /// <param name="img_idx"></param>
        /// <param name="sel_img"></param>
        public FileTreeNode( string key, string name, FileSystemInfo fi, int img_idx, int sel_img )
            : base( key, name, img_idx, sel_img )
        {
            this.fi = fi;
            InitializeRoot();
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fi"></param>
        public FileTreeNode( string key, string name, FileSystemInfo fi )
            : base( key, name )
        {
            this.fi = fi;
            InitializeRoot();
        }
        /// <summary>
        /// overrides Initialize
        /// </summary>
        public override void InitializeRoot()
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
            //intialized = true;
        }
        /// <summary>
        ///  checks can read for node
        /// </summary>
        public override bool CanRead
        {
            get
            {
                // todo more checks
                return drive.IsReady;
            }
        }
        /// <summary>
        /// gets the drive information
        /// </summary>
        public DriveInfo Drive
        {
            get { return drive; }
        }
        /// <summary>
        /// gets the FileSystemInfo 
        /// </summary>
        public System.IO.FileSystemInfo FileSystemInfo
        {
            get { return fi; }
        }
        /// <summary>
        ///  refreshes the node
        /// </summary>
        public override void RefreshNode()
        {
            throw new Exception( "The method or operation is not implemented." );
        }
    }
    /// <summary>
    ///  a drive node
    /// </summary>
    public class DriveTreeNode : FileTreeNode
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fi"></param>
        public DriveTreeNode( string key, string name, FileSystemInfo fi)
            : base( key, name, fi )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="fi"></param>
        /// <param name="img_idx"></param>
        /// <param name="sel_img"></param>
        public DriveTreeNode( string key, string name, FileSystemInfo fi, int img_idx, int sel_img)
            : base( key, name, fi, img_idx, sel_img )
        {
        }
    }
}
