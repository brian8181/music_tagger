using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger
{
    public partial class EditListCtrl : UserControl
    {
        /// <summary>
        /// constuctor 
        /// </summary>
        public EditListCtrl()
        {
            InitializeComponent();
 
        }
        /// <summary>
        ///  staring value
        /// </summary>
        /// <param name="str"></param>
        public void Initilaize( string[] str )
        {
            foreach(string s in str)
            {
                cmb.Items.Add( s );
            }

            if(cmb.Items.Count > 0)
                cmb.SelectedIndex = 0;
        }
        /// <summary>
        ///  Button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnAdd_Click( object sender, EventArgs e )
        {
            if(!cmb.Items.Contains( cmb.Text ))
            {
                cmb.Items.Add( cmb.Text );
            }
        }
        /// <summary>
        ///  Button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnRemove_Click( object sender, EventArgs e )
        {
            if(cmb.SelectedItem != null)
            {
                cmb.Items.Remove( cmb.SelectedItem );
            }
        }
        /// <summary>
        ///  Button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnUp_Click( object sender, EventArgs e )
        {
            int idx = cmb.SelectedIndex;
            if(idx > 0)
            {
                string s = cmb.SelectedItem.ToString();
                cmb.Items.RemoveAt( idx );
                cmb.Items.Insert( --idx, s );
                cmb.SelectedIndex = idx;
            }
        }
        /// <summary>
        ///  Button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnDown_Click( object sender, EventArgs e )
        {
            int idx = cmb.SelectedIndex;
            if(idx >= 0 && idx < cmb.Items.Count - 1)
            {
                string s = cmb.SelectedItem.ToString();
                cmb.Items.RemoveAt( idx );
                cmb.Items.Insert( ++idx, s );
                cmb.SelectedIndex = idx;
            }
        }
    }
}
