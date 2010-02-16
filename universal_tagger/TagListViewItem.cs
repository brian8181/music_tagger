using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OS.Win32;

namespace universal_tagger
{
    /// <summary>
    /// adds tag info to list view item
    /// </summary>
    public class TagListViewItem : ListViewItem
    {
        private bool dirty = false;
        private FileInfo fi = null;
        private TagLib.File tag_file = null;
        private TagLib.Tag tag = null;
        private ListView lv = null;
        /// <summary>
        /// see if value has changed since contruction
        /// </summary>
        public bool Dirty
        {
            get { return dirty; }
            set { dirty = value; }
        }

        public TagLib.Tag MetaTag
        {
            get { return tag; } 
        }

        public FileInfo FileInfo
        {
            get { return fi; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="path"></param>
        public TagListViewItem(ListView lv, string path)
        {
            this.lv = lv;
            fi = new FileInfo( path );
            this.Name = "File";
            this.Text = fi.Name;
            this.Tag = fi;
        }
        /// <summary>
        /// init item
        /// </summary>
        public bool IntializeItem()
        {
            try
            {
                tag_file = TagLib.File.Create( fi.FullName );
                tag = tag_file.Tag;
            }
            catch(TagLib.CorruptFileException e)
            {
                // BKP todo
                // humm, what shall we do? log?
                System.Diagnostics.Trace.WriteLine( e.Message );
                return false;
            }

            Win32.SHFILEINFO sInfo = new OS.Win32.Win32.SHFILEINFO();
            // Use this to get the small Icon
            IntPtr handle = Win32.SHGetFileInfo( fi.FullName, 0, ref sInfo, (uint)Marshal.SizeOf( sInfo ),
                Win32.SHGFI_ICON | Win32.SHGFI_SMALLICON );
            if(lv.SmallImageList.Images.ContainsKey( sInfo.dwAttributes.ToString() ) != true)
            {
                // The icon is returned in the hIcon member of the shinfo struct
                System.Drawing.Icon icon = System.Drawing.Icon.FromHandle( sInfo.hIcon );
                lv.SmallImageList.Images.Add( sInfo.dwAttributes.ToString(), icon );
            }
            this.ImageIndex = lv.SmallImageList.Images.IndexOfKey( sInfo.dwAttributes.ToString() );
            
            Dictionary<Column, Column> tmp_items = new Dictionary<Column, Column>();
            // fill dictionary with all values
            foreach(Column c in Enum.GetValues( typeof( Column ) ))
            {
                tmp_items.Add( c, c );
            }
            // add configured, then remove
            foreach(ColumnHeader header in lv.Columns)
            {
                if(header.Text == "File")
                    continue;
                Column key = (Column)Enum.Parse( typeof( Column ), header.Text );
                string val = GetString( key );
                ListViewItem.ListViewSubItem sub_item = new ListViewItem.ListViewSubItem( this, val );
                sub_item.Name = key.ToString();
                this.SubItems.Add( sub_item );
                tmp_items.Remove( key );
            }
            // add the leftovers
            foreach(Column key in tmp_items.Keys)
            {
                if(key == Column.File)
                    continue;
                string val = GetString( key );
                ListViewItem.ListViewSubItem sub_item = new ListViewItem.ListViewSubItem( this, val );
                sub_item.Name = key.ToString();
                this.SubItems.Add( sub_item );
            }

            return true;
        }
        /// <summary>
        /// refresh the item
        /// </summary>
        public void RefreshItem()
        {
            foreach(ListViewSubItem i in this.SubItems)
            {
                Column c = (Column)Enum.Parse( typeof( Column ), i.Name );
                if(c == Column.File)
                    continue;
                string val = GetString( c );
                i.Text = val;    
            }
        }
        /// <summary>
        /// update tags
        /// </summary>
        public void UpdateTags()
        {
            tag_file.Save();    
        }
        /// <summary>
        /// returns subitem string from file by column key 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="fi"></param>
        /// <returns></returns>
        public string GetString( Column c )
        {
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
                // display only first
                return tag.FirstPerformer;
            case Column.Album:
                return tag.Album;
            case Column.Title:
                return tag.Title;
            case Column.Track:
                return tag.Track.ToString();
            case Column.TrackCount:
                return tag.TrackCount.ToString();
            case Column.Disc:
                return tag.Disc.ToString();
            case Column.DiscCount:
                return tag.TrackCount.ToString();
            case Column.Year:
                return tag.Year.ToString();
            case Column.Comment:
                return tag.Comment;
            case Column.Genre:
                // display only first
                return tag.FirstGenre;
            case Column.Length:
                return tag_file.Properties.Duration.ToString();
            default:
                break;
            }
            return "";
        }
    }
}
