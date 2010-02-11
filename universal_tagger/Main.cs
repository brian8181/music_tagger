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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            // init tree
            tree.Initilaize();
        }
    }
}
