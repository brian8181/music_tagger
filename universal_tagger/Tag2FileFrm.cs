using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace universal_tagger
{
    public partial class Tag2FileFrm : Form
    {
        protected bool multi_edit = false;
        protected ListView lv = null;

        View view = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public Tag2FileFrm( View view )
        {
            InitializeComponent();

            //this.lv = lv;
            //this.multi_edit = multi_edit;

            this.view = view;
            InitializeComponent();
            Initialize();
        }
        /// <summary>
        /// 
        /// </summary>
        public void Initialize()
        {
           
            //string[] fmts = new string[Properties.Settings.Default.tagv22file_formats.Count];
            //Properties.Settings.Default.tagv22file_formats.CopyTo( fmts, 0 );
            //cmbFormat.Items.AddRange( fmts );
            //cmbFormat.SelectedIndex = cmbFormat.FindStringExact( Properties.Settings.Default.tagv22file_last_format );
        }
        /// <summary>
        /// 
        /// </summary>
        public void SaveSettings()
        {
            // formats
            string[] fmts = new string[cmbFormat.Items.Count];
            cmbFormat.Items.CopyTo( fmts, 0 );
            //Properties.Settings.Default.tagv22file_formats.Clear();
            //Properties.Settings.Default.tagv22file_formats.AddRange( fmts );
            //Properties.Settings.Default.tagv22file_last_format = cmbFormat.Text;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            if(String.IsNullOrEmpty( cmbFormat.Text ))
            {
                MessageBox.Show(
                    "Please eneter a valid format and path.",
                    "Invalid",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk );
                return;
            }
            ListView.SelectedListViewItemCollection items = lv.SelectedItems;
            int len = items.Count;
            FileInfo[] infos = new FileInfo[len];
            for(int i = 0; i < len; ++i)
            {
                infos[i] = items[i].Tag as FileInfo;
            }
            SaveSettings();
            //Threading.TagV22FileProgressThread thread = new Threading.TagV22FileProgressThread(
            //    infos,
            //    cmbFormat.Text );
            //thread.StatusUpdate += new EventHandler<Threading.ProgressThread.StatusArgs>( thread_StatusUpdate );
            //thread.Finished += new EventHandler<EventArgs>( thread_Finished );
            //thread.ShowDialog();
            //thread.Start();
        }
        /// <summary>
        /// status update handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //void thread_StatusUpdate( object sender, Threading.ProgressThread.StatusArgs e )
        //{
        //    if(InvokeRequired)
        //    {
        //        this.Invoke(
        //            new EventHandler<Threading.ProgressThread.StatusArgs>( thread_StatusUpdate ), sender, e );
        //        return;
        //    }
        //    if(e.Status == "Finished")
        //    {
        //        btnCancel.Text = "Done";
        //        view.RefreshView();
        //    }
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void thread_Finished( object sender, EventArgs e )
        {
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click( object sender, EventArgs e )
        {
            Close();
        }
        /// <summary>
        /// save format to list
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
        /// remove format from list
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
    }
}