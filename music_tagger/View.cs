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
                    }
                    if (len > 0)
                        SizeAll(listView, ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
            catch (UnauthorizedAccessException)
            {
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
            listView.Columns.AddRange(CreateCols());
            //this.Controls.Add(listView);
            //listView.SelectedIndexChanged += new EventHandler(OnSelectionChanged);
            CreateCols();
            //listView.Dock = DockStyle.Fill;
            //this.Controls.Add(listView);
        }

        private ColumnHeader[] CreateCols()
        {
            ColumnHeader[] cols = new ColumnHeader[6];
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
            cols[5] = new ColumnHeader();
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
