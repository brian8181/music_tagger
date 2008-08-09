using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tools
{
    public interface ITreeNodeExt
    {
        bool Intialized
        {
            get;
            set;
        }
        void Initialize();
        void RefreshNode();
    }

    public abstract class TreeNodeExt : TreeNode, ITreeNodeExt
    {
        protected bool intialized = false;
        public TreeNodeExt()
        {
        }
        
        public TreeNodeExt( string text, int img_idx, int sel_img_idx )
            : base( text, img_idx, sel_img_idx )
        {
        }

        public TreeNodeExt( string text )
            : base( text )
        {
        }
        public bool Intialized
        {
            get
            {
                bool i = intialized;
                intialized = true;
                return i;
            }
            set
            {
                intialized = value;
            }
        }
        public bool CanRead
        {
            get
            {
                return true;
            }

        }
        public abstract void Initialize();
        public abstract void RefreshNode();
    }
    
}
