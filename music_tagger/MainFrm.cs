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
            : this(Properties.Settings.Default.last_dir)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public MainFrm(string path)
        {
            Properties.Settings.Default.last_dir = path;
            InitializeComponent();
            type = Properties.Settings.Default.view_ver1 ? TagLib.TagTypes.Id3v1 : TagLib.TagTypes.Id3v2;
            SetVersion( Properties.Settings.Default.view_ver1 );
            // init tree
            tree.Initilaize();
            // init view
            view.Initialize( tree, type );
            view.Refreshed += new EventHandler<View.RefreshArgs>( view_Refreshed );
            view.ListView.SelectedIndexChanged += new EventHandler( ListView_SelectedIndexChanged );
                      
            LoadSettings();
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
            string name = Path.GetFileName( Properties.Settings.Default.last_dir );

            tree.Open( Properties.Settings.Default.last_dir );
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
        private void On_Transfer_Click( object sender, EventArgs e )
        {
            TransferFrm dlg = new TransferFrm(this.view.ListView);
            dlg.ShowDialog();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditV1_Click( object sender, EventArgs e )
        {
            this.view.OnEditV1();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditV1Multi_Click( object sender, EventArgs e )
        {
            this.view.OnEditV1_Multi();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditV2_Click( object sender, EventArgs e )
        {
            this.view.OnEditV2();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnEditV2Multi_Click( object sender, EventArgs e )
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
                OnEditV2_Click( sender, e );
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
                view.RefreshView( true );
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
            Properties.Settings.Default.view_ver1 = !Properties.Settings.Default.view_ver1;
            SetVersion( Properties.Settings.Default.view_ver1 );             
        }
        private void SetVersion( bool ver1 )
        {
            if(Properties.Settings.Default.view_ver1)
            {
                tsb_ToggleVer.Text = Properties.Resources.showing_ver2;
                view.Type = TagLib.TagTypes.Id3v2;
                type = TagLib.TagTypes.Id3v2;
            }
            else
            {
                tsb_ToggleVer.Text = Properties.Resources.showing_ver1;
                view.Type = TagLib.TagTypes.Id3v1;
                type = TagLib.TagTypes.Id3v1;
            }
            tsVersionShown.Text = tsb_ToggleVer.Text;
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

            view.AskToCommit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnFile2TagV1_Click( object sender, EventArgs e )
        {
            File2TagV1Frm dlg = new File2TagV1Frm( view );
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //
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
        private void OnRemoveTagV2_Click( object sender, EventArgs e )
        {
            view.RemoveTags(TagLib.TagTypes.Id3v2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnRemoveTagV1_Click(object sender, EventArgs e)
        {

            view.RemoveTags(TagLib.TagTypes.Id3v1);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFile2TagV2_Click( object sender, EventArgs e )
        {
            File2TagV2Frm dlg = new File2TagV2Frm( this.view );
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
        private void OnTag2FileV2_Click( object sender, EventArgs e )
        {
            TagV22FileFrm dlg = new TagV22FileFrm(this.view);
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
                    Properties.Resources.commit_warning,
                    Properties.Resources.save_pending,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk );

            if(dr == DialogResult.Yes)
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
            UpdateFileStatus();
            tsCurrentPath.Text = e.Path;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ListView_SelectedIndexChanged( object sender, EventArgs e )
        {
            UpdateFileStatus();
        }
        /// <summary>
        /// update the fiel status label
        /// </summary>
        private void UpdateFileStatus()
        {
            tsFileCount.Text = String.Format( "Selected: {0} of {1}", 
               view.ListView.SelectedItems.Count,
                view.ListView.Items.Count ); 
        }
        /// <summary>
        /// refresh clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_Refresh( object sender, EventArgs e )
        {
            view.RefreshView();
        }
        /// <summary>
        /// get help clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHelp_Clicked( object sender, EventArgs e )
        {
            OnHelp();
        }
        /// <summary>
        ///  open web page for help
        /// </summary>
        public void OnHelp()
        {
            string target = @"http://fire.dynalias.org/wiki/index.php/Music_Tagger";
            try
            {
                System.Diagnostics.Process.Start( target );
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if(noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show( noBrowser.Message );
            }
            catch(System.Exception other)
            {
                MessageBox.Show( other.Message );
            }
        }

        private void mnFileCopyTo_Click(object sender, EventArgs e)
        {
            view.CopyTo(false);
        }

        private void mnFileMoveTo_Click(object sender, EventArgs e)
        {
            view.CopyTo(true);
        }

        private void deleteFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Delete();
        }
    
   }
}