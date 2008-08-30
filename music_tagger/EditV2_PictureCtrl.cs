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
    public partial class EditV2_PictureCtrl : EditCtrlBase
    {
     
        public EditV2_PictureCtrl()
        {
            InitializeComponent();
        }
       
        public override void Fill()
        {
            if(v2.Pictures.Length > 0)
            {
                TagLib.IPicture pic = v2.Pictures[0];
                if(pic.MimeType.StartsWith( "image/" ))
                {
                    //string art = guid.ToString( "B" ) + pic.MimeType.Replace( "image/", "." );
                    byte[] data = new byte[pic.Data.Count];
                    pic.Data.CopyTo( data, 0 );
                    string type = pic.Type.ToString();
                    string mime_type = pic.MimeType;
                    //description = pic.Description;
                    //pic.Type.ToString();

                    MemoryStream stream = null;
                    try
                    {
                        stream = new MemoryStream( data );
                        Image img = Image.FromStream( stream );
                        pictureBox.Image = img;
                    }
                    catch(ArgumentException)
                    {
                        pictureBox.Image = null;
                    }
                    finally
                    {
                        if( stream != null )
                            stream.Close();
                    }

                }

            }
        }
    }
}
