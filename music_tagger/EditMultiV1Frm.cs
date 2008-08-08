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
    public partial class EditMultiV1Frm : music_tagger.EditV1Frm
    {
        /// <summary>
        /// 
        /// </summary>
        public EditMultiV1Frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditMultiV1Frm( ListView lv )
            : base( lv )
        {
            InitializeComponent();
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

        public override void Initialize()
        {
        }

        public void Coalesce()
        {
            //TODO 

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

