using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

        private void LoadSettings()
        {
            // menu
            mnViewV1.Checked = Properties.Settings.Default.view_ver1;
            mnViewV2.Checked = !mnViewV1.Checked;
            mnOptionsScanSubs.Checked = Properties.Settings.Default.scan_subdirs;

            string[] dirs = Properties.Settings.Default.last_dir.Split('\\');
            //tree.Nodes.Add(ContainsKey();
            //todo
        }

        private void SaveSettings()
        {

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnPrefs_Click( object sender, EventArgs e )
        {
            PrefFrm dlg = new PrefFrm();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnToggleVer( object sender, EventArgs e )
        {
            ToggleVer();   
        }

        /// <summary>
        /// 
        /// </summary>
        private void ToggleVer()
        {
             tsb_ToggleVer.Text = tsb_ToggleVer.Text == "Shown Ver. 1" ? "Shown Ver. 2" : "Shown Ver. 1";    
        }

        //  todo combine these !!
        private void mnViewV1_Click( object sender, EventArgs e )
        {
            mnViewV2.Checked = !mnViewV1.Checked;
            ToggleVer();
        }
        private void mnViewV2_Click( object sender, EventArgs e )
        {
            mnViewV1.Checked = !mnViewV2.Checked;
            ToggleVer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnFileOrganize_Click( object sender, EventArgs e )
        {
            OrganizeFrm dlg = new OrganizeFrm( view.ListView );
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                // todo
            }
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ( new AboutBox() ).ShowDialog();
        }

        private void mnEditUndo_Click( object sender, EventArgs e )
        {
        }

        private void mnEditRedo_Click( object sender, EventArgs e )
        {
        }

        private void mnEditCut_Click( object sender, EventArgs e )
        {
        }

        private void mnEditCopy_Click( object sender, EventArgs e )
        {
        }

        private void mnEditPast_Click( object sender, EventArgs e )
        {
        }

        private void mnEditSelectAll_Click( object sender, EventArgs e )
        {
            view.SelectAll();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFrm_FormClosing( object sender, FormClosingEventArgs e )
        {
            // extract path from node path
            string full_path = tree.SelectedNode.FullPath;
            string pattern = @"^.*\((?<DRIVE>[A-Z]:).*\)(?<PATH>\\.*$)";
            Regex regx = new Regex(pattern);
            Match m = regx.Match( full_path );
            string drive = m.Groups["DRIVE"].Value;
            string path = m.Groups["PATH"].Value;

            Properties.Settings.Default.last_dir = drive + path;
            Properties.Settings.Default.Save();
        }

    }
}