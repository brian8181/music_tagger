using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_LyricCtrl : ViewCtrlBase
    {
        public EditV2_LyricCtrl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill( TagLib.Tag tag )
        {
            txtLyrics.Text = tag.Lyrics;
        }
    }
}
