using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_DetailCtrl : EditCtrlBase
    {
        public EditV2_DetailCtrl()
        {
            InitializeComponent();
            TagLib.MediaTypes[] types = 
                (TagLib.MediaTypes[])Enum.GetValues( typeof(TagLib.MediaTypes) );
            foreach( TagLib.MediaTypes type in types )
            {
                cmbMediaType.Items.Add( type );
            }
        }

        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            TagLib.Id3v2.TextInformationFrame frame = 
                TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TPE2", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtBand.Text = frame.Text[0];
                frame = null;
            }
            txtConductor.Text = v2.Conductor;
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TPE4", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtRemixed.Text = frame.Text[0];
                frame = null;
            }
            txtComposer.Text = v2.FirstComposer;
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TEXT", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtWriter.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TPUB", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtPublisher.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TENC", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtEncoded.Text = frame.Text[0];
                frame = null;
            }
            txtCopyright.Text = v2.Copyright;
            txtContentGroup.Text = v2.Grouping;
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TIT3", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtSubTitle.Text = frame.Text[0];
                frame = null;
            }
            cmbMediaType.Text = tag_file.Properties.MediaTypes.ToString();
            txtTrackLength.Text = tag_file.Properties.Duration.ToString();
        }
    }
}
                                                                    