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
        private bool ratings_dirty = false;
       
        public EditV2_RatingCtrl()
        {
            InitializeComponent();

            if(!multi_edit)
            {
                ckComment.Hide();
            }
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

            // just select first item
            if(ratingList.Items.Count > 0)
            {
                SetSelectedRating( ratingList.Items[0] );
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
                UpdateCommentFrames( item );
            }
        }
        /// <summary>
        /// set selected rating 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedRating( ListViewItem item )
        {
            txtEmail.Text = item.Text;
            udRating.Value = int.Parse( item.SubItems[1].Text );
            udCounter.Value = int.Parse( item.SubItems[2].Text );
        }
        /// <summary>
        /// Update the comment frame 
        /// </summary>
        private void UpdateCommentFrames( TagListViewItem item )
        {
            if(ratings_dirty)
            {
                item.Id3v2.RemoveFrames( "POPM" );
                foreach(ListViewItem i in ratingList.Items)
                {
                    string user = i.Text;
                    string rating = i.SubItems[1].Text;
                    string count = i.SubItems[2].Text;
                    PopularimeterFrame f = new PopularimeterFrame( user );
                    f.Rating = byte.Parse( rating );
                    f.PlayCount = ulong.Parse(count);
                    item.Id3v2.AddFrame( f );
                }
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
            ratings_dirty = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTopComment_Click( object sender, EventArgs e )
        {
            ratings_dirty = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveComment_Click( object sender, EventArgs e )
        {
            ratings_dirty = true;
        }
    }
}
