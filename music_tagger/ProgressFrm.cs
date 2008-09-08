using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace music_tagger.Threading
{
    public partial class ProgressFrm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public ProgressFrm() 
        {
            InitializeComponent();
            progressCtrl.progressBar.Style = ProgressBarStyle.Marquee;
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
                return;
            }

            Close();
        }

        private void btnCancel_Click( object sender, EventArgs e )
        {
            OnCancel();
        }

        protected virtual void OnCancel()
        {
        }
    }
}