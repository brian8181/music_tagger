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
    public partial class EditV2_MainCtrl : EditV2CtrlBase
    {
         public EditV2_MainCtrl()
        {
            InitializeComponent();
        }
         /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill( TagLib.Tag tag )
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
            ListViewItem lvi = commentList.Items.Add( 
                cmbCommentDesciptor.Text, cmbCommentDesciptor.Text, 0 );
            lvi.SubItems.Add( cmbCommentLang.Text );
            lvi.SubItems.Add( txtComment.Text );
            
        }

        private void btnRemoveComment_Click( object sender, EventArgs e )
        {
            commentList.Items.RemoveByKey( cmbCommentDesciptor.Text );    
        }

        private void btnTopComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi     = commentList.Items[cmbCommentDesciptor.Text];
            commentList.Items.RemoveByKey( cmbCommentDesciptor.Text );
            commentList.Items.Insert( 0, lvi );
        }
    }
}
