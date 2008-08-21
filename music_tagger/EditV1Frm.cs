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
        public EditV1Frm(ListView lv) : base(lv) 
        {
            InitializeComponent();
            editCtrl.Initialize( lv );
            Initialize();                                                               
        }
        /// <summary>
        /// intialize
        /// </summary>
        public override void Initialize()
        {
            this.editCtrl.lblFile.Visible = true;
            this.editCtrl.lblFileTag.Visible = true;
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
                    EditItem( (TagListViewItem)item );
                }
            }
            else
            {
                EditItem( (TagListViewItem)lv.SelectedItems[0] );
            }
            Close();
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        protected override void EditItem( TagListViewItem item )
        {
            item.BackColor = Color.Yellow;
            // Performers
            if(!String.IsNullOrEmpty( editCtrl.cmbArtist.Text ))
            {
                item.Id3v2.Performers = new string[1] { editCtrl.cmbArtist.Text };
            }
            item.Id3v1.Album = this.editCtrl.txtAlbum.Text;
            item.Id3v1.Title = this.editCtrl.txtTitle.Text;
            uint num = 0;
            item.Id3v1.Year = uint.TryParse( this.editCtrl.txtYear.Text, out num ) ? num : 0;
            item.Id3v1.Track = uint.TryParse( this.editCtrl.txtTrack.Text, out num ) ? num : 0;
            // Genres
            if(!String.IsNullOrEmpty( editCtrl.cmbGenre.Text ))
            {
                item.Id3v1.Performers = new string[1] { editCtrl.cmbGenre.Text };
            }
            item.Id3v1.Comment = this.editCtrl.txtComment.Text;
            item.RefreshItem();
        }
        /// <summary>
        /// button click handler
        /// </summary>
        /// <param name="sender">the button</param>
        /// <param name="e">args</param>
        private void btnCancel_Click( object sender, EventArgs e )
        {
        }
   }
}