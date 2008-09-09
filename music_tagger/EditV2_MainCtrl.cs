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
        private bool comments_dirty = false;
        /// <summary>
        ///  contructor
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

        #region Overrides
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
       }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            if(v2 != null)
            {
                if(multi_edit)
                {
                    Coalesce();
                }
                txtArtists.Text = v2.JoinedPerformers;
                txtAlbum.Text = v2.Album;
                txtTitle.Text = v2.Title;
                txtYear.Text = v2.Year.ToString();
                txtTrack.Text = v2.Track.ToString();
                txtTrackCount.Text = v2.TrackCount.ToString();
                txtBPM.Text = v2.BeatsPerMinute.ToString();
                txtDisc.Text = v2.Disc.ToString();
                txtDiscCount.Text = v2.DiscCount.ToString();
                if(v2.Genres.Length > 0)
                {
                    // this sets txtGenre.Text also via "cmbGenre_TextChanged"
                    cmbGenre.SelectedIndex = cmbGenre.FindStringExact( v2.FirstGenre ); ;
                }
                foreach(TagLib.Id3v2.CommentsFrame frame in ( (TagLib.Id3v2.Tag)v2 ).GetFrames( "COMM" ))
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

            if(item.Id3v2 != null)
            {
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

                UpdateCommentFrames( item );
            }
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Id3v2.Tag first_tag = tag_file.GetTag( TagLib.TagTypes.Id3v2 ) as TagLib.Id3v2.Tag;

            foreach(ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v2 );

                if(tag != null)
                {
                    if(first_tag.JoinedPerformers != tag.JoinedPerformers)
                        first_tag.Performers = new string[0];
                    if(first_tag.Album != tag.Album)
                        first_tag.Album = string.Empty;
                    if(first_tag.Title != tag.Title)
                        first_tag.Title = string.Empty;
                    if(first_tag.Track != tag.Track)
                        first_tag.Track = 0;
                    if(first_tag.TrackCount != tag.TrackCount)
                        first_tag.TrackCount = 0;
                    if(first_tag.Disc != tag.Disc)
                        first_tag.Disc = 0;
                    if(first_tag.DiscCount != tag.DiscCount)
                        first_tag.DiscCount = 0;
                    if(first_tag.Year != tag.Year)
                        first_tag.Year = 0;
                    if(first_tag.JoinedGenres != tag.JoinedGenres)
                        first_tag.Genres = new string[0];
                    if(first_tag.BeatsPerMinute != tag.BeatsPerMinute)
                        first_tag.BeatsPerMinute = 0;
                    if(first_tag.Comment != tag.Comment)
                        first_tag.Comment = string.Empty;
                 }
            }
            v2 = first_tag;
        }
        #endregion

        #region Insert From Version 1
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
        /// insert version 1 value
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
        ///   insert version 1 value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Year_Click( object sender, EventArgs e )
        {
            txtYear.Text = v1.Year.ToString();
        }
        /// <summary>
        /// insert version 1 value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Track_Click( object sender, EventArgs e )
        {
            txtTrack.Text = v1.Track.ToString();
        }
        /// <summary>
        /// insert version 1 value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Comment_Click( object sender, EventArgs e )
        {
            txtCommentDescriptor.Text = "";
            cmbCommentLang.SelectedIndex = cmbCommentLang.FindString( "xxx" );
            txtComment.Text = v1.Comment;
        }
        /// <summary>
        /// insert version 1 value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnV1Genre_Click( object sender, EventArgs e )
        {
            cmbGenre.Text = v1.FirstGenre;
        }
        #endregion

        #region Edit Comments
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi = commentList.Items.Add(
                txtCommentDescriptor.Text, txtCommentDescriptor.Text, 0 );
            lvi.SubItems.Add( txtComment.Text );
            lvi.SubItems.Add( cmbCommentLang.Text );
            comments_dirty = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveComment_Click( object sender, EventArgs e )
        {
            //commentList.Items.RemoveByKey( txtCommentDescriptor.Text );
            if(commentList.SelectedItems.Count > 0)
                commentList.SelectedItems[0].Remove();
            comments_dirty = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTopComment_Click( object sender, EventArgs e )
        {
            if(commentList.SelectedItems.Count > 0)
            {
                ListViewItem lvi = commentList.SelectedItems[0];
                commentList.Items.Remove( lvi );
                commentList.Items.Insert( 0, lvi );
                comments_dirty = true;
            }
        }
        /// <summary>
        /// Update the comment frame 
        /// </summary>
        private void UpdateCommentFrames( TagListViewItem item )
        {
            if(comments_dirty)
            {
                item.Id3v2.RemoveFrames( "COMM" );
                foreach(ListViewItem ci in commentList.Items)
                {
                    string desc = ci.Text;
                    string lang = ci.SubItems[2].Text;
                    TagLib.Id3v2.CommentsFrame cf =
                        new TagLib.Id3v2.CommentsFrame( desc, lang );
                    cf.Text = ci.SubItems[1].Text;
                    item.Id3v2.AddFrame( cf );
                }
            }
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
        /// set selected comment 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedComment( ListViewItem item )
        {
            txtCommentDescriptor.Text = item.Text;
            txtComment.Text = item.SubItems[1].Text;
            string lang = item.SubItems[2].Text;
            cmbCommentLang.SelectedIndex = cmbCommentLang.FindString( lang.ToLower() ); ;
        }
        #endregion

        #region Text Changed Events
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
            ckGenre.Checked = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtYear_TextChanged( object sender, EventArgs e )
        {
            ckYear.Checked = true;
        }
        #endregion

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
    }
}