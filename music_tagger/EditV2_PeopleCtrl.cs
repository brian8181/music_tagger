using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TagLib.Id3v2;

namespace music_tagger
{
    public partial class EditV2_PeopleCtrl : EditCtrlBase
    {
        public EditV2_PeopleCtrl()
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
            UnknownFrame unk_frame = tag.GetUnknownFrame( "IPLS" );

            if(unk_frame != null)
            {
                InvolvedPeopleFrame frame = new InvolvedPeopleFrame( unk_frame );

                string[] people = frame.Person;
                string[] functions = frame.Function;

                int len = people.Length;
                for(int i = 0; i < len; ++i)
                {
                    ListViewItem item = new ListViewItem( people[i] );
                    item.SubItems.Add( functions[i] );
                    personList.Items.Add( item );
                }

                if(personList.Items.Count > 0)
                {
                    ListViewItem item = personList.Items[0];
                    txtName.Text = item.Text;
                    txtFunction.Text = item.SubItems[1].Text;
                }
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
               
            }
        }
    }
}
