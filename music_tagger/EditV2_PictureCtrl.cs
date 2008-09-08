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
        /// <summary>
        /// overrides fill 
        /// </summary>
        public override void Fill()
        {
            foreach(TagLib.IPicture pic in v2.Pictures)
            {
                ListViewItem item = new ListViewItem( pic.Description );
                item.Tag = pic;
                item.SubItems.Add( pic.Type.ToString() );

                if(pic.MimeType == "-->")
                {
                    item.SubItems.Add( pic.Data.ToString() );
                    item.SubItems.Add( "No" );
                }
                else
                {
                    item.SubItems.Add( tag_file.Name );
                    item.SubItems.Add( "Yes" );
                }
                pictureList.Items.Add( item );        
            }

            if(pictureList.Items.Count > 0)
            {
                SetSelectedPicture( pictureList.Items[0] ); 
            }
            
        }
        /// <summary>
        /// set selected rating 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedPicture( ListViewItem item )
        {
            // select first pic
            TagLib.IPicture pic = item.Tag as TagLib.IPicture;
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
            //BKP use IPicture ?
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

        private void pictureList_SelectedIndexChanged( object sender, EventArgs e )
        {
            if( this.pictureList.SelectedItems.Count > 0 )
                SetSelectedPicture( this.pictureList.SelectedItems[0] );
        }

        private void pictureBox_DoubleClick( object sender, EventArgs e )
        {
            PictureFrm dlg = new PictureFrm();
            dlg.ShowDialog();
        }
    }
}
