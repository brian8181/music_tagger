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
    public partial class OrganizeFrm : Form
    {
        private ListView lv = null;
        private int idx = -1;
        private Thread thread = null; 

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
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
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
            cmbFormat.SelectedIndex = 0;
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
            
            //thread = new Thread( new ParameterizedThreadStart( OrganizeThread ) );
            //thread.IsBackground = true;
            //thread.Priority = ThreadPriority.BelowNormal;
            //thread.Start( infos );

            OrgProgressThread thread = new OrgProgressThread( 
                infos, 
                cmbFormat.Text, 
                txtPath.Text, 
                ckCopy.Checked, 
                ckOverwrite.Checked );
            thread.Start();
        }
        
        public class OrgThread
        {

        }

        //private void OrganizeThread(object obj)
        //{
        //    FileInfo[] infos = obj as FileInfo[];
        //    //OrgProgressFrm dlg = new OrgProgressFrm();
            
        //    // no reason to show for short operations
        //    if(infos.Length > 2)
        //    {
        //        //dlg.Show( this );
        //    }
            
        //    foreach(FileInfo fi in infos)
        //    {
        //        TagLib.File tag_file = TagLib.File.Create( fi.FullName );
        //        TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
        //        //dlg.progressCtrl.UpdateStatus( fi.FullName );
        //        FormatEvaluator eval = new FormatEvaluator( cmbFormat.Text, id3v1 );
        //        string dir = String.Format( "{0}\\{1}",
        //            txtPath.Text.TrimEnd( '\\' ), eval.Value.TrimStart( '\\' ) );
        //        if(!Directory.Exists( dir ))
        //        {
        //            Directory.CreateDirectory( dir );
        //        }
        //        if(ckCopy.Checked)
        //        {
        //            fi.CopyTo( dir + "\\" + fi.Name, ckOverwrite.Checked );
        //        }
        //        else
        //        {
        //            Tools.Functions.MoveTo( fi, dir.TrimEnd( '\\' ) + fi.Name, ckOverwrite.Checked );
        //        }
        //    }
        //    //dlg.Close();
        //    //Close();
        //}

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