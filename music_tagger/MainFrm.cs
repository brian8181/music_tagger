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
            if(this.view.ListView.SelectedItems.Count > 0)
            {
                EditV1Frm dlg = new EditV1Frm( view.ListView );
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo  
                }
            }
            
        }

        private void tsb_EditV1Multi_Click( object sender, EventArgs e )
        {
            if(this.view.ListView.SelectedItems.Count > 0)
            {
                EditMultiV1Frm dlg = new EditMultiV1Frm( view.ListView );
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo
                }
            }
        }

        private void tsb_EditV2_Click( object sender,   EventArgs e )
        {
            if(this.view.ListView.SelectedItems.Count > 0)
            {
                EditV2Frm dlg = new EditV2Frm();
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo
                }
            }
        }

        private void tsb_EditV2Multi_Click( object sender, EventArgs e )
        {
            if(this.view.ListView.SelectedItems.Count > 0)
            {
                // todo
            }
        }

        private void mnPrefs_Click( object sender, EventArgs e )
        {
            PrefFrm dlg = new PrefFrm();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo
            }
        }

        private void OnToggleVer( object sender, EventArgs e )
        {
            tsb_ToggleVer.Text = tsb_ToggleVer.Text == "Shown Ver. 1" ? "Shown Ver. 2" : "Shown Ver. 1";    
        }
    }
}