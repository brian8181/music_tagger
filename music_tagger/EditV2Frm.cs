using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class EditV2Frm : EditFrm
    {
        private EditV2_MainCtrl main = new EditV2_MainCtrl();
        private EditV2_DetailCtrl details = new EditV2_DetailCtrl();
        private EditV2_OriginalCtrl original = new EditV2_OriginalCtrl();
        private EditV2_LyricCtrl lyrics = new EditV2_LyricCtrl();
        private EditV2_WebCtrl web = new EditV2_WebCtrl();
        private EditV2_PictureCtrl pictures = new EditV2_PictureCtrl();
        private EditV2_PeopleCtrl people = new EditV2_PeopleCtrl();
        //private EditV2_UserDefinedCtrl user = new EditV2_UserDefinedCtrl();
        private EditV2_RatingCtrl rating = new EditV2_RatingCtrl();
        private Control current = null;
        
        /// <summary>
        ///  default ctor
        /// </summary>
        public EditV2Frm()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multi_edit"></param>
        public EditV2Frm( ListView lv)  : this( lv, false )
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        public EditV2Frm( ListView lv, bool multi_edit ) : base( lv, multi_edit )
        {
            InitializeComponent();

            if(multi_edit)
            {
                this.Text = Properties.Resources.editv2frm_multi;
            }
            else
            {
                TagListViewItem item = (TagListViewItem)lv.Items[0];
                this.Text = String.Format( "{0}.{1}",
                    Properties.Resources.editv2frm_single, item.Id3v2.Version );
            }

            this.panel1.Controls.Add( main );
            main.Initialize( lv, multi_edit );
            main.Location = this.panel1.Location;
            main.Dock = DockStyle.Fill;
            main.Show();
            this.panel1.Controls.Add( details );
            details.Location = this.panel1.Location;
            details.Dock = DockStyle.Fill;
            details.Initialize( lv, multi_edit );
            details.Hide();
            this.panel1.Controls.Add( lyrics );
            lyrics.Location = this.panel1.Location;
            lyrics.Dock = DockStyle.Fill;
            lyrics.Initialize( lv, multi_edit );
            lyrics.Hide();
            this.panel1.Controls.Add( pictures );
            pictures.Location = this.panel1.Location;
            pictures.Dock = DockStyle.Fill;
            pictures.Initialize( lv, multi_edit );
            pictures.Hide();
            this.panel1.Controls.Add( web );
            web.Location = this.panel1.Location;
            web.Dock = DockStyle.Fill;
            web.Initialize( lv, multi_edit );
            web.Hide();
            this.panel1.Controls.Add( original );
            original.Location = this.panel1.Location;
            original.Dock = DockStyle.Fill;
            original.Initialize( lv, multi_edit );
            original.Hide();
            this.panel1.Controls.Add( people );
            people.Location = this.panel1.Location;
            people.Dock = DockStyle.Fill;
            people.Initialize( lv, multi_edit );
            people.Hide();
            //this.panel1.Controls.Add( user );
            //user.Location = this.panel1.Location;
            //user.Dock = DockStyle.Fill;
            //user.Initialize( lv, multi_edit );
            //user.Hide();
            this.panel1.Controls.Add( rating );
            rating.Location = this.panel1.Location;
            rating.Dock = DockStyle.Fill;
            rating.Initialize( lv, multi_edit );
            rating.Hide();
            current = main;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskMain_Click( object sender, EventArgs e )
        {
            if(current != main)
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
            if(current != details)
            {
                current.Hide();
                details.Show();
                current = details;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskLyrics_Click( object sender, EventArgs e )
        {
            if(current != lyrics)
            {
                current.Hide();
                lyrics.Show();
                current = lyrics;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPicture_Click( object sender, EventArgs e )
        {
            if(current != pictures)
            {
                current.Hide();
                pictures.Show();
                current = pictures;
            }          
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskWeb_Click( object sender, EventArgs e )
        {
            if(current != web)
            {
                current.Hide();
                web.Show();
                current = web;
            }     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskOriginal_Click( object sender, EventArgs e )
        {
            if(current != original)
            {
                current.Hide();
                original.Show();
                current = original;
            }     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taskPeople_Click( object sender, EventArgs e )
        {
            if(current != people)
            {
                current.Hide();
                people.Show();
                current = people;
            }     
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
            if(current != rating)
            {
                current.Hide();
                rating.Show();
                current = rating;
            }     
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        ///  edit a item
        /// </summary>
        /// <param name="item"></param>
        protected override void EditItem( TagListViewItem item )
        {
            item.BackColor = Color.Yellow;
            main.EditItem( item );
            details.EditItem( item );
            original.EditItem( item );
            people.EditItem( item );
            web.EditItem( item );
            rating.EditItem( item );
            pictures.EditItem( item );
            item.RefreshItem();
        }
    }
}