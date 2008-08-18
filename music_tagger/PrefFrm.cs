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
            string[] cols = Enum.GetNames(typeof(Column));
            foreach(string c in cols)
            {
                columnList.Items.Add( cols );
            }
            ckRestoreFolder.Checked = Properties.Settings.Default.restore_dir;
        }

       
        private void btnOK_Click( object sender, EventArgs e )
        {
            // add remove cols

            Properties.Settings.Default.Save();
        }

        private void btnApply_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.Save();
        }
    }
}