using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Tools;
using System.IO;
using OS.Win32;
using System.Runtime.InteropServices;
using System.Collections;

namespace music_tagger
{
    /// <summary>
    /// files list view usercontrol
    /// </summary>
    public partial class View : UserControl
    {
        /// <summary>
        /// Implements the manual sorting of items by columns. 
        /// </summary>
        class ListViewItemComparer : IComparer
        {
            private int col;
            public ListViewItemComparer()
            {
                col = 0;
            }
            public ListViewItemComparer( int column )
            {
                col = column;
            }
            public int Compare( object x, object y )
            {
                return String.Compare( ( (ListViewItem)x ).SubItems[col].Text, ( (ListViewItem)y ).SubItems[col].Text );
            }
        }
                
        private FileTreeView tree = null;
        private ImageList images = new ImageList();

        /// <summary>
        /// 
        /// </summary>
        public ListView ListView
        {
            get
            {
                return listView;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public View()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tree"></param>
        public void Configure(FileTreeView tree)
        {
            this.tree = tree;
            
            listView.Dock = DockStyle.Fill;
            listView.View = System.Windows.Forms.View.Details;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.MultiSelect = true;
            listView.Columns.AddRange(CreateColumns());
            listView.SmallImageList = images;
            listView.Sorting = SortOrder.None;
            tree.AfterSelect += new TreeViewEventHandler( tree_AfterSelect );
        }
        /// <summary>
        /// 
        /// </summary>
        public void RefreshView()
        {
            DirectoryInfo di = ( (FileTreeNode)tree.SelectedNode ).FileSystemInfo as DirectoryInfo;
            RefreshView( di );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="focus"></param>
        public void RefreshView( DirectoryInfo di )
        {
            //this.focus = focus;
            //DirectoryInfo di = new DirectoryInfo(focus.File.FullName);
            try
            {
                // todo is ready!
                FileInfo[] files = null;
                try
                {
                   files  = di.GetFiles( "*.mp3" );
                }
                catch(IOException)
                {
                    return;
                }
                
                listView.Items.Clear();
                if (files != null)  //be none
                {
                    int len = files.Length;
                    //items = listView.Items;
                    for (int i = 0; i < len; ++i)
                    {
                        ListViewItem ni = new ListViewItem( files[i].Name );

                        Win32.SHFILEINFO sInfo = new OS.Win32.Win32.SHFILEINFO();
                        ////Use this to get the small Icon
                        IntPtr handle = Win32.SHGetFileInfo( files[i].FullName, 0, ref sInfo, (uint)Marshal.SizeOf( sInfo ),
                            Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON );

                        if(images.Images.ContainsKey( sInfo.hIcon.ToString() ) != true)
                        {
                            //The icon is returned in the hIcon member of the shinfo struct
                            System.Drawing.Icon icon = System.Drawing.Icon.FromHandle( sInfo.hIcon );
                            images.Images.Add( sInfo.hIcon.ToString(), icon );
                        }
                        ni.ImageIndex = images.Images.IndexOfKey( sInfo.hIcon.ToString() );

                        ni.Tag = files[i];
                        
                        // fill
                        Fill(ni);
                        listView.Items.Add( ni );
                    }
                    if (len > 0)
                        SizeAll(listView, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (UnauthorizedAccessException exp)
            {
                MessageBox.Show( exp.Message );
            }
        }
        /// <summary>
        ///  fill from tag
        /// </summary>
        /// <param name="idx"></param>
        public void Fill(ListViewItem  item)
        {

            FileInfo fi = (FileInfo)item.Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                                      
            if(id3v1 != null)
            {
                foreach(ColumnHeader col in listView.Columns)
                {
                    switch(col.Text)
                    {
                    case "Track":
                        item.SubItems.Add( id3v1.Track.ToString() );
                        break;
                    case "Artist":
                        item.SubItems.Add( id3v1.FirstPerformer );
                        break;
                    case "Album":
                        item.SubItems.Add( id3v1.Album.ToString() );
                        break;
                    case "Title":
                        item.SubItems.Add( id3v1.Title.ToString() );
                        break;
                    case "Year":
                        item.SubItems.Add( id3v1.Year.ToString() );
                        break;
                    case "Comment":
                        item.SubItems.Add( id3v1.Comment );
                        break;
                    case "Genre":
                        item.SubItems.Add( id3v1.FirstGenre );
                        break;
                    case "Length":
                        item.SubItems.Add( fi.Length.ToString() );
                        break;
                    case "File Path":
                        item.SubItems.Add( fi.FullName );
                        break;
                    case "Attributes":
                        item.SubItems.Add( fi.Attributes.ToString() );
                        break;
                    case "Size":
                        item.SubItems.Add( fi.Length.ToString() );
                        break;
                    case "Last Access":
                        item.SubItems.Add( fi.LastAccessTime.ToShortTimeString() );
                        break;
                    case "Last Write":
                        item.SubItems.Add( fi.LastWriteTime.ToShortTimeString() );
                        break;
                    case "Created":
                        item.SubItems.Add( fi.CreationTime.ToShortTimeString() );
                        break;
                    default:
                         break;
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void SelectAll()
        {
            foreach(ListViewItem item in listView.Items)
            {
                item.Selected = true;
            }
        }
     
        
        #region Event Handlers
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnViewCopyTo_Click( object sender, EventArgs e )
        {
            CopyTo( false );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnViewMoveTo_Click( object sender, EventArgs e )
        {
            CopyTo( true );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnViewSelectAll_Click( object sender, EventArgs e )
        {
            SelectAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_AfterSelect( object sender, TreeViewEventArgs e )
        {
            DirectoryInfo di = ( (FileTreeNode)e.Node ).FileSystemInfo as DirectoryInfo;
            RefreshView( di );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ColumnReordered( object sender, ColumnReorderedEventArgs e )
        {
            Properties.Settings.Default.columns.Clear();
            foreach( ColumnHeader col in listView.Columns )
            {
                System.Diagnostics.Trace.WriteLine( col.DisplayIndex );
                Properties.Settings.Default.columns.Add( String.Format("{0},{1}", col.Text, col.DisplayIndex ));
            }
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ColumnClick( object sender, ColumnClickEventArgs e )
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer 
            // object. Setting this property immediately sorts the 
            // ListView using the ListViewItemComparer object.
            this.listView.ListViewItemSorter = new ListViewItemComparer( e.Column );
        }
        private void listView_DragDrop( object sender, DragEventArgs e )
        {
        }
        private void listView_DragEnter( object sender, DragEventArgs e )
        {
        }
        private void listView_DragLeave( object sender, EventArgs e )
        {
        }
        private void listView_DragOver( object sender, DragEventArgs e )
        {
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private ColumnHeader[] CreateColumns()
        {
            int len = Properties.Settings.Default.columns.Count;
            ColumnHeader[] cols = new ColumnHeader[len];
            for(int idx = 0; idx < len; ++idx)
            {
                cols[idx] = new ColumnHeader();
                string[] split = Properties.Settings.Default.columns[idx].Split( ',' );
                cols[idx].Text = split[0];
                cols[idx].DisplayIndex = int.Parse( split[1] );
            }

            return cols;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isMove"></param>
        private void CopyTo(bool isMove)
        {
            if(listView.SelectedItems.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach(ListViewItem item in listView.SelectedItems)
                    {
                        FileInfo fi = (FileInfo)item.Tag;
                        if(isMove)
                            fi.MoveTo( dlg.SelectedPath + "\\" + fi.Name );
                        else
                            fi.CopyTo( dlg.SelectedPath + "\\" +  fi.Name );
                    }
                }
                Cursor.Current = Cursors.Default;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="style"></param>
        private void SizeAll( ListView listView, ColumnHeaderAutoResizeStyle style )
        {
            int len = listView.Columns.Count;
            for(int i = 0; i < len; ++i)
            {
                listView.Columns[i].AutoResize( style );
            }
        }
    }
}
