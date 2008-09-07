using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TagLib.Id3v2;

namespace music_tagger
{
    public partial class EditV2_PictureCtrl : EditCtrlBase
    {
        private bool pictures_dirty = false;
        public EditV2_PictureCtrl()
        {
            InitializeComponent();
            cmbPicType.SelectedIndex = 0;
        }
       
        public override void Fill()
        {
            // todo loop all
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
        /// <summary>
        /// set selected rating 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedPicture( ListViewItem item )
        {

        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
        }
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            // call base first
            base.EditItem( item );

            if(item.Id3v2 != null)
            {
                UpdatePictureFrames( item );
            }
        }
        /// <summary>
        /// Update the comment frame 
        /// </summary>
        private void UpdatePictureFrames( TagListViewItem item )
        {
            if(this.pictures_dirty)
            {
                item.Id3v2.RemoveFrames( "APIC" );
                foreach(ListViewItem i in this.pictureList.Items)
                {
                    if(File.Exists( txtPath.Text ))
                    {
                        AttachedPictureFrame frame = new AttachedPictureFrame();
                        frame.Description = txtDesc.Text;
                        frame.Type = (TagLib.PictureType)Enum.Parse( typeof( TagLib.PictureType ), cmbPicType.Text );
                        frame.Data = File.ReadAllBytes( txtPath.Text );
                        item.Id3v2.AddFrame( frame );
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImport_Click( object sender, EventArgs e )
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog( this ) == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;

                Stream stream = null;
                try
                {
                    stream = dlg.OpenFile();
                    Image img = Image.FromStream( stream );
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click( object sender, EventArgs e )
        {
            ListViewItem item = new ListViewItem( txtDesc.Text );
            item.SubItems.Add( cmbPicType.Text );
            item.SubItems.Add( txtPath.Text );
            string include = ckInclude.Checked ? "Yes" : "No";
            item.SubItems.Add( include );

            pictureList.Items.Add( item );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtract_Click( object sender, EventArgs e )
        {

        }
    }
}
