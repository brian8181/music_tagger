using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2_DetailCtrl : ViewCtrlBase
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
            //txtBand.Text = tag.JoinedPerformers;
            txtConductor.Text = tag.Conductor;
            //txtRemixed.Text = v2.JoinedComposers;
            txtComposer.Text = v2.FirstComposer;
            //txtWriter.Text = v2.JoinedComposers;
            txtPublisher.Text = v2.Copyright;
            txtCopyright.Text = v2.Copyright;
            txtContentGroup.Text = v2.Grouping;
            // todo split 
            cmbMediaType.Text = tag_file.Properties.MediaTypes.ToString();
            txtTrackLength.Text = tag_file.Properties.Duration.ToString();
        }
    }
}
                                                                    