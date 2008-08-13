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
            this.panel1.Controls.Add( details );
            
            main.Initialize( lv );
            main.Location = this.panel1.Location;
            main.Dock = DockStyle.Fill;
            main.Show();
            
            details.Location = this.panel1.Location;
            details.Dock = DockStyle.Fill;

            lyrics.Location = this.panel1.Location;
            lyrics.Dock = DockStyle.Fill;

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
                  
        }

      
    }
}