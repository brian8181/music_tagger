using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class PrefFrm : Form
    {
        public PrefFrm()
        {
            InitializeComponent();
           
            columnList.Items.Add( "File Name" );
            columnList.Items.Add( "File Path" );
            columnList.Items.Add( "Size" );
            columnList.Items.Add( "Attributes" );
            columnList.Items.Add( "Last Access" );
            columnList.Items.Add( "Last Write" );
            columnList.Items.Add( "Created" );
            columnList.Items.Add( "Track" );
            columnList.Items.Add( "Artist" );
            columnList.Items.Add( "Album" );
            columnList.Items.Add( "Title" );
            columnList.Items.Add( "Year" );
            columnList.Items.Add( "Comment" );
            columnList.Items.Add( "Genre" );
            columnList.Items.Add( "Lenght" );

            ckRestoreFolder.Checked = Properties.Settings.Default.restore_dir;
        }

       
        private void btnOK_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.Save();
        }

        private void btnApply_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.Save();
        }
    }
}