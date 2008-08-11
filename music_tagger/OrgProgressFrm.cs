using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    public partial class OrgProgressFrm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public OrgProgressFrm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        public void SafeClose()
        {
            SafeClose( this, EventArgs.Empty ); 
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SafeClose(object sender, EventArgs args)
        {
            if(InvokeRequired)
            {
                this.Invoke( 
                    new EventHandler( SafeClose ), sender, args);
            }
            Close();
        }
    }
}