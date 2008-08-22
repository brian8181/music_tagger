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
        public virtual void Initialize( ListView lv )
        {
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
                Fill( idx );
            }

            this.toolTip.SetToolTip( this.lblFile, this.lblFile.Text );
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
                txtArtists.Text = id3v1.JoinedPerformers;
                txtAlbum.Text = id3v1.Album;
                txtTitle.Text = id3v1.Title;
                txtYear.Text = id3v1.Year.ToString();
                txtTrack.Text = id3v1.Track.ToString();
                txtGenres.Text = id3v1.JoinedGenres;
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
            EditListFrm dlg = new EditListFrm(this.id3v1.Performers);
            dlg.ShowDialog(this);
            StringBuilder sb = new StringBuilder();
            if(dlg.Strs != null)
            {
                foreach(string s in dlg.Strs)
                {
                    sb.Append( s );
                    sb.Append( "; " );
                }
                sb.Remove( sb.Length - 2, 2 ); // remove comma
                txtArtists.Text = sb.ToString();
            }
            else
            {
                txtArtists.Text = string.Empty;
            }
        }
        /// <summary>
        ///  edit genres list
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void txtGenres_DoubleClick( object sender, EventArgs e )
        {
            EditListFrm dlg = new EditListFrm( this.id3v1.Genres );
            dlg.ShowDialog( this );
            StringBuilder sb = new StringBuilder();
            if(dlg.Strs != null)
            {
                foreach(string s in dlg.Strs)
                {
                    sb.Append( s );
                    sb.Append( "; " );
                }
                sb.Remove( sb.Length - 2, 2 ); // remove comma
                txtGenres.Text = sb.ToString();
            }
            else
            {
                txtGenres.Text = string.Empty;
            }
        }
    }
}
