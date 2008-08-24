using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tools
{
    /// <summary>
    /// node ext interface
    /// </summary>
    public interface ITreeNodeExt
    {
        /// <summary>
        /// true if sub nodes have been read
        /// </summary>
        bool Intialized
        {
            get;
        }
        /// <summary>
        /// true if sub nodes are readable
        /// </summary>
        bool CanRead
        {
            get;
        }
        /// <summary>
        /// intialize the root of node
        /// </summary>
        void InitializeRoot();
        /// <summary>
        /// refesh sub nodes
        /// </summary>
        void RefreshNode();
    }
    /// <summary>
    /// extended treenode 
    /// </summary>
    public abstract class TreeNodeExt : TreeNode, ITreeNodeExt
    {
        protected bool intialized = false;
        /// <summary>
        /// default constructor
        /// </summary>
        public TreeNodeExt()
        {
        }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="text"></param>
        /// <param name="img_idx"></param>
        /// <param name="sel_img_idx"></param>
        public TreeNodeExt( string text, int img_idx, int sel_img_idx )
            : base( text, img_idx, sel_img_idx )
        {
        }
        /// <summary>
        ///  constructor
        /// </summary>
        /// <param name="text"></param>
        public TreeNodeExt( string text )
            : base( text )
        {
        }
        /// <summary>
        /// gets is initialized
        /// </summary>
        public bool Intialized
        {
            get
            {
                return intialized;
            }
        }
        public abstract bool CanRead
        {
            get;
        }
        /// <summary>
        /// initailze the node
        /// </summary>
        public abstract void InitializeRoot();
        /// <summary>
        /// refresh the node
        /// </summary>
        public abstract void RefreshNode();
    }
    
}
