using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace music_tagger
{
    public partial class EditV2Frm : Form
    {
        protected ListView lv = null;
        private EditV2_MainCtrl main = new EditV2_MainCtrl();
        private EditV2_DetailCtrl details = new EditV2_DetailCtrl();
        private EditV2_LyricCtrl lyrics = new EditV2_LyricCtrl();
        private EditV2_PictureCtrl pictures = new EditV2_PictureCtrl();
        private Control current = null;
        public EditV2Frm()
        {
            InitializeComponent();
        }
         /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditV2Frm(ListView lv) 
        {
            InitializeComponent();
            this.lv = lv;
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
            current = main;
        }
        private void taskMain_Click( object sender, EventArgs e )
        {
            if(current != main)
            {
                current.Hide();
                main.Show();
                current = main;
            }
        }
        private void taskDetails_Click( object sender, EventArgs e )
        {
            if(current != details)
            {
                current.Hide();
                details.Show();
                current = details;
            }
        }
        private void taskLyrics_Click( object sender, EventArgs e )
        {
            if(current != lyrics)
            {
                current.Hide();
                lyrics.Show();
                current = lyrics;
            }
        }
        private void taskPicture_Click( object sender, EventArgs e )
        {
            if(current != pictures)
            {
                current.Hide();
                pictures.Show();
                current = pictures;
            }          
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {

        }

        private void btnOK_Click( object sender, EventArgs e )
        {
            foreach(ListViewItem item in lv.SelectedItems)
            {
                item.BackColor = Color.Yellow;
                item.SubItems["Artist"].Text = main.cmbArtist.Text;
                item.SubItems["Album"].Text = main.txtAlbum.Text;
            }
            Close();
        }
    }
}