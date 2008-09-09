using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public partial class EditV2_LyricCtrl : EditCtrlBase
    {
        /// <summary>
        /// constructor
        /// </summary>
        public EditV2_LyricCtrl()
        {
            InitializeComponent();

            string[] lines = Properties.Resources.ISO_639_2.Split( '\n' );
            this.cmbLanguage.Items.Add( new ISO_639_2( "xxx", "Default" ) );
            //alpha-3 (bibliographic) code|an alpha-3 (terminologic)|English name|French name
            foreach(string line in lines)
            {
                string[] split = line.Split( '|' );
                this.cmbLanguage.Items.Add( new ISO_639_2( split[0], split[3] ) );
            }
            this.cmbLanguage.SelectedIndex = 0;
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            if(v2 != null)
            {
                if(multi_edit)
                {
                    Coalesce();
                }

                txtLyrics.Text = v2.Lyrics;
                 
                foreach(TagLib.Id3v2.UnsynchronisedLyricsFrame frame in ( (TagLib.Id3v2.Tag)v2 ).GetFrames( "USLT" ))
                {
                    ListViewItem item =
                         lyricsList.Items.Add( frame.Description );
                    item.SubItems.Add( frame.Text );
                    item.SubItems.Add( frame.Language );
                    item.SubItems.Add( frame.TextEncoding.ToString() );
                }
                // just select first item
                if(lyricsList.Items.Count > 0)
                {
                    SetSelectedLyrics( lyricsList.Items[0] );
                }
            }
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            // call base first
            base.EditItem( item );
  
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {

            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File first_tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Id3v2.Tag first_tag = tag_file.GetTag( TagLib.TagTypes.Id3v2 ) as TagLib.Id3v2.Tag;
            TagV2Ext first_tag_ext = new TagV2Ext( first_tag );

            foreach(ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                first_tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                TagV2Ext tag_ext = new TagV2Ext( first_tag );

                if(tag != null)
                {

                }
            }
            v2 = first_tag; 
        }
        /// <summary>
        /// set selected comment 
        /// </summary>
        /// <param name="item">the item</param>
        private void SetSelectedLyrics( ListViewItem item )
        {
            txtDescriptor.Text = item.Text;
            txtLyrics.Text = item.SubItems[1].Text;
            string lang = item.SubItems[2].Text;
            cmbLanguage.SelectedIndex = cmbLanguage.FindString( lang.ToLower() ); ;
        }

        private void btnAdd_Click( object sender, EventArgs e )
        {

        }
    }
}
