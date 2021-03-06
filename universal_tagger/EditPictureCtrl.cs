using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TagLib.Id3v2;

namespace universal_tagger
{
    public partial class EditPictureCtrl : EditCtrlBase
    {
        private bool pictures_dirty = false;
        public EditPictureCtrl()
        {
            InitializeComponent();
            cmbPicType.SelectedIndex = 0;
        }
        /// <summary>
        /// overrides fill 
        /// </summary>
        public override void Fill()
        {
            foreach(TagLib.IPicture pic in tag.Pictures)
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
                SetSelectedPicture( pictureList.Items[0].Tag as TagLib.IPicture  );
                pictureList.Items[0].Selected = true;
            }
            
        }
        /// <summary>
        /// set selected rating 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedPicture( TagLib.IPicture pic )
        {
            // select first pic
            //TagLib.IPicture pic = item.Tag as TagLib.IPicture;
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
            base.Coalesce();
        }
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            // call base first
            base.EditItem( item );

            if(item.MetaTag != null)
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
                TagLib.IPicture[] pics = new TagLib.IPicture[pictureList.Items.Count];
                int len = pictureList.Items.Count;
                for(int i = 0; i < len; ++i)
                {
                    TagLib.IPicture p = pictureList.Items[i].Tag as TagLib.IPicture;
                    pics[i] = p;
                }
                item.MetaTag.Pictures = pics;
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

                ckInclude.Enabled = true;
                ckRelative.Enabled = true;
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

            byte[] data = File.ReadAllBytes( txtPath.Text );
            // create picture
            TagLib.Picture p = new TagLib.Picture();
            p.Data = data;
            p.Description = txtDesc.Text;
            p.MimeType = "image/" + Path.GetExtension( txtPath.Text );
            item.Tag = p;

            pictureList.Items.Add( item );
            this.pictures_dirty = true;
            ckInclude.Enabled = false;
            ckRelative.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click( object sender, EventArgs e )
        {
            if(this.pictureList.SelectedItems.Count > 0)
            {
                pictureList.Items.Remove( this.pictureList.SelectedItems[0] );
                this.pictures_dirty = true;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExtract_Click( object sender, EventArgs e )
        {
            string art = string.Empty;
            byte[] data = null;
            TagLib.IPicture pic = GetSelectedPicture();
            if(pic != null)
            {
                if(pic.MimeType.StartsWith( "image/" ))
                {
                    art = "picture" + pic.MimeType.Replace( "image/", "." );
                    data = new byte[pic.Data.Count];
                    pic.Data.CopyTo( data, 0 );
                }
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.OverwritePrompt = true;
                dlg.FileName = art;
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // write file to art location
                    System.IO.File.WriteAllBytes( dlg.FileName, data );
                }
            }
            else
            {
                MessageBox.Show( "No picture selected" );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureList_SelectedIndexChanged( object sender, EventArgs e )
        {
            SetSelectedPicture( GetSelectedPicture() );
            ckInclude.Enabled = false;
            ckRelative.Enabled = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_DoubleClick( object sender, EventArgs e )
        {
            ShowPictureForm();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureList_DoubleClick( object sender, EventArgs e )
        {
            ShowPictureForm();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ShowPictureForm()
        {
            if(this.pictureList.SelectedItems.Count > 0)
            {
                PictureFrm dlg = new PictureFrm( (TagLib.IPicture)this.pictureList.SelectedItems[0].Tag );
                dlg.ShowDialog();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private TagLib.IPicture GetSelectedPicture()
        {
            if(this.pictureList.SelectedItems.Count > 0)
                return this.pictureList.SelectedItems[0].Tag as TagLib.IPicture;
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckInclude_CheckedChanged( object sender, EventArgs e )
        {
            if(ckInclude.Checked)
            {
                ckRelative.Enabled = false;
            }
            else
            {
                ckRelative.Enabled = true;
            }
        }
    }
}
