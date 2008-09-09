using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class TransferFrm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private ListView lv = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public TransferFrm( ListView lv ) 
        {
            InitializeComponent();
            this.lv = lv;
            Initialize();
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            foreach(TagListViewItem item in lv.SelectedItems)
            {
                if(rbTarnsferV1V2.Checked)
                {
                    Transfer( item.Id3v1, item.Id3v2 );
                }
                else
                {
                    Transfer( item.Id3v2, item.Id3v1 );
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dest"></param>
        private void Transfer( TagLib.Tag src, TagLib.Tag dest )
        {
            if(ckAlbum.Checked)
            {
            }
            if(ckArtist.Checked)
            {
            }
            if(ckComment.Checked)
            {
            }
            if(ckGenre.Checked)
            {
            }
            if(ckTitle.Checked)
            {
            }
            if(ckTrack.Checked)
            {
            }
            if(ckYear.Checked)
            {
            }
        }
   }
}