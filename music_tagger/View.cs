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

namespace music_tagger
{
    public partial class View : UserControl
    {
        FileTreeView tree = null;
        ImageList images = new ImageList();

        public ListView ListView
        {
            get
            {
                return listView;
            }
        }

        public View()
        {
            InitializeComponent();
        }
        
        public void Configure(FileTreeView tree)
        {
            this.tree = tree;
            this.InitiListView();
            //images.Images.Add("default", Image.FromFile(@"../../default.ico")); // 0
            //images.Images.Add(Image.FromFile(@"../../open.ico"));               // 1
            //images.Images.Add(Image.FromFile(@"../../file.ico"));               // 2
            //images.Images.Add(Image.FromFile(@"../../unk.ico"));                // 3
            //listView.SmallImageList = images;
            tree.AfterSelect += new TreeViewEventHandler( tree_AfterSelect );
        }

        private void tree_AfterSelect( object sender, TreeViewEventArgs e )
        {
            DirectoryInfo di = ((FileTreeNode)e.Node).FileSystemInfo as DirectoryInfo;
            Sync( di );
        }

         /// <summary>
        /// 
        /// </summary>
        /// <param name="focus"></param>
        private void Sync( DirectoryInfo di )
        {
            //this.focus = focus;
            //DirectoryInfo di = new DirectoryInfo(focus.File.FullName);
            try
            {
                FileInfo[] files = di.GetFiles("*.mp3");
                listView.Items.Clear();
                if (files != null)  //be none
                {
                    int len = files.Length;
                    //items = listView.Items;
                    for (int i = 0; i < len; ++i)
                    {
                        ListViewItem ni = new ListViewItem( files[i].Name );
                        //ListViewItem ni = new ListViewItem(
                        //    new string[6] {	files[i].Name, files[i].Length.ToString(),
                        //                        files[i].Attributes.ToString(),
                        //                        files[i].LastAccessTime.ToShortDateString(),
                        //                        files[i].LastWriteTime.ToLocalTime().ToString(),
                        //                        files[i].CreationTime.ToLocalTime().ToLongTimeString() });

                        //Win32.SHFILEINFO sInfo = new OS.Win32.Win32.SHFILEINFO();
                        ////Use this to get the small Icon
                        //IntPtr handle = Win32.SHGetFileInfo(files[i].FullName, 0, ref sInfo, (uint)Marshal.SizeOf(sInfo), 
                        //    Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                        //if (images.Images.ContainsKey(sInfo.hIcon.ToString()) != true)
                        //{
                        //    //The icon is returned in the hIcon member of the shinfo struct
                        //    System.Drawing.Icon icon = System.Drawing.Icon.FromHandle(sInfo.hIcon);
                        //    images.Images.Add(sInfo.hIcon.ToString(), icon);
                        //}
                     
                        ni.Tag = files[i];
                        //ni.ImageIndex = images.Images.IndexOfKey(sInfo.hIcon.ToString());
                        // fill
                        Fill(ni);
                        listView.Items.Add( ni );
                    }
                    if (len > 0)
                        SizeAll(listView, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (UnauthorizedAccessException)
            {
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

        private void InitiListView()
        {
            //listView = new ListView();
            listView.Dock = DockStyle.Fill;
            listView.View = System.Windows.Forms.View.Details;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.FullRowSelect = true;
            listView.MultiSelect = true;
            listView.Columns.AddRange(CreateColumns());
            //this.Controls.Add(listView);
            //listView.SelectedIndexChanged += new EventHandler(OnSelectionChanged);
            //CreateCols();
            //listView.Dock = DockStyle.Fill;
            //this.Controls.Add(listView);
        }

        private ColumnHeader[] CreateColumns()
        {
            int len = Properties.Settings.Default.columns.Count;
            ColumnHeader[] cols = new ColumnHeader[len];
            for(int idx = 0; idx < len; ++idx )
            {
                cols[idx] = new ColumnHeader();
                string[] split = Properties.Settings.Default.columns[idx].Split( ',' ); 
                cols[idx].Text = split[0];
                cols[idx].DisplayIndex = int.Parse(split[1]);
            }

            return cols;
        }

        private void SizeAll(ListView listView, ColumnHeaderAutoResizeStyle style)
        {
            int len = listView.Columns.Count;
            for (int i = 0; i < len; ++i)
            {
                listView.Columns[i].AutoResize(style);
            }
        }

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
    }
}
