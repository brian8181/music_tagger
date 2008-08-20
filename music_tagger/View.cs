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
        private TagLib.TagTypes type = TagLib.TagTypes.Id3v1;
        private SearchOption searchOption = SearchOption.TopDirectoryOnly;

        #region Properties
        /// <summary>
        /// 
        /// </summary>
        public SearchOption SearchOption
        {
            get { return searchOption; }
          
            set { searchOption = value; }
        } 
        /// <summary>
        /// 
        /// </summary>
        public TagLib.TagTypes Type
        {
            get { return type; }
            set 
            { 
                type = value;
                RefreshView();
            }
        }
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
        /// checks for pending changes
        /// </summary>
        public bool IsDirty
        {
            get
            {
                foreach(ListViewItem item in ListView.Items)
                {
                    if(item.BackColor == Color.Yellow)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion

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
        public void Configure( FileTreeView tree, TagLib.TagTypes type)
        {
            this.tree = tree;
            this.type = type;
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
        /// refresh the view, (called by scan thread)
        /// </summary>
        public void RefreshView()
        {
            if(tree != null)
            {
                DirectoryInfo di = ( (FileTreeNode)tree.SelectedNode ).FileSystemInfo as DirectoryInfo;
                RefreshView( di );
            }
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
                files = di.GetFiles( "*.mp3", searchOption );
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
            ListView.BeginUpdate();
            ListView.Items.Clear();
            ScanProgressThread thread = new ScanProgressThread( files, ListView, type);
            thread.Finished += new EventHandler<EventArgs>( thread_Finished );
            thread.Start(this.TopLevelControl);
        }
        /// <summary>
        ///  refresh view is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void thread_Finished( object sender, EventArgs e )
        {
            ListView.EndUpdate();
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
            foreach(TagListViewItem item in ListView.Items)
            {
                if(item.BackColor == Color.Yellow)
                {
                    item.UpdateTags();
                    item.BackColor = Color.White;
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
        public void RemoveTag(FileInfo fi, TagLib.TagTypes type)
        {
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            tag_file.RemoveTags( type );
            tag_file.Save();
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
