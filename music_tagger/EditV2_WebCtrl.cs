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
    public partial class EditV2_WebCtrl : EditCtrlBase
    {
        public EditV2_WebCtrl()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public override void Fill()
        {
            TagV2Ext tag = new TagV2Ext( v2 );
            txtCopyrightURL.Text = tag.WCOP;
            txtFileURL.Text = tag.WOAF;
            txtArtistURL.Text = tag.WOAR;
            txtAudioSourceURL.Text = tag.WOAS;
            txtRadioStationURL.Text = tag.WORS;
            txtPaymentURL.Text = tag.WPAY;
            txtPublisherURL.Text = tag.WPUB;
            txtCommercialURL.Text = tag.WCOM;
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
                    if(first_tag_ext.WCOP != tag_ext.WCOP)
                        first_tag_ext.WCOP = string.Empty;
                    if(first_tag_ext.WOAF != tag_ext.WOAF)
                        first_tag_ext.WOAF = string.Empty;
                    if(first_tag_ext.WOAR != tag_ext.WOAR)
                        first_tag_ext.WOAR = string.Empty;
                    if(first_tag_ext.WOAS != tag_ext.WOAS)
                        first_tag_ext.WOAS = string.Empty;
                    if(first_tag_ext.WORS != tag_ext.WORS)
                        first_tag_ext.WORS = string.Empty;
                    if(first_tag_ext.WPAY != tag_ext.WPAY)
                        first_tag_ext.WPAY = string.Empty;
                    if(first_tag_ext.WPUB != tag_ext.WPUB)
                        first_tag_ext.WPUB = string.Empty;
                    if(first_tag_ext.WCOM != tag_ext.WCOM)
                        first_tag_ext.WCOM = string.Empty;
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
                TagV2Ext tag = new TagV2Ext( item.Id3v2 );
                if(!multi_edit ||ckCopyrightURL.Checked)
                    tag.WCOP = txtCopyrightURL.Text;
                if(!multi_edit || ckFileURL.Checked)
                    tag.WOAF = txtFileURL.Text;
                if(!multi_edit || ckArtistURL.Checked)
                    tag.WOAR = txtArtistURL.Text;
                if(!multi_edit || ckAudioSourceURL.Checked)
                    tag.WOAS = txtAudioSourceURL.Text;
                if(!multi_edit || ckRadioStationURL.Checked)
                    tag.WORS = txtRadioStationURL.Text;
                if(!multi_edit || ckPaymentURL.Checked)
                    tag.WPAY = txtPaymentURL.Text;
                if(!multi_edit || ckPublisherURL.Checked)
                    tag.WPUB = txtPublisherURL.Text;
                if(!multi_edit || ckCommercialURL.Checked)
                    tag.WCOM = txtCommercialURL.Text;
            }
        }
    }
}
