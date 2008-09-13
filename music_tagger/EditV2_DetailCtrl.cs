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
    public partial class EditV2_DetailCtrl : EditCtrlBase
    {
        public EditV2_DetailCtrl()
        {
            InitializeComponent();
            TagLib.MediaTypes[] types = 
                (TagLib.MediaTypes[])Enum.GetValues( typeof(TagLib.MediaTypes) );
            foreach( TagLib.MediaTypes type in types )
            {
                cmbMediaType.Items.Add( type );
            }
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
                TagV2Ext tag = new TagV2Ext( v2 );
                txtBand.Text = tag.TPE2;
                txtRemixed.Text = tag.TPE4;
                txtWriter.Text = tag.TEXT;
                txtPublisher.Text = tag.TPUB;
                txtEncoded.Text = tag.TENC;
                txtSubTitle.Text = tag.TIT3;
                cmbMediaType.Text = tag.TMED;
                if(!multi_edit)
                {
                    txtTrackLength.Text = tag.TLEN;
                }
                txtCopyright.Text = v2.Copyright;
                txtContentGroup.Text = v2.Grouping;
                txtConductor.Text = v2.Conductor;
                txtComposer.Text = v2.FirstComposer;
            }
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public override void Coalesce()
        {
            base.Coalesce();

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
                    if(first_tag_ext.TPE2 != tag_ext.TPE2)
                        first_tag_ext.TPE2 = string.Empty;
                    if(first_tag_ext.TPE4 != tag_ext.TPE4)
                        first_tag_ext.TPE4 = string.Empty;
                    if(first_tag_ext.TEXT != tag_ext.TEXT)
                        first_tag_ext.TEXT = string.Empty;
                    if(first_tag_ext.TPUB != tag_ext.TPUB)
                        first_tag_ext.TPUB = string.Empty;
                    if(first_tag_ext.TENC != tag_ext.TENC)
                        first_tag_ext.TENC = string.Empty;
                    if(first_tag_ext.TIT3 != tag_ext.TIT3)
                        first_tag_ext.TIT3 = string.Empty;
                    if(first_tag_ext.TMED != tag_ext.TMED)
                        first_tag_ext.TMED = string.Empty;
                    if(first_tag_ext.TLEN != tag_ext.TLEN)
                        first_tag_ext.TLEN = string.Empty;
                }
            }
            v2 = first_tag;    
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public override void EditItem( TagListViewItem item )
        {
            // call base first
            base.EditItem( item );

            if(v2 != null)
            {
                TagV2Ext tag = new TagV2Ext( item.Id3v2 );
                tag.TPE2 = txtBand.Text;
                tag.TPE4 = txtRemixed.Text;
                tag.TEXT = txtWriter.Text;
                tag.TPUB = txtPublisher.Text;
                tag.TENC = txtEncoded.Text;
                tag.TIT3 = txtSubTitle.Text;
                tag.TMED = cmbMediaType.Text;
                tag.TLEN = txtTrackLength.Text;
                item.Id3v2.Copyright = txtCopyright.Text;
                item.Id3v2.Grouping = txtContentGroup.Text;
                item.Id3v2.Conductor = txtConductor.Text;
                item.Id3v2.Composers = Functions.GetArray( this.txtComposer.Text ); ;
            }
        }
    }
}
                                                                    