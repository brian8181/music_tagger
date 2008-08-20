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
                columnList.Items.Add( c, true );
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

        private void btnColUp_Click( object sender, EventArgs e )
        {
            int idx = columnList.SelectedIndex;
            if(idx > 0)
            {
                bool check = columnList.CheckedItems.Contains( columnList.SelectedItem );
                Column c = (Column)columnList.SelectedItem;
                columnList.Items.RemoveAt( idx );
                columnList.Items.Insert( --idx, c );
                columnList.SetItemChecked( idx, check );
                columnList.SelectedIndex = idx;
            }
        }

        private void btnColDown_Click( object sender, EventArgs e )
        {
            int idx = columnList.SelectedIndex;
            if(idx >= 0 && idx < columnList.Items.Count-1)
            {
                bool check = columnList.CheckedItems.Contains( columnList.SelectedItem );
                Column c = (Column)columnList.SelectedItem;
                columnList.Items.RemoveAt( idx );
                columnList.Items.Insert( ++idx, c );
                columnList.SetItemChecked( idx, check );
                columnList.SelectedIndex = idx;
            }
        }
    }
}