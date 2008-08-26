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
    public partial class EditV2_MainCtrl : EditCtrlBase
    {

        /// <summary>
        /// 
        /// </summary>
        public EditV2_MainCtrl()
        {
            InitializeComponent();
            string[] lines = Properties.Resources.ISO_639_2.Split( '\n' );
            cmbCommentLang.Items.Add( new ISO_639_2( "xxx", "Default" ) );
            //alpha-3 (bibliographic) code|an alpha-3 (terminologic)|English name|French name
            foreach(string line in lines)
            {
                string[] split = line.Split( '|' );
                cmbCommentLang.Items.Add( new ISO_639_2( split[0], split[3] ) );
            }
            cmbCommentLang.SelectedIndex = 0;
        }
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public override void Initialize( ListView lv, bool multi_edit )
        {
            base.Initialize( lv, multi_edit );
            if(multi_edit)
            {
                ckAlbum.Visible = true;
                ckAlbum.Checked = false;
                ckArtist.Visible = true;
                ckArtist.Checked = false;
                ckBMP.Visible = true;
                ckBMP.Checked = false;
                ckComment.Visible = true;
                ckComment.Checked = false;
                ckDisc.Visible = true;
                ckDisc.Checked = false;
                ckGenre.Visible = true;
                ckGenre.Checked = false;
                ckTitle.Visible = true;
                ckTitle.Checked = false;
                ckTrack.Visible = true;
                ckTrack.Checked = false;
                ckYear.Visible = true;
                ckYear.Checked = false;
            }
            else
            {
                // todo current file
            }
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            tag = v2;
            if(tag != null)
            {
                txtArtists.Text = tag.JoinedPerformers;
                txtAlbum.Text = tag.Album;
                txtTitle.Text = tag.Title;
                txtYear.Text = tag.Year.ToString();
                txtTrack.Text = tag.Track.ToString();
                txtTrackCount.Text = tag.TrackCount.ToString();
                txtBPM.Text = tag.BeatsPerMinute.ToString();
                txtDisc.Text = tag.Disc.ToString();
                txtDiscCount.Text = tag.DiscCount.ToString();
                if(tag.Genres.Length > 0)
                {
                    // this sets txtGenre.Text also via "cmbGenre_TextChanged"
                    cmbGenre.SelectedIndex = cmbGenre.FindStringExact( tag.FirstGenre ); ;
                }
                foreach(TagLib.Id3v2.CommentsFrame frame in ( (TagLib.Id3v2.Tag)tag ).GetFrames( "COMM" ))
                {
                    ListViewItem item =
                         commentList.Items.Add( frame.Description );
                    item.SubItems.Add( frame.Text );
                    item.SubItems.Add( frame.Language );
                    item.SubItems.Add( frame.TextEncoding.ToString() );
                }
                // just select first item
                if(commentList.Items.Count > 0)
                {
                    SetSelectedComment( commentList.Items[0] );
                }
            }
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            base.EditItem( item );

            if(!multi_edit || ckArtist.Checked)
                item.Id3v2.Performers = Globals.GetArray( this.txtArtists.Text );
            if(!multi_edit || ckAlbum.Checked)
                item.Id3v2.Album = this.txtAlbum.Text;
            if(!multi_edit || ckTitle.Checked)
                item.Id3v2.Title = this.txtTitle.Text;
            uint num = 0;
            if(!multi_edit || ckYear.Checked)
                item.Id3v2.Year = uint.TryParse( this.txtYear.Text, out num ) ? num : 0;
            if(!multi_edit || ckTrack.Checked)
            {
                item.Id3v2.Track = uint.TryParse( this.txtTrack.Text, out num ) ? num : 0;
                item.Id3v2.TrackCount = uint.TryParse( this.txtTrackCount.Text, out num ) ? num : 0;
            }
            if(!multi_edit || ckDisc.Checked)
            {
                item.Id3v2.Disc = uint.TryParse( this.txtDisc.Text, out num ) ? num : 0;
                item.Id3v2.DiscCount = uint.TryParse( this.txtDiscCount.Text, out num ) ? num : 0;
            }
            if(!multi_edit || ckBMP.Checked)
                item.Id3v2.BeatsPerMinute = uint.TryParse( this.txtBPM.Text, out num ) ? num : 0;
            if(!multi_edit || ckGenre.Checked)
                item.Id3v2.Genres = Globals.GetArray( txtGenres.Text );
            if(!multi_edit || ckComment.Checked)
                item.Id3v2.Comment = this.txtComment.Text;
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            base.Coalesce();
            //todo
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Artist_Click( object sender, EventArgs e )
        {
            txtArtists.Text = v1.JoinedPerformers;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Title_Click( object sender, EventArgs e )
        {
            txtTitle.Text = v1.Title;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Album_Click( object sender, EventArgs e )
        {
            txtAlbum.Text = v1.Album;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Year_Click( object sender, EventArgs e )
        {
            txtYear.Text = v1.Year.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Track_Click( object sender, EventArgs e )
        {
            txtTrack.Text = v1.Track.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Comment_Click( object sender, EventArgs e )
        {
            txtComment.Text = v1.Comment;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Genre_Click( object sender, EventArgs e )
        {
            cmbGenre.Text = v1.FirstGenre;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi = commentList.Items.Add(
                txtCommentDescriptor.Text, txtCommentDescriptor.Text, 0 );
            lvi.SubItems.Add( cmbCommentLang.Text );
            lvi.SubItems.Add( txtComment.Text );

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveComment_Click( object sender, EventArgs e )
        {
            commentList.Items.RemoveByKey( txtCommentDescriptor.Text );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTopComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi = commentList.Items[txtCommentDescriptor.Text];
            commentList.Items.RemoveByKey( txtCommentDescriptor.Text );
            commentList.Items.Insert( 0, lvi );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtArtists_DoubleClick( object sender, EventArgs e )
        {
            EditListFrm dlg = new EditListFrm( this.v1.Performers );
            dlg.ShowDialog( this );
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbGenre_TextChanged( object sender, EventArgs e )
        {
            if(!string.IsNullOrEmpty( txtGenres.Text ))
            {
                txtGenres.Text += "; " + this.cmbGenre.Text;
            }
            else
            {
                txtGenres.Text = cmbGenre.Text;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtYear_TextChanged( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commentList_ItemSelectionChanged( object sender, ListViewItemSelectionChangedEventArgs e )
        {
            if(e.IsSelected)
            {
                SetSelectedComment( e.Item );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        private void SetSelectedComment( ListViewItem item )
        {
            txtCommentDescriptor.Text = item.Text;
            txtComment.Text = item.SubItems[1].Text;
            string lang = item.SubItems[2].Text;
            cmbCommentLang.SelectedIndex = cmbCommentLang.FindString( lang.ToLower() ); ;
        }
    }
}
