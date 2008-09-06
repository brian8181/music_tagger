using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using TagLib.Id3v2;

namespace music_tagger
{
    public partial class EditV2_RatingCtrl : EditCtrlBase
    {
        public EditV2_RatingCtrl()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            foreach(PopularimeterFrame frame in v2.GetFrames<PopularimeterFrame>())
            {
                ListViewItem item = new ListViewItem( frame.User );
                item.SubItems.Add( frame.Rating.ToString() );
                item.SubItems.Add( frame.PlayCount.ToString());
                ratingList.Items.Add( item );    
            }
           
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
        }
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            // call base first
            base.EditItem( item );


            if(item.Id3v2 != null)
            {
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click( object sender, EventArgs e )
        {

            ListViewItem item = new ListViewItem( txtEmail.Text );
            item.SubItems.Add( udRating.Value.ToString() );
            item.SubItems.Add( udCounter.Value.ToString() );
            ratingList.Items.Add( item );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTopComment_Click( object sender, EventArgs e )
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveComment_Click( object sender, EventArgs e )
        {

        }
    }
}
