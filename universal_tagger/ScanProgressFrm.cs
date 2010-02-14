using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace universal_tagger
{
    public partial class ScanProgressFrm : universal_tagger.ProgressFrm
    {
        private View view = null;

        public ScanProgressFrm(View view, FileInfo[] infos) 
            : base( new ScanProgressThread( infos ,view.ListView ) )
        {
            InitializeComponent();
            this.view = view;
            
        }
    }

    public partial class OrgProgressFrm : universal_tagger.ProgressFrm
    {
        private View view = null;

        public OrgProgressFrm(View view, FileInfo[] infos)
            : base( null )
        {
            //InitializeComponent();
            this.view = view;

        }
    }
}
