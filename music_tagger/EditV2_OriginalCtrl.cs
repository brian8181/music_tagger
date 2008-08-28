using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_OriginalCtrl : EditCtrlBase
    {
        public EditV2_OriginalCtrl()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            TagExt tag = new TagExt( v2 );
            txtOrginalAlbum.Text = tag.TOAL;
            txtOrginalFileName.Text = tag.TOFN;
            txtOrginalLyricsWriter.Text = tag.TOLY;
            txtOriginalArtist.Text = tag.TOPE;
            //txtOriginalReleaseDate.Text = tag.TORY;
            txtOriginalReleaseDate.Text = tag.TDOR;
            txtOriginalOwner.Text = tag.TOWN;
    
        }
    }
}
