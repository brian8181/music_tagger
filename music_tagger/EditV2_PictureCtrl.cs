using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_PictureCtrl : UserControl
    {
        private TagLib.File tag_file = null;
        private TagLib.Tag v1;
        private TagLib.Tag v2;
        private ListView lv = null;
        private int idx = -1;
        public EditV2_PictureCtrl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize( ListView lv )
        {
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
                //Fill( idx );
            }
        }
    }
}
