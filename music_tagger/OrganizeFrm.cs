using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace music_tagger
{
    /// <summary>
    /// organinze form
    /// </summary>
    public partial class OrganizeFrm : Form
    {
        private ListView lv = null;
        /// <summary>
        /// 
        /// </summary>
        public OrganizeFrm()
        {
            InitializeComponent();
            Initialize();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public OrganizeFrm( ListView lv ) 
        {
            InitializeComponent();
            this.lv = lv;
            Initialize();
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize()
        {
            if(lv.SelectedItems.Count < 1)
            {
                return;
            }
            if(Properties.Settings.Default.org_ver1)
                rbV1.Checked = true;
            else
                rbV2.Checked = true;
            ckCopy.Checked = Properties.Settings.Default.org_copy;
            ckOverwrite.Checked = Properties.Settings.Default.org_overwrite;
            txtPath.Text = Properties.Settings.Default.org_root_dir;
            string[] fmts = new string[Properties.Settings.Default.org_formats.Count];
            Properties.Settings.Default.org_formats.CopyTo( fmts, 0 );
            cmbFormat.Items.AddRange( fmts );
            cmbFormat.SelectedIndex = cmbFormat.FindStringExact( Properties.Settings.Default.org_last_format );
        }
        /// <summary>
        /// 
        /// </summary>
        public void SaveSettings()
        {
            Properties.Settings.Default.org_ver1 = rbV1.Checked;
            Properties.Settings.Default.org_copy = ckCopy.Checked;
            Properties.Settings.Default.org_overwrite = ckOverwrite.Checked;
            Properties.Settings.Default.org_root_dir = txtPath.Text;
            // formats
            string[] fmts = new string[cmbFormat.Items.Count];
            cmbFormat.Items.CopyTo( fmts, 0 );
            Properties.Settings.Default.org_formats.Clear();
            Properties.Settings.Default.org_formats.AddRange( fmts );
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click( object sender, EventArgs e )
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dlg.SelectedPath;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click( object sender, EventArgs e )
        {
            if(!cmbFormat.Items.Contains( cmbFormat.Text ))
            {
                cmbFormat.Items.Add( cmbFormat.Text ); 
            }
            SaveSettings();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click( object sender, EventArgs e )
        {
            if(cmbFormat.Items.Contains( cmbFormat.Text ))
            {
                cmbFormat.Items.Remove( cmbFormat.Text );
            }
            SaveSettings();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            if(String.IsNullOrEmpty( txtPath.Text ) || String.IsNullOrEmpty( cmbFormat.Text ))
            {
                MessageBox.Show(
                    "Please eneter a valid format and path.",
                    "Invalid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk );
                return;
            }
            //SaveSettings();
            ListView.SelectedListViewItemCollection items = lv.SelectedItems;
            int len = items.Count;
            FileInfo[] infos = new FileInfo[len];
            for( int i = 0; i < len; ++i ) 
            {
                infos[i] = items[i].Tag as FileInfo;
            }
            Threading.OrgProgressThread thread = new Threading.OrgProgressThread( 
                infos, 
                cmbFormat.Text, 
                txtPath.Text, 
                ckCopy.Checked, 
                ckOverwrite.Checked );
            thread.Finished += new EventHandler<EventArgs>(thread_Finished);
            thread.Start();
           
        }

        void thread_Finished(object sender, EventArgs e)
        {
            SafeClose();
        }

        /// <summary>
        /// 
        /// </summary>
        public void SafeClose()
        {
            SafeClose(this, EventArgs.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SafeClose(object sender, EventArgs args)
        {
            if (InvokeRequired)
            {
                this.Invoke(
                    new EventHandler(SafeClose), sender, args);
                return;
            }

            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbV2_CheckedChanged( object sender, EventArgs e )
        {
            rbV1.Checked = !rbV2.Checked;   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbV1_CheckedChanged( object sender, EventArgs e )
        {
            rbV2.Checked = !rbV1.Checked;
        }
    }
}