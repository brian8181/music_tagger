using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace universal_tagger
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EditMainCtrl : EditCtrlBase
    {
        private bool comments_dirty = false;
        /// <summary>
        ///  contructor
        /// </summary>
        public EditMainCtrl()
        {
            InitializeComponent();
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
            if(tag != null)
            {
                if(multi_edit)
                {
                    Coalesce();
                }
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
                txtComment.Text = tag.Comment;
                
            }
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            base.EditItem( item );

            if(item.MetaTag != null)
            {
                if(!multi_edit || ckArtist.Checked)
                    item.MetaTag.Performers = Functions.GetArray( this.txtArtists.Text );
                if(!multi_edit || ckAlbum.Checked)
                    item.MetaTag.Album = this.txtAlbum.Text;
                if(!multi_edit || ckTitle.Checked)
                    item.MetaTag.Title = this.txtTitle.Text;
                uint num = 0;
                if(!multi_edit || ckYear.Checked)
                    item.MetaTag.Year = uint.TryParse( this.txtYear.Text, out num ) ? num : 0;
                if(!multi_edit || ckTrack.Checked)
                {
                    item.MetaTag.Track = uint.TryParse( this.txtTrack.Text, out num ) ? num : 0;
                    item.MetaTag.TrackCount = uint.TryParse( this.txtTrackCount.Text, out num ) ? num : 0;
                }
                if(!multi_edit || ckDisc.Checked)
                {
                    item.MetaTag.Disc = uint.TryParse( this.txtDisc.Text, out num ) ? num : 0;
                    item.MetaTag.DiscCount = uint.TryParse( this.txtDiscCount.Text, out num ) ? num : 0;
                }
                if(!multi_edit || ckBMP.Checked)
                    item.MetaTag.BeatsPerMinute = uint.TryParse( this.txtBPM.Text, out num ) ? num : 0;
                if(!multi_edit || ckGenre.Checked)
                    item.MetaTag.Genres = Functions.GetArray( txtGenres.Text );
                if(!multi_edit || ckComment.Checked)
                    item.MetaTag.Comment = this.txtComment.Text;
                // BKP
                //UpdateCommentFrames( item );
            }
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File tag_file = TagLib.File.Create(fi.FullName);
            TagLib.Tag tag2 = tag_file.Tag;

            foreach (ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                tag_file = TagLib.File.Create(fi.FullName);
                TagLib.Tag tag = tag_file.Tag;

                if (tag != null)
                {
                    if (tag2.JoinedPerformers != tag.JoinedPerformers)
                        tag2.Performers = new string[0];
                    if (tag2.Album != tag.Album)
                        tag2.Album = string.Empty;
                    if (tag2.Title != tag.Title)
                        tag2.Title = string.Empty;
                    if (tag2.Track != tag.Track)
                        tag2.Track = 0;
                    if (tag2.TrackCount != tag.TrackCount)
                        tag2.TrackCount = 0;
                    if (tag2.Disc != tag.Disc)
                        tag2.Disc = 0;
                    if (tag2.DiscCount != tag.DiscCount)
                        tag2.DiscCount = 0;
                    if (tag2.Year != tag.Year)
                        tag2.Year = 0;
                    if (tag2.JoinedGenres != tag.JoinedGenres)
                        tag2.Genres = new string[0];
                    if (tag2.BeatsPerMinute != tag.BeatsPerMinute)
                        tag2.BeatsPerMinute = 0;
                    if (tag2.Comment != tag.Comment)
                        tag2.Comment = string.Empty;
                }
            }
            //tag = tag2;
        }
        #endregion
       

        
        #region Text Changed Events
        private void txtArtists_TextChanged(object sender, EventArgs e)
        {
            ckArtist.Checked = true;
        }
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            ckTitle.Checked = true;
        }
        private void txtAlbum_TextChanged(object sender, EventArgs e)
        {
            ckAlbum.Checked = true;
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
            EditListFrm dlg = new EditListFrm( this.tag.Performers );
            dlg.ShowDialog( this );
            StringBuilder sb = new StringBuilder();
            if(dlg.Strs != null)
            {
                string s = Functions.GetString( dlg.Strs );
                txtArtists.Text = s;
            }
            else
            {
                txtArtists.Text = string.Empty;
            }
        }
    }
}