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

        #region Public Methods
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
        /// refresh the view
        /// </summary>
        public void RefreshView()
        {
            DirectoryInfo di = ( (FileTreeNode)tree.SelectedNode ).FileSystemInfo as DirectoryInfo;
            RefreshView( di );
        }
        /// <summary>
        /// refresh view base on directory
        /// </summary>
        /// <param name="di"></param>
        public void RefreshView( DirectoryInfo di )
        {
            FileInfo[] files = null;
            try
            {
                files = di.GetFiles( "*.mp3" );
                if( files != null)
                    RefreshView( files );
            }
            catch(IOException)
            {
                return;
            }
        }
        /// <summary>
        ///  refresh view based on files
        /// </summary>
        /// <param name="files"></param>
        public void RefreshView( FileInfo[] files )
        {
            ListView.Items.Clear();
           // fill items
           foreach(FileInfo fi in files)
           {
               // init main item, by key (filename)
               ListViewItem lvi = new ListViewItem(fi.Name, 0);
               lvi.Name = fi.Name;
               lvi.Tag = fi;

               Win32.SHFILEINFO sInfo = new OS.Win32.Win32.SHFILEINFO();
               ////Use this to get the small Icon
               IntPtr handle = Win32.SHGetFileInfo( fi.FullName, 0, ref sInfo, (uint)Marshal.SizeOf( sInfo ),
                   Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON );

               if(images.Images.ContainsKey( sInfo.hIcon.ToString() ) != true)
               {
                   //The icon is returned in the hIcon member of the shinfo struct
                   System.Drawing.Icon icon = System.Drawing.Icon.FromHandle( sInfo.hIcon );
                   images.Images.Add( sInfo.hIcon.ToString(), icon );
               }
               lvi.ImageIndex = images.Images.IndexOfKey( sInfo.hIcon.ToString() );

               Dictionary<Column, Column> tmp_items = new Dictionary<Column,Column>();
               // fill dictionary with all values
               foreach( Column c in Enum.GetValues( typeof(Column ) ) ) 
               {
                   tmp_items.Add( c, c ); 
               }

               // add configured, then remove
               foreach(ColumnHeader header in ListView.Columns)
               {
                   if(header.Text == "File")
                       continue;
                   Column key = (Column)Enum.Parse( typeof( Column ), header.Text );
                   string val = GetString( key, fi );
                   ListViewItem.ListViewSubItem sub_item = new ListViewItem.ListViewSubItem( lvi, val );
                   sub_item.Name = key.ToString();
                   lvi.SubItems.Add( sub_item );
                   tmp_items.Remove( key );  
               }

               // add the leftovers
               foreach(Column key in tmp_items.Keys)
               {
                   if(key == Column.File)
                       continue;
                   string val = GetString( key, fi );
                   ListViewItem.ListViewSubItem sub_item = new ListViewItem.ListViewSubItem( lvi, val );
                   sub_item.Name = key.ToString();
                   lvi.SubItems.Add( sub_item );
               }

               // add it to listview
               ListView.Items.Add( lvi );
            }
            if(files.Length > 0)
            {
                SizeAll( listView, ColumnHeaderAutoResizeStyle.ColumnContent );
            }
        }
        /// <summary>
        /// select all 
        /// </summary>
        public void SelectAll()
        {
            foreach(ListViewItem item in listView.Items)
            {
                item.Selected = true;
            }
        }
        /// <summary>
        /// commit changes to file
        /// </summary>
        public void Commit()
        {
            foreach(ListViewItem item in ListView.Items)
            {
                if( /*dirty=*/ true)
                {

                }
            }
        }
        #endregion
                 
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

        #region Utility Functions
        /// <summary>
        /// returns subitem string from file by column key 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="fi"></param>
        /// <returns></returns>
        public string GetString( Column c, FileInfo fi )
        {
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );

            switch(c)
            {
            case Column.Path:
                return fi.FullName;
            case Column.Size:
                return fi.Length.ToString();
            case Column.Attributes:
                return fi.Attributes.ToString();
            case Column.Created:
                return fi.CreationTime.ToString();
            case Column.Accessed:
                return fi.LastAccessTime.ToString();
            case Column.Modified:
                return fi.LastWriteTime.ToString();
            case Column.Artist:
                return tag.FirstPerformer;
            case Column.Album:
                return tag.Album;
            case Column.Title:
                return tag.Title;
            case Column.Track:
                return tag.Track.ToString();
            case Column.Year:
                return tag.Year.ToString();
            case Column.Comment:
                return tag.Comment;
            case Column.Genre:
                return tag.FirstGenre;
            case Column.Length:
                return tag_file.Properties.Duration.ToString();
            default:
                break;
            }

            return "";
        }
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
                cols[idx].Name = split[0];
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
        #endregion

    }
}
