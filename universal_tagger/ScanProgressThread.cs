using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace universal_tagger
{
    class ScanProgressThread : ProgressThread
    {
        public delegate void ItemFoundDelegate(TagListViewItem lvi);
        public event ItemFoundDelegate ItemFound;

        private ListView lv = null;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="lv"></param>
        /// <param name="type"></param>
        public ScanProgressThread(FileInfo[] infos, ListView lv)
            : base(infos)
        {
            this.lv = lv;
            // MOVE TO FORM
            //StartPosition = FormStartPosition.CenterParent;
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
                if (lvi.IntializeItem())
                {
                    // add it to listview
                    //BKP  OLD SafeAdd(lvi);
                    if (ItemFound != null)
                        ItemFound(lvi);
                }
            }
            SafeResize();
            OnFinished();
            // HACK!!
            System.Threading.Thread.Sleep(0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lvi"></param>
        public void SafeResize()
        {
            //BKP MOVE TO FORM
            //if (InvokeRequired)
            //{
            //    this.BeginInvoke(
            //        new SafeDelegate(SafeResize));
            //    return;
            //}
            //if (infos.Length > 0)
            //{
            //    int len = lv.Columns.Count;
            //    for (int i = 0; i < len; ++i)
            //    {
            //        lv.Columns[i].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            //    }
            //}
        }
       
    }
}