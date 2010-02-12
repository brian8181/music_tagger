using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace universal_tagger
{
    /// <summary>
    /// Isolate threading
    /// </summary>
    public abstract class ProgressThread 
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
        protected bool running = false;
       
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
        public virtual void Start()
        {
            if (running == true)
                    return;

            thread.Start();
            running = true;
         }

      
        /// <summary>
        /// 
        /// </summary>
        public abstract void ThreadFunc();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stext"></param>
        public delegate void StringDelegate(string stext);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="status"></param>
        protected virtual void OnStatusUpdate(string status)
        {
          if (StatusUpdate != null)
                StatusUpdate(this, new StatusArgs(status));
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
            if (Finished != null)
                Finished(this, EventArgs.Empty);
        }
    }
}
