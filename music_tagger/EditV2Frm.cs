using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2Frm : EditFrm
    {
        private EditV2_MainCtrl main = new EditV2_MainCtrl();
        private EditV2_DetailCtrl details = new EditV2_DetailCtrl();
        private EditV2_OriginalCtrl original = new EditV2_OriginalCtrl();
        private EditV2_LyricCtrl lyrics = new EditV2_LyricCtrl();
        private EditV2_WebCtrl web = new EditV2_WebCtrl();
        private EditV2_PictureCtrl pictures = new EditV2_PictureCtrl();
        private Control current = null;
        
        /// <summary>
        ///  default ctor
        /// </summary>
        public EditV2Frm()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multi_edit"></param>
        public EditV2Frm( ListView lv)  : this( lv, false )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditV2Frm( ListView lv, bool multi_edit ) : base( lv, multi_edit )
        {
            InitializeComponent();
            this.panel1.Controls.Add( main );
            main.Initialize( lv );
            main.Location = this.panel1.Location;
            main.Dock = DockStyle.Fill;
            main.Show();
            this.panel1.Controls.Add( details );
            details.Location = this.panel1.Location;
            details.Dock = DockStyle.Fill;
            details.Initialize( lv );
            details.Hide();
            this.panel1.Controls.Add( lyrics );
            lyrics.Location = this.panel1.Location;
            lyrics.Dock = DockStyle.Fill;
            lyrics.Initialize( lv );
            lyrics.Hide();
            this.panel1.Controls.Add( pictures );
            pictures.Location = this.panel1.Location;
            pictures.Dock = DockStyle.Fill;
            pictures.Initialize( lv );
            pictures.Hide();
            this.panel1.Controls.Add( web );
            web.Location = this.panel1.Location;
            web.Dock = DockStyle.Fill;
            web.Initialize( lv );
            web.Hide();
            this.panel1.Controls.Add( original );
            original.Location = this.panel1.Location;
            original.Dock = DockStyle.Fill;
            original.Initialize( lv );
            original.Hide();
            current = main;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskMain_Click( object sender, EventArgs e )
        {
            if(current != main)
            {
                current.Hide();
                main.Show();
                current = main;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskDetails_Click( object sender, EventArgs e )
        {
            if(current != details)
            {
                current.Hide();
                details.Show();
                current = details;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskLyrics_Click( object sender, EventArgs e )
        {
            if(current != lyrics)
            {
                current.Hide();
                lyrics.Show();
                current = lyrics;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPicture_Click( object sender, EventArgs e )
        {
            if(current != pictures)
            {
                current.Hide();
                pictures.Show();
                current = pictures;
            }          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskWeb_Click( object sender, EventArgs e )
        {
            if(current != web)
            {
                current.Hide();
                web.Show();
                current = web;
            }     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskOriginal_Click( object sender, EventArgs e )
        {
            if(current != original)
            {
                current.Hide();
                original.Show();
                current = original;
            }     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        ///  edit a item
        /// </summary>
        /// <param name="item"></param>
        protected override void EditItem( TagListViewItem item )
        {
            //BKP  move to controls EditItem 
            item.BackColor = Color.Yellow;
            item.Id3v2.Performers = Globals.GetArray( main.txtArtists.Text );
            item.Id3v2.Album = main.txtAlbum.Text;
            item.Id3v2.Title = main.txtTitle.Text;
            uint num = 0;
            item.Id3v2.Year = uint.TryParse( main.txtYear.Text, out num ) ? num : 0;
            item.Id3v2.Track = uint.TryParse( main.txtTrack.Text, out num ) ? num : 0;
            item.Id3v2.TrackCount = uint.TryParse( main.txtTrackCount.Text, out num ) ? num : 0;
            item.Id3v2.Disc = uint.TryParse( main.txtDisc.Text, out num ) ? num : 0;
            item.Id3v2.DiscCount = uint.TryParse( main.txtDiscCount.Text, out num ) ? num : 0;
            item.Id3v2.BeatsPerMinute = uint.TryParse( main.txtBPM.Text, out num ) ? num : 0;
            //item.Id3v2.Genres = new string[main.cm.Items.Count];
            item.Id3v2.Comment = main.txtComment.Text;
            item.RefreshItem();
        }
    }
}