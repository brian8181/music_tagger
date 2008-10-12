using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class File2TagV2Frm : EditFrm
    {

        View view = null;
        public File2TagV2Frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public File2TagV2Frm( View view )
            : base( view.ListView )
        {
            InitializeComponent();

            this.view = view;
            string[] fmts = new string[Properties.Settings.Default.file2tagv2_formats.Count];
            Properties.Settings.Default.file2tagv2_formats.CopyTo( fmts, 0 );
            cmbFormat.Items.AddRange( fmts );
            cmbFormat.SelectedIndex = cmbFormat.FindStringExact( Properties.Settings.Default.file2tagv2_last_format );
        }

        ///// <summary>
        ///// intialize listview  
        ///// </summary>
        ///// <param name="lv"></param>
        //public virtual void Initialize()
        //{
        //    if(lv.SelectedItems.Count > 0)
        //    {
        //        idx = 0;
        //    }

        //    //string[] fmts = new string[Properties.Settings.Default.org_formats.Count];
        //    //Properties.Settings.Default.org_formats.CopyTo( fmts, 0 );
        //    //cmbFormat.Items.AddRange( fmts );
        //    //cmbFormat.SelectedIndex = 0;
        //}

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

            //Threading.File2TagProgressThread thread = new Threading.File2TagProgressThread(
            //    infos,
            //    cmbFormat.Text );
            //thread.Start();


            foreach(FileInfo fi in infos)
            {
                TagLib.File tag_file = TagLib.File.Create( fi.FullName );
                File2TagFormatEvaluator eval = new File2TagFormatEvaluator( cmbFormat.Text, tag_file );
                tag_file.Save();
            }
            view.RefreshView();
            Close();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void SaveSettings()
        {
            // formats
            string[] fmts = new string[cmbFormat.Items.Count];
            cmbFormat.Items.CopyTo( fmts, 0 );
            Properties.Settings.Default.file2tagv1_formats.Clear();
            Properties.Settings.Default.file2tagv1_formats.AddRange( fmts );
            Properties.Settings.Default.file2tagv1_last_format = cmbFormat.Text;
            Properties.Settings.Default.Save();
        }
        private void btnAdd_Click( object sender, EventArgs e )
        {
            if(!cmbFormat.Items.Contains( cmbFormat.Text ))
            {
                cmbFormat.Items.Add( cmbFormat.Text );
            }
            SaveSettings();
        }

        private void btnRemove_Click( object sender, EventArgs e )
        {
            cmbFormat.Items.Remove( cmbFormat.SelectedItem );
        }
    }
}