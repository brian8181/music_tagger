using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class PictureFrm : Form
    {
        private TagLib.IPicture pic = null;
        public PictureFrm(TagLib.IPicture pic)
        {
            InitializeComponent();
            this.pic = pic;
            Initialize();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
            // select first pic
            if(pic != null)
            {
                if(pic.MimeType.StartsWith( "image/" ))
                {
                    byte[] data = new byte[pic.Data.Count];
                    pic.Data.CopyTo( data, 0 );
                    MemoryStream stream = null;
                    try
                    {
                        stream = new MemoryStream( data );
                        Image img = Image.FromStream( stream );
                        this.Text = pic.Type.ToString();
                        this.ClientSize = new Size(img.Width, img.Height);
                        pictureBox.Image = img;
                    }
                    catch(ArgumentException)
                    {
                        pictureBox.Image = null;
                    }
                    finally
                    {
                        if(stream != null)
                            stream.Close();
                    }
                }
            }
        }
    }
}