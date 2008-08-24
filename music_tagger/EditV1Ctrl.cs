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
    public partial class EditV1Ctrl : EditCtrlBase
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public EditV1Ctrl()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public override void Initialize( ListView lv )
        {
            base.Initialize( lv );
            this.toolTip.SetToolTip( this.lblFile, this.lblFile.Text );
        }
        /// <summary>
        ///  fill from tag
        /// </summary>
        /// <param name="idx"></param>
        public override void Fill()
        {
            if(v1 != null)
            {
                txtArtists.Text = v1.JoinedPerformers;
                txtAlbum.Text = v1.Album;
                txtTitle.Text = v1.Title;
                txtYear.Text = v1.Year.ToString();
                txtTrack.Text = v1.Track.ToString();
                cmbGenre.Text = v1.JoinedGenres;
                txtComment.Text = v1.Comment;
            } 
        }
        /// <summary>
        ///  go to previous tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPrevious_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > Index && Index > 0)
            {
                Next();
            }
        }
        /// <summary>
        /// go to next tag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskNext_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > (Index + 1))
            {
                Next();
            }
        }
        /// <summary>
        /// swap the artist & title
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapArtist_Title_Click( object sender, EventArgs e )
        {
            string org_title = txtTitle.Text;
            txtTitle.Text = txtArtists.Text;
            txtArtists.Text = org_title;
        }
        /// <summary>
        /// swap artist & album
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapArtist_Album_Click( object sender, EventArgs e )
        {
            string org_album = txtAlbum.Text;
            txtAlbum.Text = txtArtists.Text;
            txtArtists.Text = org_album;
        }
        /// <summary>
        ///  swap title & album
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapTitle_Album_Click( object sender, EventArgs e )
        {
            string org_album = txtAlbum.Text;
            txtAlbum.Text = txtTitle.Text;
            txtTitle.Text = org_album;
        }
        private void txtTitle_TextChanged( object sender, EventArgs e )
        {
            ckTitle.Checked = true;
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
        private void txtGenres_TextChanged( object sender, EventArgs e )
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
        /// <summary>
        /// edit artists list
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void txtArtist_DoubleClick( object sender, EventArgs e )
        {
            EditListFrm dlg = new EditListFrm(this.v1.Performers);
            dlg.ShowDialog(this);
            StringBuilder sb = new StringBuilder();
            if(dlg.Strs != null)
            {
                EditFrm parent = (EditFrm)this.Parent;
                parent.GetString( dlg.Strs );
                txtArtists.Text = sb.ToString();
            }
            else
            {
                txtArtists.Text = string.Empty;
            }
        }
    }
}
