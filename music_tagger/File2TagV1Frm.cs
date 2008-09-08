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
    public partial class File2TagV1Frm : EditFrm
    {
        
        public File2TagV1Frm()  
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public File2TagV1Frm( ListView lv ) : base(lv)
        {
            InitializeComponent();
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

            Threading.File2TagProgressThread thread = new Threading.File2TagProgressThread(
                infos,
                cmbFormat.Text );
            thread.Start();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {

        }

        private void btnAdd_Click( object sender, EventArgs e )
        {

        }

        private void btnRemove_Click( object sender, EventArgs e )
        {

        }
    }
}