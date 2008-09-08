using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Tools
{
    /// <summary>
    /// a file tree view
    /// </summary>
    public partial class FileTreeView : TreeView
    {
        private int closed_img_idx = 0;
        private int opened_img_idx = 1;
        private readonly int hard_drive_img_idx;
        private readonly int rom_drive_img_idx;
        private readonly int net_drive_img_idx;
        /// <summary>
        ///  default constructor
        /// </summary>
        public FileTreeView()
        {
            InitializeComponent();
            ImageList list = new ImageList();
            list.TransparentColor = Color.Fuchsia;
            list.Images.Add( Properties.Resources.closed_folder ); // 0
            list.Images.Add( Properties.Resources.opened_folder ); // 1
            hard_drive_img_idx = 2;
            list.Images.Add( Properties.Resources.hard_drive );
            rom_drive_img_idx = 3;
            list.Images.Add( Properties.Resources.rom_drive );
            net_drive_img_idx = 4;
            list.Images.Add( Properties.Resources.net_drive );
            this.ImageList = list;
            ImageIndex = closed_img_idx;
            SelectedImageIndex = opened_img_idx;
        }
        /// <summary>
        /// constructor    
        /// </summary>
        public void Initilaize()
        {
            BeginUpdate();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
                AddDrive( drive );
            SelectedNode = Nodes[0];
            EndUpdate();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void Open( string path )
        {
            // todo
            if(!string.IsNullOrEmpty( path ))
            {
                string root = Path.GetPathRoot( path );
                TreeNode[] nodes = Nodes.Find( root, true );
                if(nodes.Length > 0)
                {
                    this.SelectedNode = nodes[0];
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public bool CanReadFile( FileSystemInfo file )
        {
            // BKP node has CanRead do I need this?
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
        //todo
        //protected override void OnBeforeExpand( TreeViewCancelEventArgs e )
        //{
        //    base.OnBeforeExpand( e );
        //    // change the focus
        //    FileTreeNode node = (FileTreeNode)e.Node;
        //    if(CanReadFile( node.FileSystemInfo ))
        //    {
        //        foreach(FileTreeNode n in node.Nodes)
        //        {
        //            if(!n.Intialized)
        //                InitializeNode( n );
        //            else
        //                this.RefreshTree( n );
        //        }
        //    }
        //}
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
                BeginUpdate();
                node.Nodes.Clear();
                // create new nodes for each sub node
                int len = files.Count;
                for(int i = 0; i < len; ++i)
                {
                    string name = files[i].Name;
                    FileSystemInfo fi = (FileSystemInfo)files[i];
                    FileTreeNode child = new FileTreeNode( name, name, fi, 0, 1 );
                    //child.Initialize();
                    node.Nodes.Add( child );
                }
                //Sort();
                EndUpdate();
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
            DriveTreeNode node = new DriveTreeNode( di.Name, name, di );
            Debug.WriteLine( "TOSTRING: " + node.ToString() );
            int idx = 0;
            switch(drive.DriveType)
            {
            case DriveType.Fixed: idx = hard_drive_img_idx; break;
            case DriveType.CDRom: idx = rom_drive_img_idx; break;
            case DriveType.Network: idx = net_drive_img_idx; break;
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
