using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class FileTreeViewCtrl : UserControl
    {
        public FileTreeViewCtrl()
        {
            InitializeComponent();
            treeView.Configure();
        }
    }
}
