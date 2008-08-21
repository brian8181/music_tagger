using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace music_tagger
{
    public partial class MainFrm : Form
    {
        // redundant !
        private TagLib.TagTypes type = TagLib.TagTypes.Id3v2;
        /// <summary>
        /// 
        /// </summary>
        public MainFrm()
        {
            InitializeComponent();
            tree.Configure();
            type = Properties.Settings.Default.view_ver1 ? TagLib.TagTypes.Id3v1 : TagLib.TagTypes.Id3v2;
            //BKP todo clean this shit up!! 
            tsb_ToggleVer.Text = ( type == TagLib.TagTypes.Id3v2 ) ? "Shown Ver. 2" : "Shown Ver. 1";
            view.Configure( tree, type );
            view.Refreshed += new EventHandler<View.RefreshArgs>( view_Refreshed );
            SetScanOption();
        }
               
        /// <summary>
        /// 
        /// </summary>
        private void LoadSettings()
        {
            // menu
            mnViewV1.Checked = Properties.Settings.Default.view_ver1;
            mnViewV2.Checked = !mnViewV1.Checked;
            mnOptionsScanSubs.Checked = Properties.Settings.Default.scan_subdirs;

            string[] dirs = Properties.Settings.Default.last_dir.Split( '\\' );
            //tree.Nodes.Add(ContainsKey();
            //todo
        }
        /// <summary>
        /// 
        /// </summary>
        private void SaveSettings()
        {
            // todo
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_EditV2_Click( object sender, EventArgs e )
        {
            if(this.view.ListView.SelectedItems.Count > 0)
            {
                EditV2Frm dlg = new EditV2Frm( view.ListView );
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_EditV2Multi_Click( object sender, EventArgs e )
        {

            if(this.view.ListView.SelectedItems.Count > 1)
            {
                EditV2Frm dlg = new EditV2Frm( view.ListView, true );
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    // todo
                }
            }
            else
            {
                tsb_EditV2_Click( sender, e );
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
            if(view.IsDirty)
            {
                DialogResult dr = MessageBox.Show(
                       "This cause you to lose all pending changes. Do you with to save first?",
                       "Save Pending Changes",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Asterisk );

                if(dr == DialogResult.Yes)
                {
                    view.Commit();
                }
            }
            ToggleVer();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ToggleVer()
        {
            if(tsb_ToggleVer.Text == "Shown Ver. 1")
            {
                tsb_ToggleVer.Text = "Shown Ver. 2";
                view.Type = TagLib.TagTypes.Id3v2;
                type = TagLib.TagTypes.Id3v2;
            }
            else
            {
                tsb_ToggleVer.Text = "Shown Ver. 1";
                view.Type = TagLib.TagTypes.Id3v1;
                type = TagLib.TagTypes.Id3v1;
            }

        }

        //  todo combine these !!
        private void mnViewV1_Click( object sender, EventArgs e )
        {
            mnViewV2.Checked = !mnViewV1.Checked;
            ToggleVer();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ( new AboutBox() ).ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnEditUndo_Click( object sender, EventArgs e )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnEditRedo_Click( object sender, EventArgs e )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnEditCut_Click( object sender, EventArgs e )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnEditCopy_Click( object sender, EventArgs e )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnEditPast_Click( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            Regex regx = new Regex( pattern );
            Match m = regx.Match( full_path );
            string drive = m.Groups["DRIVE"].Value;
            string path = m.Groups["PATH"].Value;

            Properties.Settings.Default.last_dir = drive + path;
            Properties.Settings.Default.Save();
            
            if(view.IsDirty)
            {
                DialogResult dr = MessageBox.Show(
                       "Do you with to save pending changes before closing?",
                       "Save Pending Changes",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Asterisk );

                if(dr == DialogResult.Yes)
                {
                    view.Commit();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnRemoveTagV1_Click( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnFile2TagV1_Click( object sender, EventArgs e )
        {
            File2TagV1Frm dlg = new File2TagV1Frm();
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
        private void mnTag2FileV1_Click( object sender, EventArgs e )
        {
            TagV12FileFrm dlg = new TagV12FileFrm( view );
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
        private void mnRemoveTagV2_Click( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnFile2TagV2_Click( object sender, EventArgs e )
        {
            File2TagV2Frm dlg = new File2TagV2Frm();
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
        private void mnTag2FileV2_Click( object sender, EventArgs e )
        {
            TagV22FileFrm dlg = new TagV22FileFrm();
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
        private void On_CaseConvert( object sender, EventArgs e )
        {
            CaseConvertFrm dlg = new CaseConvertFrm();
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
        private void mnFindDuplicates_Click( object sender, EventArgs e )
        {
            FindDuplicateFrm dlg = new FindDuplicateFrm();
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
        private void mnCompareFile2Tag_Click( object sender, EventArgs e )
        {
            CompareFile2TagFrm dlg = new CompareFile2TagFrm();
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
        private void On_Save( object sender, EventArgs e )
        {
            DialogResult dr = MessageBox.Show(
                    "Are you sure you wish to commit all changes?",
                    "Commit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk );

            if(dr == DialogResult.OK)
            {
                view.Commit();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnOptionsScanSubs_Click( object sender, EventArgs e )
        {
            SetScanOption();
        }
        /// <summary>
        /// 
        /// </summary>
        private void SetScanOption()
        {
            if(mnOptionsScanSubs.Checked)
            {
                view.SearchOption = SearchOption.AllDirectories;
            }
            else
            {
                view.SearchOption = SearchOption.TopDirectoryOnly;
            }
            tsScanSubs.Text = "Scan Option:" + view.SearchOption.ToString();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void view_Refreshed( object sender, View.RefreshArgs e )
        {
            tsFileCount.Text = "File Count: " + e.FileCount.ToString();
            tsCurrentPath.Text = e.Path;
        }
    }
}