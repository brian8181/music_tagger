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
    /// <summary>
    /// 
    /// </summary>
    public partial class EditV1Ctrl : UserControl
    {
        private ListView lv = null;
        private int idx = -1;

        /// <summary>
        /// 
        /// </summary>
        public EditV1Ctrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Configure( ListView lv )
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
        public void Fill(int idx)
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
            Fill( id3v1 );
        }
        /// <summary>
        ///  fill from tag
        /// </summary>
        /// <param name="idx"></param>
        public void Fill( TagLib.Tag id3v1 )
        {
            if(id3v1 != null)
            {
                if(id3v1.Performers.Length > 0)
                {
                    cmbArtist.Items.AddRange( id3v1.Performers );
                    cmbArtist.SelectedIndex = 0;
                }
                txtAlbum.Text = id3v1.Album;
                txtTitle.Text = id3v1.Title;
                txtYear.Text = id3v1.Year.ToString();
                txtTrack.Text = id3v1.Track.ToString();
                if(id3v1.Genres.Length > 0)
                {
                    cmbGenre.Items.AddRange( id3v1.Genres );
                    cmbGenre.SelectedIndex = 0;
                }
                txtComment.Text = id3v1.Comment;
            } 
        }
        /// <summary>
        ///  go to previous tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPrevious_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > idx && idx > 0)
            {
                Fill( --idx );
            }
        }
        /// <summary>
        /// go to next tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskNext_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > (idx + 1))
            {
                Fill( ++idx );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskSwapArtist_Title_Click( object sender, EventArgs e )
        {
            string org_title = txtTitle.Text;
            txtTitle.Text = cmbArtist.Text;
            cmbArtist.Text = org_title;
        }
        /// <summary>
        /// swap artist & album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskSwapArtist_Album_Click( object sender, EventArgs e )
        {
            string org_album = txtAlbum.Text;
            txtAlbum.Text = cmbArtist.Text;
            cmbArtist.Text = org_album;
        }
        /// <summary>
        ///  swap title & album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskSwapTitle_Album_Click( object sender, EventArgs e )
        {
            string org_album = txtAlbum.Text;
            txtAlbum.Text = txtTitle.Text;
            txtTitle.Text = org_album;
        }

        private void cmbArtist_SelectedIndexChanged( object sender, EventArgs e )
        {
            ckAlbum.Checked = true;
        }

        private void txtTitle_TextChanged( object sender, EventArgs e )
        {
            ckArtist.Checked = true;
        }

        private void txtAlbum_TextChanged( object sender, EventArgs e )
        {
            ckAlbum.Checked = true;
        }

        private void txtYear_TextChanged( object sender, EventArgs e )
        {
            ckYear.Checked = true;
        }

        private void txtTrack_TextChanged( object sender, EventArgs e )
        {
            ckTrack.Checked = true;
        }

        private void cmbGenre_SelectedIndexChanged( object sender, EventArgs e )
        {
            ckGenre.Checked = true;
        }

        private void txtComment_TextChanged( object sender, EventArgs e )
        {
            ckComment.Checked = true;
        }
      
    }
}
