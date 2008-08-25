using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class MultiSelectComboBox : ComboBox
    {
        string value = string.Empty;
        public MultiSelectComboBox()
        {
            InitializeComponent();
            Text = "hdsvchysavuvbeaiu  bmfgvijb";
        }

        protected override void OnPaint( PaintEventArgs pe )
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint( pe );
        }
        //protected override void OnTextChanged( EventArgs e )
        //{
        //    base.OnTextChanged( e );
        //    // check for recursion
        //    if(value != string.Empty)
        //    {
        //        string tmp_val = value;
        //        value = string.Empty;
        //        SelectedIndex = -1;
        //        Text = string.Format( "{0}; {1}", tmp_val, Text );
        //    }
        //}
        //protected override void OnSelectionChangeCommitted( EventArgs e )
        //{
        //    base.OnSelectionChangeCommitted( e );
        //    value = Text;
        //}
    }
}

