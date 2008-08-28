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
            foreach(TagLib.Id3v2.UnknownFrame frame in
               ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WCOP" ))
            {
                txtCopyrightURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
              ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WOAF" ))
            {
                txtFileURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
             ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WOAR" ))
            {
                txtArtistURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
             ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WOAS" ))
            {
                txtAudioSourceURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
             ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WORS" ))
            {
                txtRadioStationURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
             ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WPAY" ))
            {
                txtPaymentURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
            ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WPUB" ))
            {
                txtPublisherURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
            foreach(TagLib.Id3v2.UnknownFrame frame in
            ( (TagLib.Id3v2.Tag)v2 ).GetFrames<TagLib.Id3v2.UnknownFrame>( "WCOM" ))
            {
                txtCommercialURL.Text = frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                break;
            }
        }   
    }
}
