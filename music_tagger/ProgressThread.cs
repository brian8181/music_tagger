using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace music_tagger
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

        public class ColumnUpdateArgs
        {
        }

        /// <summary>
        /// Status Update Event
        /// </summary>
        public event EventHandler<StatusArgs> StatusUpdate;
        public event EventHandler<EventArgs> Finished;
        protected Thread thread = null;
        protected FileInfo[] infos = null;
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="infos"></param>
        /// <param name="format"></param>
        public ProgressThread( FileInfo[] infos )
        {
            thread = new Thread( new ThreadStart( ThreadFunc ) );
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Name = "OrganizeThread";
            thread.IsBackground = true;
    
            this.infos = infos;
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Start(IWin32Window window)
        {
            this.Show(window);
            thread.Start();
        }
        /// <summary>
        /// 
        /// </summary>
        public virtual void Start()
        {
            this.Show();
            thread.Start();    
        }
        /// <summary>
        /// 
        /// </summary>
        public abstract void ThreadFunc();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnStatusUpdate(string status)
        {
            //??????
            //if(InvokeRequired)
            //{
            //    this.Invoke( new SafeDelegate( OnFinished ) );
            //    return;
            //}
            //???????
            this.progressCtrl.UpdateStatus( status );
            if( StatusUpdate != null ) 
                StatusUpdate( this, new StatusArgs( "Finished" ) );  
        }

        private delegate void SafeDelegate();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnFinished()
        {
            if(InvokeRequired)
            {
                this.Invoke( new SafeDelegate( OnFinished ) );
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
            // OrganizeThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.ClientSize = new System.Drawing.Size( 396, 104 );
            this.Name = "OrganizeThread";
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
