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
    public partial class ProgressFrm : Form
    {
        private ProgressThread thread = null;
        protected bool defer_action = true;
        protected bool running = false;
        
        public ProgressThread Thread
        {
            get{ return thread; }
        }

        public ProgressFrm(ProgressThread thread)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;

            this.thread = thread;
            this.thread.StatusUpdate += new EventHandler<ProgressThread.StatusArgs>(thread_StatusUpdate);
            this.thread.Finished += new EventHandler<EventArgs>(thread_Finished);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Start()
        {
            if (running == true)
                return;

            if (IsHandleCreated)
            {
                thread.Start();
                running = true;
            }
            else
            {
                defer_action = true;
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (defer_action)
            {
                defer_action = false;
                Start();
            }
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            // If the handle is being destroyed and you are not
            // recreating it, then abort the search.
            if (!RecreatingHandle)
            {
                // TODO stop ? 
            }
            base.OnHandleDestroyed(e);
        }

        public void StartThread()
        {
            Thread.Start();
        }

        void thread_Finished(object sender, EventArgs e)
        {
            // todo 
            SafeClose();
        }

        void thread_StatusUpdate(object sender, ProgressThread.StatusArgs e)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke( 
                    new EventHandler<ProgressThread.StatusArgs>(
                        thread_StatusUpdate ), new object[] { sender, e } );
                return;
            }
            this.progressCtrl.UpdateStatus(e.Status);
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void SafeClose()
        {
            SafeClose(this, EventArgs.Empty);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void SafeClose(object sender, EventArgs args)
        {
            if (InvokeRequired)
            {
                this.Invoke(
                    new EventHandler(SafeClose), sender, args);
                return;
            }
            Close();
        }
    }
}
