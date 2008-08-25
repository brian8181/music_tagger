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
                if(multi_edit)
                {
                    Coalesce();
                }
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
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Id3v1.Tag last_tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 ) as TagLib.Id3v1.Tag;

            foreach(ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );

                last_tag.Album = last_tag.Album != "" && tag.Album == last_tag.Album ? tag.Album : "";
                if(last_tag.JoinedPerformers != "" && tag.JoinedPerformers == last_tag.JoinedPerformers)
                {
                    //todo  
                }
                last_tag.Title = last_tag.Title != "" && tag.Title == last_tag.Title ? tag.Title : "";
                last_tag.Track = last_tag.Track != 0 && tag.Track == last_tag.Track ? tag.Track : 0;
                last_tag.Year = last_tag.Year != 0 && tag.Year == last_tag.Year ? tag.Year : 0;

                if(last_tag.JoinedGenres != "" && tag.JoinedGenres == last_tag.JoinedGenres)
                {
                    // todo
                }
            }
            // todo
            v1 = last_tag;
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            item.BackColor = Color.Yellow;
            if(!multi_edit || ckArtist.Checked)
            {
                item.Id3v1.Performers = Globals.GetArray( this.txtArtists.Text );
            }
            if(!multi_edit || ckAlbum.Checked)
            {
                item.Id3v1.Album = this.txtAlbum.Text;
            }
            if(!multi_edit || this.ckTitle.Checked)
            {
                item.Id3v1.Title = this.txtTitle.Text;
            }
            uint num = 0;
            if(!multi_edit || this.ckYear.Checked)
            {
                item.Id3v1.Year = uint.TryParse( this.txtYear.Text, out num ) ? num : 0;
            }
            if(!multi_edit || this.ckTrack.Checked)
            {
                item.Id3v1.Track = uint.TryParse( this.txtTrack.Text, out num ) ? num : 0;
            }
            if(!multi_edit || this.ckGenre.Checked)
            {
                item.Id3v1.Genres = new string[1] { this.cmbGenre.Text };
            }
            if(!multi_edit || this.ckComment.Checked)
            {
                item.Id3v1.Comment = this.txtComment.Text;
            }
            item.RefreshItem();
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
            ckArtist.Checked = true;
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
                string s = Globals.GetString( dlg.Strs );
                txtArtists.Text = s;
            }
            else
            {
                txtArtists.Text = string.Empty;
            }
        }
    }
}
