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
                        ListViewItem ni = new ListViewItem(
                            new string[6] {	files[i].Name, files[i].Length.ToString(),
											    files[i].Attributes.ToString(),
											    files[i].LastAccessTime.ToShortDateString(),
											    files[i].LastWriteTime.ToLocalTime().ToString(),
											    files[i].CreationTime.ToLocalTime().ToLongTimeString() });

                        Win32.SHFILEINFO sInfo = new OS.Win32.Win32.SHFILEINFO();
                        //Use this to get the small Icon
                        IntPtr handle = Win32.SHGetFileInfo(files[i].FullName, 0, ref sInfo, (uint)Marshal.SizeOf(sInfo), 
                            Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON);

                        if (images.Images.ContainsKey(sInfo.hIcon.ToString()) != true)
                        {
                            //The icon is returned in the hIcon member of the shinfo struct
                            System.Drawing.Icon icon = System.Drawing.Icon.FromHandle(sInfo.hIcon);
                            images.Images.Add(sInfo.hIcon.ToString(), icon);
                        }
                     
                        ni.Tag = files[i];
                        ni.ImageIndex = images.Images.IndexOfKey(sInfo.hIcon.ToString());
                        listView.Items.Add( ni );
                        // fill
                        Fill(ni);
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

            //ColumnHeader col = listView.Columns["Track"];
            //col.DisplayIndex;
                                      
            if(id3v1 != null)
            {
                //ListViewItem.ListViewSubItem[] items = new ListViewItem.ListViewSubItem[listView.Columns.Count];
                //items.Initialize();
                //item.SubItems.AddRange( items );

                //ListView.ListViewItemCollection item = new ListView.ListViewItemCollection(listView);
                //item.Add( "Track", id3v1.Track.ToString(), "" ); 

                foreach(ColumnHeader col in listView.Columns)
                {
                    switch(col.Text)
                    {
                    case "Track":
                        item.SubItems.Add( id3v1.Track.ToString() );
                        break;
                    case "Artist":
                        item.SubItems.Add( id3v1.Performers[0] );
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
                    case "Name":
                    case "Attributes":
                    case "Size":
                    case "Last Access":
                    case "Last Write":
                    case "Created":
                        break;
                    default:
                         item.SubItems.Add( "" );
                         break;
                    }
                }

                //if(id3v1.Performers.Length > 0)
                //{
                //    item.SubItems.Add( id3v1.Performers[0] );
                //}

                //item.SubItems.AddRange( new string[] { 
                //    id3v1.Album, 
                //    id3v1.Title, 
                //    id3v1.Year.ToString(), 
                //    id3v1.Comment } );
               
                //if(id3v1.Genres.Length > 0)
                //{
                //    item.SubItems.Add( id3v1.Genres[0] );
                //}
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
            //todo coloumn mappings
            ColumnHeader[] cols = new ColumnHeader[13];
            cols[0] = new ColumnHeader();
            cols[0].Text = "Name";
            cols[1] = new ColumnHeader();
            cols[1].Text = "Size";
            cols[2] = new ColumnHeader();
            cols[2].Text = "Attributes";
            cols[3] = new ColumnHeader();
            cols[3].Text = "Last Access";
            cols[4] = new ColumnHeader();
            cols[4].Text = "Last Write";
            cols[5] = new ColumnHeader();
            cols[5].Text = "Created";
         
            cols[6] = new ColumnHeader();
            cols[6].Text = "Track";
            cols[7] = new ColumnHeader();
            cols[7].Text = "Artist";
            cols[8] = new ColumnHeader();
            cols[8].Text = "Album";
            cols[9] = new ColumnHeader();
            cols[9].Text = "Title";
            cols[10] = new ColumnHeader();
            cols[10].Text = "Year";
            cols[11] = new ColumnHeader();
            cols[11].Text = "Comment";
            cols[12] = new ColumnHeader();
            cols[12].Text = "Genre";

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

       
    }
}
