using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class EditV1Frm : EditFrm
    {
        /// <summary>
        ///  default contructor ( for designer )
        /// </summary>
        public EditV1Frm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// contructor 
        /// </summary>
        /// <param name="lv"></param>
        public EditV1Frm( ListView lv )
            : this( lv, false )
        {
        }
        /// <summary>
        /// contructor 
        /// </summary>
        /// <param name="lv"></param>
        public EditV1Frm( ListView lv, bool multi_edit )
            : base( lv, multi_edit )
        {
            InitializeComponent();
            editCtrl.Initialize( lv );
            Initialize();
        }
        /// <summary>
        /// intialize
        /// </summary>
        public override void Initialize()
        {
            if(multi_edit)
            {
                this.editCtrl.ckAlbum.Visible = true;
                this.editCtrl.ckAlbum.Checked = false;
                this.editCtrl.ckArtist.Visible = true;
                this.editCtrl.ckArtist.Checked = false;
                this.editCtrl.ckComment.Visible = true;
                this.editCtrl.ckComment.Checked = false;
                this.editCtrl.ckGenre.Visible = true;
                this.editCtrl.ckGenre.Checked = false;
                this.editCtrl.ckTitle.Visible = true;
                this.editCtrl.ckTitle.Checked = false;
                this.editCtrl.ckTrack.Visible = true;
                this.editCtrl.ckTrack.Checked = false;
                this.editCtrl.ckYear.Visible = true;
                this.editCtrl.ckYear.Checked = false;
                Coalesce();
            }
            else
            {
                this.editCtrl.lblFile.Visible = true;
                this.editCtrl.lblFileTag.Visible = true;
            }
        }
        /// <summary>
        /// button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            if(this.multi_edit)
            {
                foreach(ListViewItem item in lv.SelectedItems)
                {
                    EditItem( (TagListViewItem)item );
                }
            }
            else
            {
                EditItem( (TagListViewItem)lv.SelectedItems[0] );
            }
            Close();
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        protected override void EditItem( TagListViewItem item )
        {
            item.BackColor = Color.Yellow;
            // Performers
            if(!String.IsNullOrEmpty( editCtrl.txtArtist.Text ))
            {
                if(editCtrl.txtArtist.ReadOnly)
                {
                    item.Id3v2.Performers = editCtrl.artist;
                }
                else
                {
                    item.Id3v1.Performers[0] = editCtrl.txtArtist.Text;
                }
            }
            item.Id3v1.Album = this.editCtrl.txtAlbum.Text;
            item.Id3v1.Title = this.editCtrl.txtTitle.Text;
            uint num = 0;
            item.Id3v1.Year = uint.TryParse( this.editCtrl.txtYear.Text, out num ) ? num : 0;
            item.Id3v1.Track = uint.TryParse( this.editCtrl.txtTrack.Text, out num ) ? num : 0;
            // Genres
            if(!String.IsNullOrEmpty( editCtrl.cmbGenre.Text ))
            {
                item.Id3v1.Genres = new string[1] { editCtrl.cmbGenre.Text };
            }
            item.Id3v1.Comment = this.editCtrl.txtComment.Text;
            item.RefreshItem();
        }
        /// <summary>
        /// button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnCancel_Click( object sender, EventArgs e )
        {
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Tag last_tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );

            foreach(ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );

                last_tag.Album = last_tag.Album != "" && tag.Album == last_tag.Album ? tag.Album : "";
                //last_tag.Artists = last_tag.Artists != "" && tag.Artists == last_tag.Artists ? tag.Artists : "";
                last_tag.Title = last_tag.Title != "" && tag.Title == last_tag.Title ? tag.Title : "";
                last_tag.Track = last_tag.Track != 0 && tag.Track == last_tag.Track ? tag.Track : 0;
                last_tag.Year = last_tag.Year != 0 && tag.Year == last_tag.Year ? tag.Year : 0;
            }
            this.editCtrl.Fill( last_tag );
        }
    }
}