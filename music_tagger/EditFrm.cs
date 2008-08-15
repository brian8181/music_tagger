using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public class EditFrm  : Form
    {
        protected ListView lv = null;

        /// <summary>
        /// 
        /// </summary>
        public EditFrm() { }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="lv"></param>
        public EditFrm(ListView lv) 
        {
            this.lv = lv;
        }

        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize()
        {
            //if(lv.SelectedItems.Count > 0)
            //{
            //    idx = 0;
            //}

            //string[] fmts = new string[Properties.Settings.Default.org_formats.Count];
            //Properties.Settings.Default.org_formats.CopyTo( fmts, 0 );
            //cmbFormat.Items.AddRange( fmts );
            //cmbFormat.SelectedIndex = 0;
        }
    }

    public class FormatFrm : EditFrm
    {
        ComboBox cmbFormat = new ComboBox();
        Button btnAdd = new Button();
        Button btnRemove = new Button();
        Button btnOK = new Button();
        Button btnCancel = new Button();


    }
}
