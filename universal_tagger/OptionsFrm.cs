using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger
{
    public partial class OptionsFrm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        //public enum DefaultType
        //{
        //    Current = 0,
        //    V1 = 1,
        //    V2 = 2
        //}
        /// <summary>
        /// 
        /// </summary>
        //DefaultType default_type = DefaultType.Current;
        /// <summary>
        /// 
        /// </summary>
        public OptionsFrm()
        {
            InitializeComponent();

            //DefaultType default_type = 
            //    (DefaultType)Enum.Parse( typeof( DefaultType ), Properties.Settings.Default.pref_default_type );

            //switch (default_type)
            //{
            //    case DefaultType.Current:
            //        rbEditCurrent.Checked = true;
            //        break;
            //    case DefaultType.V1:
            //        rbEditV1.Checked = true;
            //        break;
            //    case DefaultType.V2:
            //        rbEditV2.Checked = true;
            //        break;
            //    default:
            //        rbEditCurrent.Checked = true;
            //        break;
            //}

            // get current col settings
            foreach(string str_col in Properties.Settings.Default.cols)
            {
                string[] splits = str_col.Split(',');
                Column c = (Column)Enum.Parse( typeof(Column), splits[0] );
                bool check = splits[1] == "1" ? true : false;
                colList.Items.Add(c, check);
            }
            ckRestoreFolder.Checked = Properties.Settings.Default.restore_dir;
            SetRestoreEnable();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        public void Initialize(View view)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click( object sender, EventArgs e )
        {
            ApplySettings();
            Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click( object sender, EventArgs e )
        {
            ApplySettings();
        }
        /// <summary>
        /// 
        /// </summary>
        private void ApplySettings()
        {
            // add remove cols
            Properties.Settings.Default.cols.Clear();
            Properties.Settings.Default.cols.Add( "File,1" ); // always show
            //Properties.Settings.Default.pref_default_type = default_type.ToString();

            foreach(Column c in colList.Items)
            {
                if(c == Column.File)
                    continue;
                int displayed = colList.CheckedItems.Contains( c ) ? 1 : 0;
                string str_col = String.Format( "{0},{1}", c.ToString(), displayed );
                Properties.Settings.Default.cols.Add( str_col );
            }
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColUp_Click( object sender, EventArgs e )
        {
            int idx = colList.SelectedIndex;
            if(idx > 1) // 0 = file
            {
                bool check = colList.CheckedItems.Contains( colList.SelectedItem );
                Column c = (Column)colList.SelectedItem;
                colList.Items.RemoveAt( idx );
                colList.Items.Insert( --idx, c );
                colList.SetItemChecked( idx, check );
                colList.SelectedIndex = idx;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColDown_Click( object sender, EventArgs e )
        {
            int idx = colList.SelectedIndex;
            if(idx > 0 && idx < colList.Items.Count-1)
            {
                bool check = colList.CheckedItems.Contains( colList.SelectedItem );
                Column c = (Column)colList.SelectedItem;
                colList.Items.RemoveAt( idx );
                colList.Items.Insert( ++idx, c );
                colList.SetItemChecked( idx, check );
                colList.SelectedIndex = idx;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colList_ItemCheck( object sender, ItemCheckEventArgs e )
        {
            // file column always displays
            Column c = (Column)colList.Items[e.Index];
            if( c == Column.File && e.NewValue == CheckState.Unchecked ) 
            {
                e.NewValue = CheckState.Checked;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void On_ColorDoubleClicked( object sender, EventArgs e )
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //todo
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckRestoreFolder_CheckedChanged( object sender, EventArgs e )
        {
            SetRestoreEnable();
        }
        /// <summary>
        ///  enable / dissable start folder controls 
        /// </summary>
        private void SetRestoreEnable()
        {
            txtFolder.Enabled = !ckRestoreFolder.Checked;
            btnBrowse.Enabled = !ckRestoreFolder.Checked;
        }
    }
}