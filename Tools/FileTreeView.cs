using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using BKP.Online.IO;

namespace Tools
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FileTreeView : TreeView
    {
        /// <summary>
        /// 
        /// </summary>
        public FileTreeView()
        {
            InitializeComponent();

            ImageList list = new ImageList();
            //list.Images.Add( Image.FromFile( @"default.ico" ) ); // 0
            //list.Images.Add( Image.FromFile( @"open.ico" ) ); // 1
            //list.Images.Add( Image.FromFile( @"file.ico" ) ); // 2
            //list.Images.Add( Image.FromFile( @"hd.ico" ) ); // 3
            //list.Images.Add( Image.FromFile( @"cd.ico" ) ); // 4
            //list.Images.Add( Image.FromFile( @"unk.ico" ) ); // 5
            //list.Images.Add( Image.FromFile( @"usb.ico" ) ); // 6
            //list.Images.Add( Image.FromFile( @"fd.ico" ) ); // 7
            //list.Images.Add( Image.FromFile( @"unk.ico" ) ); // 8
            this.ImageList = list;
            ImageIndex = 0;
            SelectedImageIndex = 1;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Configure( )
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
                AddDrive( drive );
            SelectedNode = Nodes[0];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool CanReadFile( FileSystemInfo file )
        {
            string root = Path.GetPathRoot( file.FullName );
            // if first drive is readable - fill and expand 
            DriveInfo[] drives = DriveInfo.GetDrives();
            int i = -1;
            while(root != drives[++i].RootDirectory.FullName) ;
            bool result = ( drives[i].IsReady );

            //TODO more checks here
            return result;
        }

        private void InitilalizeRoot( string path )
        {
            string d = Path.GetDirectoryName( path );
            string root = Path.GetPathRoot( path );
            while(d != root)
            {
                Directory.CreateDirectory( d );
                if(Nodes.ContainsKey( d ))
                    break;
                //InitializeNode(d);
            }
        }

        /// <summary>
        /// creates all sub nodes "only" before being selected
        /// </summary>
        /// <param name="e"></param>
        protected void Node_AfterSelect( object sender, TreeViewEventArgs e )
        {
            // change the focus
            FileTreeNode node = (FileTreeNode)e.Node;
            if(CanReadFile( node.FileSystemInfo ))
            {
                if(!node.Intialized)
                    InitializeNode( node );
                else
                    this.RefreshTree( node );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nod"></param>
        private void InitializeNode( FileTreeNode node )
        {
            DirectoryInfo directory = node.FileSystemInfo as DirectoryInfo;
            try
            {
                // Filter - Only Directories
                List<FileSystemInfo> files =
                    FileMask.IncludeAttributes( directory.GetFileSystemInfos(), FileAttributes.Directory );

                // create new nodes for each sub node
                int len = files.Count;
                for(int i = 0; i < len; ++i)
                {
                    string name = files[i].Name;
                    FileSystemInfo fi = (FileSystemInfo)files[i];
                    FileTreeNode child = new FileTreeNode( name, fi );
                    node.Nodes.Add( child );
                    node.Intialized = true;
                }
                //node.Expand();
            }
            catch(UnauthorizedAccessException)
            {
                MessageBox.Show( "Can not access " + directory.FullName );
                node.ImageIndex = 8;
                node.SelectedImageIndex = 8;
                // goto parent node
                SelectedNode = SelectedNode.Parent;
                return;
            }
        }

        /// <summary>
        /// allow control to prepare to be updated
        /// </summary>
        /// <param name="drives"></param>
        /// <param name="files"></param>
        public void RefreshTree( FileTreeNode node )
        {
            DateTime dt = node.FileSystemInfo.LastWriteTime;
            node.FileSystemInfo.Refresh();
            if(dt != node.FileSystemInfo.LastWriteTime)
            {
                node.Nodes.Clear();
                InitializeNode( node );
            }
        }

        /// <summary>
        /// Called by delegate when drive state (added or removed) changes
        /// </summary>
        /// <param name="drives"></param>
        private void AddDrive( DriveInfo drive )
        {
            DirectoryInfo di = drive.RootDirectory;
            string name = di.Name;
            if(drive.IsReady)
                name = drive.VolumeLabel + " (" + di.Name + ")";
            FileTreeNode node = new FileTreeNode( name, di );
            int idx = 0;
            switch(drive.DriveType)
            {
            case DriveType.Fixed: idx = 3; break;
            case DriveType.CDRom: idx = 4; break;
            case DriveType.Network: idx = 5; break;
            case DriveType.Removable: idx = 7; break;
            case DriveType.NoRootDirectory: idx = 8; break;
            case DriveType.Ram: idx = 8; break;
            case DriveType.Unknown: idx = 8; break;
            }
            node.ImageIndex = idx;
            node.SelectedImageIndex = idx;
            Nodes.Add( node );
            if(drive.IsReady)
                InitializeNode( node );
        }

    }
}
