    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_WebCtrl : EditCtrlBase
    {
        public EditV2_WebCtrl()
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
            txtCopyrightURL.Text = tag.WCOP;
            txtFileURL.Text = tag.WOAF;
            txtArtistURL.Text = tag.WOAR;
            txtAudioSourceURL.Text = tag.WOAS;
            txtRadioStationURL.Text = tag.WORS;
            txtPaymentURL.Text = tag.WPAY;
            txtPublisherURL.Text = tag.WPUB;
            txtCommercialURL.Text = tag.WCOM;
        }   
    }
}
