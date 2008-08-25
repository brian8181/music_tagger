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
         public EditV2_MainCtrl()
        {
            InitializeComponent();
            string[] lines =  Properties.Resources.ISO_639_2.Split('\n');
            cmbCommentLang.Items.Add( "xxx (default)" );
            //alpha-3 (bibliographic) code|an alpha-3 (terminologic)|English name|French name
            foreach(string line in lines)
            {
                string[] split = line.Split( '|' );
                string lang = String.Format( "{0} ({1})", split[0], split[3] );
                cmbCommentLang.Items.Add( lang );
            }
            cmbCommentLang.SelectedIndex = 0;
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
                if(tag.Genres.Length > 0)
                {
                    cmbGenre.Items.AddRange( tag.Genres );
                    cmbGenre.SelectedIndex = 0;
                }
                foreach(TagLib.Id3v2.CommentsFrame frame in ((TagLib.Id3v2.Tag)tag).GetFrames( "COMM" ))
                {
                    ListViewItem item = 
                        commentList.Items.Add( frame.Description );
                    item.SubItems.Add( frame.Text );
                    item.SubItems.Add( frame.Language );
                    item.SubItems.Add( frame.TextEncoding.ToString() );
                }
                txtComment.Text = tag.Comment;

                //
                txtBPM.Text = tag.BeatsPerMinute.ToString();
            }
        }

        private void btnV1Artist_Click( object sender, EventArgs e )
        {
            txtArtists.Text = v1.JoinedPerformers;
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
            //if( !String.IsNullOrEmpty( cmbGenre.Text ) )
            //    genreList.Items.Add( cmbGenre.Text );   
        }

        private void btnRemoveGenre_Click( object sender, EventArgs e )
        {
            //if(cmbGenre.SelectedItem != null)
            //    genreList.Items.Remove( cmbGenre.SelectedItem );       
        }

        private void btnTopGenre_Click( object sender, EventArgs e )
        {
            if(cmbGenre.SelectedItem != null)
            {
                object o = cmbGenre.SelectedItem;
                //genreList.Items.Remove( o );
                //genreList.Items.Add( o );
            }
        }

        private void btnV1Genre_Click( object sender, EventArgs e )
        {
            cmbGenre.Text = v1.FirstGenre;
        }

        private void btnAddComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi = commentList.Items.Add( 
                txtCommentDescriptor.Text, txtCommentDescriptor.Text, 0 );
            lvi.SubItems.Add( cmbCommentLang.Text );
            lvi.SubItems.Add( txtComment.Text );
            
        }

        private void btnRemoveComment_Click( object sender, EventArgs e )
        {
            commentList.Items.RemoveByKey( txtCommentDescriptor.Text );    
        }

        private void btnTopComment_Click( object sender, EventArgs e )
        {
            ListViewItem lvi     = commentList.Items[txtCommentDescriptor.Text];
            commentList.Items.RemoveByKey( txtCommentDescriptor.Text );
            commentList.Items.Insert( 0, lvi );
        }

        private void txtArtists_DoubleClick( object sender, EventArgs e )
        {

        }

        private void cmbGenre_TextChanged( object sender, EventArgs e )
        {
            if(!string.IsNullOrEmpty( txtGenre.Text ))
            {
                txtGenre.Text += "; " + this.cmbGenre.Text;
            }
            else
            {
                txtGenre.Text = cmbGenre.Text;
            }
        }

        private void txtYear_TextChanged( object sender, EventArgs e )
        {

        }
    }
}
