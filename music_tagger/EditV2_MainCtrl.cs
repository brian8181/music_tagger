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
    public partial class EditV2_MainCtrl : UserControl
    {
        private TagLib.File tag_file = null;
        private TagLib.Tag v1;
        private TagLib.Tag v2;
 
        private ListView lv = null;
        private int idx = -1;

        public EditV2_MainCtrl()
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
        public void Fill( int idx )
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            //  lblFile.Text = fi.FullName;
            tag_file = TagLib.File.Create( fi.FullName );
            v2 = tag_file.GetTag( TagLib.TagTypes.Id3v2 );
            v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
            Fill( v2 );
            
            //
            
            string lang = TagLib.Id3v2.Tag.Language;
            TagLib.Id3v2.CommentsFrame frame = TagLib.Id3v2.CommentsFrame.GetPreferred( (TagLib.Id3v2.Tag)v2, string.Empty, "xxx" );
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public void Fill( TagLib.Tag tag )
        {
            if(tag != null)
            {
                if(tag.Performers.Length > 0)
                {
                    cmbArtist.Items.AddRange( tag.Performers );
                    cmbArtist.SelectedIndex = 0;
                }
                txtAlbum.Text = tag.Album;
                txtTitle.Text = tag.Title;
                txtYear.Text = tag.Year.ToString();
                txtTrack.Text = tag.Track.ToString();
                if(tag.Genres.Length > 0)
                {
                    cmbGenre.Items.AddRange( tag.Genres );
                    cmbGenre.SelectedIndex = 0;
                }
                txtComment.Text = tag.Comment;

                //
                txtBPM.Text = tag.BeatsPerMinute.ToString();
            }
        }

        private void btnV1Artist_Click( object sender, EventArgs e )
        {
           cmbArtist.Text = v1.FirstPerformer;
        }

        private void btnV1Title_Click( object sender, EventArgs e )
        {
            txtTitle.Text = v1.Title;
        }

        private void btnV1Album_Click( object sender, EventArgs e )
        {
            txtAlbum.Text = v1.Album;
        }

        private void btnV1Year_Click( object sender, EventArgs e )
        {
            txtYear.Text = v1.Year.ToString();
        }

        private void btnV1Track_Click( object sender, EventArgs e )
        {
            txtTrack.Text = v1.Track.ToString();  
        }

        private void btnV1Comment_Click( object sender, EventArgs e )
        {
            txtComment.Text = v1.Comment;
        }

        private void btnAddGenre_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrEmpty( cmbGenre.Text ) )
                genreList.Items.Add( cmbGenre.Text );   
        }

        private void btnRemoveGenre_Click( object sender, EventArgs e )
        {
            if( genreList.SelectedItem != null )
                genreList.Items.Remove( genreList.SelectedItem );       
        }

        private void btnTopGenre_Click( object sender, EventArgs e )
        {
            if(genreList.SelectedItem != null)
            {
                object o = genreList.SelectedItem;
                genreList.Items.Remove( o );
                genreList.Items.Add( o );
            }
        }

        private void btnV1Genre_Click( object sender, EventArgs e )
        {
            cmbGenre.Text = v1.FirstGenre;
        }

        private void btnAddComment_Click( object sender, EventArgs e )
        {

        }

        private void btnRemoveComment_Click( object sender, EventArgs e )
        {

        }

        private void btnTopComment_Click( object sender, EventArgs e )
        {

        }
    }
}
