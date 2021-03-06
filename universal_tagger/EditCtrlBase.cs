using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace universal_tagger
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EditCtrlBase : UserControl
    {
        private bool dirty;
        protected bool multi_edit = false;
        protected TagLib.File tag_file = null;
        protected TagLib.Tag tag;
        protected ListView lv = null;
        private int idx = -1;
        /// <summary>
        /// 
        /// </summary>
        protected bool Dirty
        {
            get { return dirty; }
            set { dirty = value; }
        }
        /// <summary>
        ///  get the current index
        /// </summary>
        public int Index
        {
            get { return idx; }
        }
        /// <summary>
        /// constructor
        /// </summary>
        public EditCtrlBase()
        {
        }
        /// <summary>
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize( ListView lv )
        {
            Initialize( lv, false );
        }
        /// intialize listview  
        /// </summary>
        /// <param name="lv"></param>
        public virtual void Initialize( ListView lv, bool multi_edit )
        {
            this.multi_edit = multi_edit; 
            this.lv = lv;
            if(lv.SelectedItems.Count > 0)
            {
                Next();
            }
        }
        /// <summary>
        /// move to next tag & advance the index
        /// </summary>
        public void Next()
        {
            if (lv.SelectedItems.Count > (Index + 1))
            {
                FileInfo fi = (FileInfo)lv.SelectedItems[++idx].Tag;
                //lblFile.Text = fi.FullName;
                tag_file = TagLib.File.Create(fi.FullName);
                tag = tag_file.Tag;
                Fill();
            }
        }
        /// <summary>
        /// move to previous tag & retreat index
        /// </summary>
        public void Previous()
        {
            if (lv.SelectedItems.Count > Index && Index > 0)
            {
                FileInfo fi = (FileInfo)lv.SelectedItems[--idx].Tag;
                //lblFile.Text = fi.FullName;
                tag_file = TagLib.File.Create(fi.FullName);
                tag = tag_file.Tag;
                Fill();
            }
        }
        /// <summary>
        ///  fill from tag
        /// </summary>                                                          
        /// <param name="idx"></param>
        public virtual void Fill()
        {
        }
        /// <summary>
        /// merge like values, hide unlike values
        /// </summary>
        public virtual void Coalesce()
        {
        }
        /// <summary>
        ///  ID3v1 edit 
        /// </summary>
        /// <param name="item">the item</param>
        public virtual void EditItem( TagListViewItem item )
        {
            dirty = true;
            item.Dirty = true;
        }
    }
}