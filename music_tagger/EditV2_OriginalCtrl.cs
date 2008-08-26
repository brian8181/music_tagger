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
            TagLib.Id3v2.TextInformationFrame frame =
               TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TOAL", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtOrginalAlbum.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TOFN", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtOrginalFileName.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TOLY", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtOrginalLyricsWriter.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TOPE", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtOriginalArtist.Text = frame.Text[0];
                frame = null;
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TORY", false );
            if(frame != null && frame.Text.Length > 0)
            {
                txtOriginalReleaseDate.Text = frame.Text[0];
                frame = null;
            }
            else
            {
                //hack try ... (2.4 version, TDOR Original release time)
                frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TDOR", false );
                if(frame != null && frame.Text.Length > 0)
                {
                    txtOriginalReleaseDate.Text = frame.Text[0];
                    frame = null;
                }
            }
            frame = TagLib.Id3v2.TextInformationFrame.Get( (TagLib.Id3v2.Tag)v2, "TOWN", false );
            if(frame != null && frame.Text.Length > 0)
            {
               txtOriginalOwner.Text = frame.Text[0];
                frame = null;
            }
        }
    }
}
