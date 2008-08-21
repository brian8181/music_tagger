using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public class EditFrm  : Form
    {
        protected bool multi_edit = false;
        protected ListView lv = null;

        /// <summary>
        ///  default ctor
        /// </summary>
        public EditFrm()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multi_edit"></param>
        public EditFrm( ListView lv)  : this( lv, false )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditFrm(ListView lv, bool multi_edit) 
        {
            this.lv = lv;
            this.multi_edit = multi_edit;
        }

        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Coalesce()
        {
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
