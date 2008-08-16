using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class ProgressCtrl : UserControl
    {
        public ProgressCtrl()
        {
            InitializeComponent();
        }

        private delegate void UpdateDelegate( string file );
        public void UpdateStatus( string file )
        {
            if(InvokeRequired)
            {
                this.Invoke( new UpdateDelegate( UpdateStatus ), file );
            }
            
            lblFile.Text = file;
        }
    }
}