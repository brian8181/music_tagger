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

namespace universal_tagger
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

        /// <summary>
        /// Status Args
        /// </summary>
        public class RefreshArgs : EventArgs
        {
            private string path = string.Empty;

            public string Path
            {
                get { return path; }
                set { path = value; }
            }
            private int file_count = 0;

            public int FileCount
            {
                get { return file_count; }
                set { file_count = value; }
            }

            public RefreshArgs( string path, int file_count )
            {
                this.path = path;
                this.file_count = file_count;
            }
        }

        public event EventHandler<RefreshArgs> Refreshed;
        private FileTreeView tree = null;
        private ImageList images = new ImageList();
        private SearchOption searchOption = SearchOption.TopDirectoryOnly;
        private DirectoryInfo di = null;
              
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
        public void Initialize( FileTreeView tree )
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
            RefreshView( false );
        }
        /// <summary>
        /// refresh the view
        /// </summary>
        /// <param name="columns">true refreshes columns also</param>
        public void RefreshView(bool columns)
        {
            if(columns)
            {
                listView.Columns.Clear();
                listView.Columns.AddRange( CreateColumns() );
            }
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
        private void RefreshView( DirectoryInfo di )
        {
            // only ask if it is a dir change
            if(this.di != null && di.FullName != this.di.FullName)
            {
                AskToCommit();
            }

            this.di = di;

            FileInfo[] files = null;
            try
            {
                //files = di.GetFiles( "*.mp3", searchOption );
                //BKP Todo config types
                files = DirectoryExt.GetFileInfos(di, "*.mp3;*.flac", searchOption);
                if(files != null)
                    RefreshView( files );
            }
            catch(UnauthorizedAccessException)
            {
                return;
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
        private void RefreshView( FileInfo[] files )
        {
            ListView.BeginUpdate();
            ListView.Items.Clear();
            
            // OLD WAY!!!
            //Threading.ScanProgressThread thread = new System.Threading.ScanProgressThread( files, ListView, type );
            //thread.Finished += new EventHandler<EventArgs>( thread_Finished );
            //thread.ShowDialog(this.TopLevelControl);
            //thread.Start();

            ScanProgressFrm frm = new ScanProgressFrm(this, files);
            
            ((ScanProgressThread)frm.Thread).ItemFound +=
                new ScanProgressThread.ItemFoundDelegate(thread_ItemFound);
            ((ScanProgressThread)frm.Thread).Finished +=
                new EventHandler<EventArgs>(thread_Finished);

            //frm.StartThread();
            frm.ShowDialog();
       
        }

        #region Thread Callback Functions

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        void thread_ItemFound(TagListViewItem lvi)
        {
            SafeAdd(lvi);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        private delegate void SafeAddDelegate(TagListViewItem lvi);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeAdd(TagListViewItem lvi)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(
                    new SafeAddDelegate(SafeAdd), lvi);
                return;
            }
            //ListView.BeginUpdate();
            ListView.Items.Add(lvi);
            //ListView.EndUpdate();
        }
        

        /// <summary>
        ///  refresh view is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void thread_Finished( object sender, EventArgs e )
        {
            if (InvokeRequired)
            {
                this.BeginInvoke( 
                    new EventHandler<EventArgs>(thread_Finished), new object[] {sender, e} );
                return;
            }
            ListView.EndUpdate();
            //Refreshed( this, new RefreshArgs(di.FullName, this.listView.Items.Count) );
        }

        #endregion


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
            e.Effect = DragDropEffects.Copy;
        }
        private void listView_DragLeave( object sender, EventArgs e )
        {
        }
        private void listView_DragOver( object sender, DragEventArgs e )
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void listView_GiveFeedback( object sender, GiveFeedbackEventArgs e )
        {
            //this.Cursor = Cursors.
        }
        #endregion

        #region Utility Functions
        public void RemoveTags(TagLib.TagTypes type)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                FileInfo fi = (FileInfo)item.Tag;
                RemoveTag(fi, type);
            }
        }
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
            int len = Properties.Settings.Default.cols.Count;
            List<ColumnHeader> cols = new List<ColumnHeader>();
            for(int idx = 0; idx < len; ++idx)
            {
                ColumnHeader header = new ColumnHeader();
                string[] split = Properties.Settings.Default.cols[idx].Split( ',' );
                header.Name = split[0];
                header.Text = split[0];
                bool show = ( split[1] != "0" ) ? true : false;
                if(show)
                {
                    cols.Add( header );
                }
                //cols[idx].DisplayIndex = int.Parse( split[1] );
            }
            return cols.ToArray();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isMove"></param>
        public void CopyTo(bool isMove)
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
        public void Delete()
        {
            if (listView.SelectedItems.Count > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    FileInfo fi = (FileInfo)item.Tag;
                    fi.Delete();
                }
                RefreshView();
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
        public void AskToCommit()
        {
            if(IsDirty)
            {
                DialogResult dr = MessageBox.Show(
                       Properties.Resources.refresh_warning,
                       Properties.Resources.save_pending,
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Asterisk );

                if(dr == DialogResult.Yes)
                {
                    Commit();
                }
            }
        }
        #endregion
        /// <summary>
        /// handle key press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowEditControl();
            }
        }
        /// <summary>
        /// handle double clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_DoubleClick( object sender, EventArgs e )
        {
            ShowEditControl();
        }
        /// <summary>
        /// this show the default edit control based on user settings
        /// </summary>
        private void ShowEditControl()
        {
            // todo
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_ItemDrag( object sender, ItemDragEventArgs e )
        {
            if(this.listView.SelectedItems.Count > 0)
            {
                TagListViewItem item = (TagListViewItem)this.listView.SelectedItems[0];
                FileInfo fi = (FileInfo)item.Tag;
                DataObject data = new DataObject( DataFormats.FileDrop, new string[1] { fi.FullName } );
                DoDragDrop( data, DragDropEffects.Copy );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public void SwapArtistTitle()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public void SwapArtistAlbum()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public void SwapTitleAlbum()
        {
        }

        private void mnEditTag_Click(object sender, EventArgs e)
        {
            if (this.ListView.SelectedItems.Count > 0)
            {
                EditTagFrm dlg = new EditTagFrm(this.listView, false);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo
                }
            }

        }
       
    }
}
