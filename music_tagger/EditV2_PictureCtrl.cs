using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class EditV2_PictureCtrl : UserControl
    {
        private TagLib.File tag_file = null;
        private TagLib.Tag v1;
        private TagLib.Tag v2;
        private ListView lv = null;
        private int idx = -1;
        public EditV2_PictureCtrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize( ListView lv )
        {
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
                Fill( idx );
            }
        }
        /// <summary>
        ///  fill from tag
        /// </summary>
        /// <param name="idx"></param>
        public void Fill( int idx )
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            //  lblFile.Text = fi.FullName;
            tag_file = TagLib.File.Create( fi.FullName );
            v2 = tag_file.GetTag( TagLib.TagTypes.Id3v2 );
            v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
            Fill( v2 );
        }
        public void Fill( TagLib.Tag tag )
        {
            if(tag.Pictures.Length > 0)
            {
                TagLib.IPicture pic = tag.Pictures[0];
                if(pic.MimeType.StartsWith( "image/" ))
                {
                    //string art = guid.ToString( "B" ) + pic.MimeType.Replace( "image/", "." );
                    byte[] data = new byte[pic.Data.Count];
                    pic.Data.CopyTo( data, 0 );
                    string type = pic.Type.ToString();
                    string mime_type = pic.MimeType;
                    //description = pic.Description;
                    //pic.Type.ToString();
                    

                    MemoryStream stream = new MemoryStream( data );
                    Image img = Image.FromStream(stream);
                    pictureBox.Image = img;


                }

            }
        }
    }
}
