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
        private TagLib.Id3v1.Tag id3v1 = null;
        public string[] artist = null;

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
        public void Fill(int idx)
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            lblFile.Text = fi.FullName;

            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 ) as TagLib.Id3v1.Tag;
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
                txtArtist.Text = id3v1.FirstPerformer;
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
            txtTitle.Text = txtArtist.Text;
            txtArtist.Text = org_title;
        }
        /// <summary>
        /// swap artist & album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskSwapArtist_Album_Click( object sender, EventArgs e )
        {
            string org_album = txtAlbum.Text;
            txtAlbum.Text = txtArtist.Text;
            txtArtist.Text = org_album;
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

        private void txtArtist_TextChanged( object sender, EventArgs e )
        {
            ckAlbum.Checked = true;
        }

        private void txtArtist_DoubleClick( object sender, EventArgs e )
        {
            EditListFrm dlg = new EditListFrm(this.id3v1.Performers);
            dlg.ShowDialog(this);
            artist = dlg.Strs;
            this.txtArtist.ReadOnly = true;
            if( artist != null && artist.Length > 0)
                this.txtArtist.Text = artist[0];
        }
    }
}
