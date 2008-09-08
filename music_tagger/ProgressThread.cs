using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace music_tagger.Threading
{
    /// <summary>
    /// Isolate threading
    /// </summary>
    public abstract class ProgressThread : ProgressFrm 
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
        public event EventHandler<EventArgs> Finished;
        protected Thread thread = null;
        protected FileInfo[] infos = null;
        protected volatile bool cancel = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public ProgressThread( FileInfo[] infos )
        {
            thread = new Thread( new ThreadStart( ThreadFunc ) );
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "ProgressThread";
            thread.IsBackground = true;
            this.infos = infos;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Start(IWin32Window window)
        {
            thread.Start();
            this.ShowDialog(window);
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Start()
        {
            thread.Start();
            this.ShowDialog(); 
        }
        protected override void OnCancel()
        {
            cancel = true;
        }
        /// <summary>
        /// 
        /// </summary>
        public abstract void ThreadFunc();

        public delegate void StringDelegate(string stext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnStatusUpdate(string status)
        {
            if(InvokeRequired)
            {
                this.BeginInvoke( new StringDelegate( OnStatusUpdate ), status );
                return;
            }
            this.progressCtrl.UpdateStatus( status );
            if( StatusUpdate != null ) 
                StatusUpdate( this, new StatusArgs( status ) );  
        }
        /// <summary>
        /// 
        /// </summary>
        protected delegate void SafeDelegate();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnFinished()
        {
            if(InvokeRequired)
            {
                this.BeginInvoke( new SafeDelegate( OnFinished ) );
                return;
            }
            if(Finished != null)
                Finished( this, EventArgs.Empty );
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
            // ProgressThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.ClientSize = new System.Drawing.Size( 451, 99 );
            this.Name = "ProgressThread";
            this.ResumeLayout( false );

        }
    }
    /// <summary>
    /// Isolate threading
    /// </summary>
    public abstract class FormatProgressThread : ProgressThread
    {
        protected string format = null;
        protected string path = null;
        protected bool copy = false;
        protected bool overwrite = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public FormatProgressThread( FileInfo[] infos, string format ) : base( infos )
        {
            this.format = format;
        }
   }
}
