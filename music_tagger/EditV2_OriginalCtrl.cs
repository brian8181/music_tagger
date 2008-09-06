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
            TagExt tag = new TagExt( v2 );
            txtOrginalAlbum.Text = tag.TOAL;
            txtOrginalFileName.Text = tag.TOFN;
            txtOrginalLyricsWriter.Text = tag.TOLY;
            txtOriginalArtist.Text = tag.TOPE;
            txtOriginalReleaseDate.Text = tag.TORY;
            //txtOriginalReleaseDate.Text = tag.TDOR;
            txtOriginalOwner.Text = tag.TOWN;
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[0].Tag;
            TagLib.File first_tag_file = TagLib.File.Create( fi.FullName );
            TagLib.Id3v2.Tag first_tag = tag_file.GetTag( TagLib.TagTypes.Id3v2 ) as TagLib.Id3v2.Tag;
            TagExt first_tag_ext = new TagExt( first_tag );

            foreach(ListViewItem item in lv.SelectedItems)
            {
                fi = (FileInfo)item.Tag;
                first_tag_file = TagLib.File.Create( fi.FullName );
                TagLib.Tag tag = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
                TagExt tag_ext = new TagExt( first_tag );

                if(tag != null)
                {
                    if(first_tag_ext.TOAL != tag_ext.TOAL)
                        first_tag_ext.TOAL = string.Empty;
                    if(first_tag_ext.TOFN != tag_ext.TOFN)
                        first_tag_ext.TOFN = string.Empty;
                    if(first_tag_ext.TOLY != tag_ext.TOLY)
                        first_tag_ext.TOLY = string.Empty;
                    if(first_tag_ext.TOPE != tag_ext.TOPE)
                        first_tag_ext.TOPE = string.Empty;
                    if(first_tag_ext.TORY != tag_ext.TORY)
                        first_tag_ext.TORY = string.Empty;
                    if(first_tag_ext.TOWN != tag_ext.TOWN)
                        first_tag_ext.TOWN = string.Empty;
                 }
            }
            v2 = first_tag; 
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
                TagExt tag = new TagExt( item.Id3v2 );
                if(!multi_edit || ckOrginalAlbum.Checked)
                    tag.TOAL = txtOrginalAlbum.Text;
                if(!multi_edit || ckOrginalFileName.Checked)
                    tag.TOFN = txtOrginalFileName.Text;
                if(!multi_edit || ckOrginalLyricsWriter.Checked)
                    tag.TOLY = txtOrginalLyricsWriter.Text;
                if(!multi_edit || ckOriginalArtist.Checked)
                    tag.TOPE = txtOriginalArtist.Text;
                if(!multi_edit || ckOriginalReleaseDate.Checked)
                    tag.TORY = txtOriginalReleaseDate.Text;
                if(!multi_edit || ckOriginalOwner.Checked)
                    tag.TOWN = txtOriginalOwner.Text;
            }
        }

    }
}
