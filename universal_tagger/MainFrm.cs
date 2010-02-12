using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace universal_tagger
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            // init tree
            tree.Initilaize();

            // init view
            view.Initialize(tree);
            view.Refreshed += new EventHandler<View.RefreshArgs>(view_Refreshed);
            view.ListView.SelectedIndexChanged += new EventHandler(ListView_SelectedIndexChanged);
        }

        /// <summary>
        /// handler for view.Refreshed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void view_Refreshed(object sender, View.RefreshArgs e)
        {
            UpdateFileStatus();
            //tsCurrentPath.Text = e.Path;
        }
        /// <summary>
        /// handler for ListView.SelectedIndexChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFileStatus();
        }
        /// <summary>
        /// update the fiel status label
        /// </summary>
        private void UpdateFileStatus()
        {
            //tsFileCount.Text = String.Format("Selected: {0} of {1}",
            //   view.ListView.SelectedItems.Count,
            //    view.ListView.Items.Count);
        }

        private void mnOptions_Click(object sender, EventArgs e)
        {
            OptionsFrm frm = new OptionsFrm();
            if (frm.ShowDialog() != DialogResult.OK)
                return;

        }
    }
      
}
