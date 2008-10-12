using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class EditV1Frm : EditFrm
    {
        /// <summary>
        ///  default contructor ( for designer )
        /// </summary>
        public EditV1Frm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// contructor 
        /// </summary>
        /// <param name="lv"></param>
        public EditV1Frm( ListView lv )
            : this( lv, false )
        {
        }
        /// <summary>
        /// contructor 
        /// </summary>
        /// <param name="lv"></param>
        public EditV1Frm( ListView lv, bool multi_edit )
            : base( lv, multi_edit )
        {
            InitializeComponent();
            editCtrl.Initialize( lv, multi_edit );
            Initialize();
        }
        /// <summary>
        /// intialize
        /// </summary>
        public override void Initialize()
        {
            if(multi_edit)
            {
                this.editCtrl.ckAlbum.Visible = true;
                this.editCtrl.ckAlbum.Checked = false;
                this.editCtrl.ckArtist.Visible = true;
                this.editCtrl.ckArtist.Checked = false;
                this.editCtrl.ckComment.Visible = true;
                this.editCtrl.ckComment.Checked = false;
                this.editCtrl.ckGenre.Visible = true;
                this.editCtrl.ckGenre.Checked = false;
                this.editCtrl.ckTitle.Visible = true;
                this.editCtrl.ckTitle.Checked = false;
                this.editCtrl.ckTrack.Visible = true;
                this.editCtrl.ckTrack.Checked = false;
                this.editCtrl.ckYear.Visible = true;
                this.editCtrl.ckYear.Checked = false;
            }
            else
            {
                this.editCtrl.lblFile.Visible = true;
                this.editCtrl.lblFileTag.Visible = true;
            }
        }
        /// <summary>
        /// button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            if(this.multi_edit)
            {
                foreach(ListViewItem item in lv.SelectedItems)
                {
                    this.editCtrl.EditItem( (TagListViewItem)item );
                }
            }
            else
            {
                this.editCtrl.EditItem( (TagListViewItem)lv.SelectedItems[0] );
            }
            Close();
        }
    }
}