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
                TagExt tag = new TagExt( v2 );
                txtBand.Text = tag.TPE2;
                txtRemixed.Text = tag.TPE4;
                txtWriter.Text = tag.TEXT;
                txtPublisher.Text = tag.TPUB;
                txtEncoded.Text = tag.TENC;
                txtSubTitle.Text = tag.TIT3;
                if(!multi_edit)
                {
                    cmbMediaType.Text = tag_file.Properties.MediaTypes.ToString();
                    txtTrackLength.Text = tag_file.Properties.Duration.ToString();
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
                    //if(first_tag_file.Properties.MediaTypes != tag_file.Properties.MediaTypes)
                    //    cmbMediaType.Text = string.Empty;
                    // always empty
                    txtTrackLength.Text = string.Empty;
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
                TagExt tag = new TagExt( item.Id3v2 );
                tag.TPE2 = txtBand.Text;
                tag.TPE4 = txtRemixed.Text;
                tag.TEXT = txtWriter.Text;
                tag.TPUB = txtPublisher.Text;
                tag.TENC = txtEncoded.Text;
                tag.TIT3 = txtSubTitle.Text;
                //readonly ?
                //tag_file.Properties.MediaTypes = 
                //tag_file.Properties.Duration =
                item.Id3v2.Copyright = txtCopyright.Text;
                item.Id3v2.Grouping = txtContentGroup.Text;
                item.Id3v2.Conductor = txtConductor.Text;
                //item.Id3v2.Composers = new string[1] { txtComposer.Text };
            }
        }
    }
}
                                                                    