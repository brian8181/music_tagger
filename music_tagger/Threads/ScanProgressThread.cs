using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace music_tagger.Threading
{
    class ScanProgressThread : ProgressThread
    {
        private ListView lv = null;
        private TagLib.TagTypes type = TagLib.TagTypes.Id3v2;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="lv"></param>
        /// <param name="type"></param>
        public ScanProgressThread(FileInfo[] infos, ListView lv, TagLib.TagTypes type)
            : base(infos)
        {
            this.lv = lv;
            this.type = type;
            StartPosition = FormStartPosition.CenterParent;
        }
        /// <summary>
        /// 
        /// </summary>
        public override void ThreadFunc()
        {
            // fill items
            foreach (FileInfo fi in infos)
            {
                if (cancel)
                    break;

                OnStatusUpdate(fi.Name);

                TagListViewItem lvi = new TagListViewItem(lv, fi.FullName);
                lvi.Type = type;
                if (lvi.IntializeItem())
                {
                    // add it to listview
                    SafeAdd(lvi);
                }
            }
            SafeResize();
            OnFinished();
            // HACK!!
            System.Threading.Thread.Sleep(0);
            SafeClose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeResize()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(
                    new SafeDelegate(SafeResize));
                return;
            }
            if (infos.Length > 0)
            {
                int len = lv.Columns.Count;
                for (int i = 0; i < len; ++i)
                {
                    lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        private delegate void SafeAddDelegate(TagListViewItem lvi);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeAdd(TagListViewItem lvi)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(
                    new SafeAddDelegate(SafeAdd), lvi);
                return;
            }
            lv.Items.Add(lvi);
        }
    }
}