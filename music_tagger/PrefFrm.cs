using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class PrefFrm : Form
    {
        public PrefFrm()
        {
            InitializeComponent();
            Column[] cols = Enum.GetValues(typeof(Column)) as Column[];
            foreach(Column c in cols)
            {
                if(c == Column.File)
                    continue;
                colList.Items.Add( c, true );
            }
            ckRestoreFolder.Checked = Properties.Settings.Default.restore_dir;
        }

        public void Initialize(View view)
        {

        }
               
        private void btnOK_Click( object sender, EventArgs e )
        {
            // add remove cols

            Properties.Settings.Default.Save();
        }

        private void btnApply_Click( object sender, EventArgs e )
        {
            Properties.Settings.Default.Save();
        }

        private void Apply()
        {
            foreach(Column c in colList.Items)
            {

            }
        }

        private void btnColUp_Click( object sender, EventArgs e )
        {
            int idx = colList.SelectedIndex;
            if(idx > 0)
            {
                bool check = colList.CheckedItems.Contains( colList.SelectedItem );
                Column c = (Column)colList.SelectedItem;
                colList.Items.RemoveAt( idx );
                colList.Items.Insert( --idx, c );
                colList.SetItemChecked( idx, check );
                colList.SelectedIndex = idx;
            }
        }

        private void btnColDown_Click( object sender, EventArgs e )
        {
            int idx = colList.SelectedIndex;
            if(idx >= 0 && idx < colList.Items.Count-1)
            {
                bool check = colList.CheckedItems.Contains( colList.SelectedItem );
                Column c = (Column)colList.SelectedItem;
                colList.Items.RemoveAt( idx );
                colList.Items.Insert( ++idx, c );
                colList.SetItemChecked( idx, check );
                colList.SelectedIndex = idx;
            }
        }
    }
}