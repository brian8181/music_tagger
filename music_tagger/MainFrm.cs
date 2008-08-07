using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            tree.Configure();
            view.Configure( tree );
        }

        private void tsb_EditV1_Click( object sender, EventArgs e )
        {
            EditV1Frm dlg = new EditV1Frm(view.ListView);
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo  
            }
            
        }

        private void tsb_EditV1Multi_Click( object sender, EventArgs e )
        {
            EditMultiV1Frm dlg = new EditMultiV1Frm( view.ListView );
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo
            }
        }

        private void tsb_EditV2_Click( object sender,   EventArgs e )
        {
            EditV2Frm dlg = new EditV2Frm();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo
            }
        }

        private void tsb_EditV2Multi_Click( object sender, EventArgs e )
        {
            // todo
        }

        private void anlyseToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

    }
}