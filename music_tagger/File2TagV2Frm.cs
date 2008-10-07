using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class File2TagV2Frm : Form
    {
        public File2TagV2Frm()
        {
            InitializeComponent();


            string[] fmts = new string[Properties.Settings.Default.file2tagv2_formats.Count];
            Properties.Settings.Default.file2tagv2_formats.CopyTo( fmts, 0 );
            cmbFormat.Items.AddRange( fmts );
            cmbFormat.SelectedIndex = cmbFormat.FindStringExact( Properties.Settings.Default.file2tagv2_last_format );
        }
    }
}