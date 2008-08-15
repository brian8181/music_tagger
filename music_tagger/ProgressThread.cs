using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace music_tagger
{
    /// <summary>
    /// Isolate threading
    /// </summary>
    class ProgressThread : ProgressFrm 
    {
        /// <summary>
        /// Status Args
        /// </summary>
        public class StatusArgs : EventArgs
        {
            private string status = null;
            public string Status
            {
                get { return status; }
                set { status = value; }
            }
            public StatusArgs( string status )
            {
                this.status = status;
            }
        }

        /// <summary>
        /// Status Update Event
        /// </summary>
        public event EventHandler<StatusArgs> StatusUpdate;
        protected Thread thread = null;
        protected FileInfo[] infos = null;
        protected string format = null;
        protected string path = null;
        protected bool copy = false;
        protected bool overwrite = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public ProgressThread( FileInfo[] infos, string format)
        {
            thread = new Thread( new ThreadStart( ThreadFunc ) );
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "OrganizeThread";
            thread.IsBackground = true;

            this.infos = infos;
            this.format = format;
          
        }
        /// <summary>
        /// 
        /// </summary>
        public void Start()
        {
            this.Show();
            thread.Start();    
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void ThreadFunc()
        {
            SafeClose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnStatusUpdate(string status)
        {
            this.progressCtrl.UpdateStatus( status );
            if( StatusUpdate != null ) 
                StatusUpdate( this, new StatusArgs( status ) );  
        }
        /// <summary>
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // progressCtrl
            // 
            this.progressCtrl.Location = new System.Drawing.Point( 3, 3 );
            // 
            // OrganizeThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.ClientSize = new System.Drawing.Size( 396, 104 );
            this.Name = "OrganizeThread";
            this.ResumeLayout( false );

        }
    }
}
