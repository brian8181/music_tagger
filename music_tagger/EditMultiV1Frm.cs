using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditMultiV1Frm : music_tagger.EditV1Frm
    {
        /// <summary>
        /// 
        /// </summary>
        public EditMultiV1Frm()
        {
            InitializeComponent();
        }

         /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditMultiV1Frm( ListView lv )
            : base( lv )
        {
            InitializeComponent();
        }
    }
}

