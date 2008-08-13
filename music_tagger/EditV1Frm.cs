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
    public partial class EditV1Frm : Form
    {
        protected ListView lv = null;
        /// <summary>
        /// 
        /// </summary>
        public EditV1Frm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditV1Frm(ListView lv) 
        {
            InitializeComponent();
            editCtrl.Initialize( lv );
            Initialize();                                                               
        }

        public virtual void Initialize()
        {
            this.editCtrl.lblFile.Visible = true;
            this.editCtrl.lblFileTag.Visible = true;
        }
   }
}