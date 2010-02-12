using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger.Threading
{
    public partial class ProgressCtrl : UserControl
    {
        public ProgressCtrl()
        {
            InitializeComponent();
        }

        //private delegate void UpdateDelegate( string file );
        public void UpdateStatus( string file )
        {
            lblFile.Text = file;
        }
    }
}
