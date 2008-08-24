using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_DetailCtrl : EditV2CtrlBase
    {
        public EditV2_DetailCtrl()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill( TagLib.Tag tag )
        {
            TagLib.Id3v2.TextInformationFrame frame = 
                TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)tag, "TPE2", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtBand.Text = frame.Text[0];
                frame = null;
            }
           
            txtConductor.Text = tag.Conductor;
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)tag, "TPE4", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtRemixed.Text = frame.Text[0];
                frame = null;
            }
            txtComposer.Text = v2.FirstComposer;
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)tag, "TEXT", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtWriter.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)tag, "TPUB", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtPublisher.Text = frame.Text[0];
                frame = null;
            }
            txtCopyright.Text = v2.Copyright;
            txtContentGroup.Text = v2.Grouping;
            // todo split 
            cmbMediaType.Text = tag_file.Properties.MediaTypes.ToString();
            txtTrackLength.Text = tag_file.Properties.Duration.ToString();
        }
    }
}
                                                                    