using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger
{
    public partial class EditTagFrm : Form
    {
        protected bool multi_edit = false;
        protected ListView lv = null;
        private EditMainCtrl main = new EditMainCtrl();
        //private EditV2_DetailCtrl details = new EditV2_DetailCtrl();
        //private EditV2_OriginalCtrl original = new EditV2_OriginalCtrl();
        //private EditV2_LyricCtrl lyrics = new EditV2_LyricCtrl();
        //private EditV2_WebCtrl web = new EditV2_WebCtrl();
        //private EditV2_PictureCtrl pictures = new EditV2_PictureCtrl();
        //private EditV2_PeopleCtrl people = new EditV2_PeopleCtrl();
        ////private EditV2_UserDefinedCtrl user = new EditV2_UserDefinedCtrl();
        //private EditV2_RatingCtrl rating = new EditV2_RatingCtrl();
        private Control current = null;
        
        /// <summary>
        ///  default ctor
        /// </summary>
        public EditTagFrm()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multi_edit"></param>
        public EditTagFrm( ListView lv)  : this( lv, false )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditTagFrm( ListView lv, bool multi_edit ) 
        {
            InitializeComponent();

            this.lv = lv;
            this.multi_edit = multi_edit;

            if(multi_edit)
            {
                this.Text = "Edit Multi";
                taskNext.Enabled = false;
                taskPrevious.Enabled = false;
            }
            else
            {
                TagListViewItem item = (TagListViewItem)lv.Items[0];
                this.Text = String.Format( "{0}.{1}", "Edit Single", "Version 0" );
            }

            this.panel1.Controls.Add(main);
            main.Initialize(lv, multi_edit);
            main.Location = this.panel1.Location;
            main.Dock = DockStyle.Fill;
            main.Show();
            //this.panel1.Controls.Add( details );
            //details.Location = this.panel1.Location;
            //details.Dock = DockStyle.Fill;
            //details.Initialize( lv, multi_edit );
            //details.Hide();
            //this.panel1.Controls.Add( lyrics );
            //lyrics.Location = this.panel1.Location;
            //lyrics.Dock = DockStyle.Fill;
            //lyrics.Initialize( lv, multi_edit );
            //lyrics.Hide();
            //this.panel1.Controls.Add( pictures );
            //pictures.Location = this.panel1.Location;
            //pictures.Dock = DockStyle.Fill;
            //pictures.Initialize( lv, multi_edit );
            //pictures.Hide();
            //this.panel1.Controls.Add( web );
            //web.Location = this.panel1.Location;
            //web.Dock = DockStyle.Fill;
            //web.Initialize( lv, multi_edit );
            //web.Hide();
            //this.panel1.Controls.Add( original );
            //original.Location = this.panel1.Location;
            //original.Dock = DockStyle.Fill;
            //original.Initialize( lv, multi_edit );
            //original.Hide();
            //this.panel1.Controls.Add( people );
            //people.Location = this.panel1.Location;
            //people.Dock = DockStyle.Fill;
            //people.Initialize( lv, multi_edit );
            //people.Hide();
            //this.panel1.Controls.Add( user );
            //user.Location = this.panel1.Location;
            //user.Dock = DockStyle.Fill;
            //user.Initialize( lv, multi_edit );
            //user.Hide();
            //this.panel1.Controls.Add( rating );
            //rating.Location = this.panel1.Location;
            //rating.Dock = DockStyle.Fill;
            //rating.Initialize( lv, multi_edit );
            //rating.Hide();
            //current = main;
        }
        TagListViewItem Item
        {
            get
            {
                //return lv.SelectedItems[main.Index] as TagListViewItem;
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskMain_Click( object sender, EventArgs e )
        {
            if (current != main)
            {
                current.Hide();
                main.Show();
                current = main;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskDetails_Click( object sender, EventArgs e )
        {
            //if(current != details)
            //{
            //    current.Hide();
            //    details.Show();
            //    current = details;
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskLyrics_Click( object sender, EventArgs e )
        {
            //if(current != lyrics)
            //{
            //    current.Hide();
            //    lyrics.Show();
            //    current = lyrics;
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPicture_Click( object sender, EventArgs e )
        {
            //if(current != pictures)
            //{
            //    current.Hide();
            //    pictures.Show();
            //    current = pictures;
            //}          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskWeb_Click( object sender, EventArgs e )
        {
            //if(current != web)
            //{
            //    current.Hide();
            //    web.Show();
            //    current = web;
            //}     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskOriginal_Click( object sender, EventArgs e )
        {
            //if(current != original)
            //{
            //    current.Hide();
            //    original.Show();
            //    current = original;
            //}     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPeople_Click( object sender, EventArgs e )
        {
            //if(current != people)
            //{
            //    current.Hide();
            //    people.Show();
            //    current = people;
            //}     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskUserDefined_Click( object sender, EventArgs e )
        {
            //if(current != user)
            //{
            //    current.Hide();
            //    user.Show();
            //    current = user;
            //}
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskRating_Click( object sender, EventArgs e )
        {
            //if(current != rating)
            //{
            //    current.Hide();
            //    rating.Show();
            //    current = rating;
            //}     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            ApplyChanges();
            Close();
        }
        private void ApplyChanges()
        {
            if (this.multi_edit)
            {
                foreach (ListViewItem item in lv.SelectedItems)
                {
                    EditItem((TagListViewItem)item);
                }
            }
            else
            {
                EditItem((TagListViewItem)lv.SelectedItems[main.Index]);
            }
        }
        /// <summary>
        ///  edit a item
        /// </summary>
        /// <param name="item"></param>
        protected void EditItem( TagListViewItem item )
        {
            item.BackColor = Color.Yellow;
            main.EditItem( item );
            //details.EditItem( item );
            //original.EditItem( item );
            //people.EditItem( item );
            //web.EditItem( item );
            //rating.EditItem( item );
            //pictures.EditItem( item );
            item.RefreshItem();
        }
               
        /// <summary>
        /// swap the artist & title
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapArtist_Title_Click(object sender, EventArgs e)
        {
            string org_title = main.txtTitle.Text;
            main.txtTitle.Text = main.txtArtists.Text;
            main.txtArtists.Text = org_title;
        }
        /// <summary>
        /// swap artist & album
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapArtist_Album_Click(object sender, EventArgs e)
        {
            string org_album = main.txtAlbum.Text;
            main.txtAlbum.Text = main.txtArtists.Text;
            main.txtArtists.Text = org_album;
        }
        /// <summary>
        ///  swap title & album
        /// </summary>
        /// <param name="sender">task item</param>
        /// <param name="e">args</param>
        private void taskSwapTitle_Album_Click(object sender, EventArgs e)
        {
            string org_album = main.txtAlbum.Text;
            main.txtAlbum.Text = main.txtTitle.Text;
            main.txtTitle.Text = org_album;
        }

        private void taskPrevious_Click(object sender, EventArgs e)
        {
            if (Item.Dirty == false)
            {
                DialogResult result = MessageBox.Show("Do you want to apply any chnages to current item?",
                                                        "Apply Chnages?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ApplyChanges();
                }
            }


            main.Previous();
            //details.Previous();
            //original.Previous();
            //lyrics.Previous();
            //web.Previous();
            //pictures.Previous();
            //people.Previous();
            ////user.Previous();
            //rating.Previous();
        }

        private void taskNext_Click(object sender, EventArgs e)
        {

            if (Item.Dirty == false)
            {
                DialogResult result = MessageBox.Show("Do you want to apply any chnages to current item?",
                                                        "Apply Chnages?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ApplyChanges();
                }
            }

            main.Next();
            //details.Next();
            //original.Next();
            //lyrics.Next();
            //web.Next();
            //pictures.Next();
            //people.Next();
            ////user.Next();
            //rating.Next();
        }
    }
}