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
    /// <summary>
    /// 
    /// </summary>
    public partial class EditV2CtrlBase : UserControl
    {
        protected bool multi_edit = false;
        protected TagLib.File tag_file = null;
        protected TagLib.Id3v1.Tag v1;
        protected TagLib.Id3v2.Tag v2;
        protected ListView lv = null;
        protected int idx = -1;

        /// <summary>
        /// 
        /// </summary>
        public EditV2CtrlBase() : this(false)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="multi_edit"></param>
        public EditV2CtrlBase(bool multi_edit)
        {
            InitializeComponent();
            this.multi_edit = multi_edit;
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize( ListView lv )
        {
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                idx = 0;
                Fill( idx );
            }
        }
        /// <summary>
        ///  fill from tag
        /// </summary>
        /// <param name="idx"></param>
        public virtual void Fill( int idx )
        {
            FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
            //  lblFile.Text = fi.FullName;
            tag_file = TagLib.File.Create( fi.FullName );
            v2 = (TagLib.Id3v2.Tag)tag_file.GetTag( TagLib.TagTypes.Id3v2 );
            v1 = (TagLib.Id3v1.Tag)tag_file.GetTag( TagLib.TagTypes.Id3v1 );
            Fill( v2 );
        }
         /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public virtual void Fill( TagLib.Tag tag )
        {
        }
    }
}
