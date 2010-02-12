using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger
{
    public partial class EditListFrm : Form
    {
        string[] strs = null;

        public string[] Strs
        {
            get { return strs; }
         }

        public EditListFrm(string[] strs)
        {
            InitializeComponent();
            editListCtrl.Initilaize( strs );
        }

        private void EditListFrm_FormClosing( object sender, FormClosingEventArgs e )
        {
            if( editListCtrl.cmb.Items.Count > 0 )
            {
                strs = new string[editListCtrl.cmb.Items.Count];
                editListCtrl.cmb.Items.CopyTo( strs, 0 );
            }
        }
    }
}