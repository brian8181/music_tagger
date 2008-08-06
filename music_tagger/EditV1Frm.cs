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
    public partial class EditV1Frm : Form
    {
        private ListView lv = null;
        private int idx = -1;

        public EditV1Frm()
        {
            InitializeComponent();
        }

        public EditV1Frm(ListView lv) : this()
        {
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
                Fill( idx );
            }
        }

        private void Fill(int idx)
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            TagLib.File tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );

            if(id3v1 != null)
            {
                cmbArtist.Items.AddRange( id3v1.Performers );
                cmbArtist.SelectedIndex = 0;
                txtAlbum.Text = id3v1.Album;
                txtTitle.Text = id3v1.Title;
                txtYear.Text = id3v1.Year.ToString();
                txtTrack.Text = id3v1.Track.ToString();
                cmbGenre.Items.AddRange( id3v1.Genres );
                cmbGenre.SelectedIndex = 0;
                txtComment.Text = id3v1.Comment;
            } 
        }

        private void taskPrevious_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > idx && idx > 0)
            {
                Fill( --idx );
            }
        }

        private void taskNext_Click( object sender, EventArgs e )
        {
            if(lv.SelectedItems.Count > (idx + 1))
            {
                Fill( ++idx );
            }
        }
    }
}