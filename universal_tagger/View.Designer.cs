namespace universal_tagger
{
    partial class View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if(disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.contextViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnViewCopyTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditTag = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDeleteFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.AllowDrop = true;
            this.listView.ContextMenuStrip = this.contextViewMenu;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(774, 641);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listView.DragLeave += new System.EventHandler(this.listView_DragLeave);
            this.listView.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.listView_GiveFeedback);
            this.listView.ColumnReordered += new System.Windows.Forms.ColumnReorderedEventHandler(this.listView_ColumnReordered);
            this.listView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView_ItemDrag);
            this.listView.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DragOver);
            // 
            // contextViewMenu
            // 
            this.contextViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnViewCopyTo,
            this.mnViewMoveTo,
            this.mnViewSelectAll,
            this.toolStripSeparator1,
            this.mnEditTag,
            this.mnDeleteFiles,
            this.toolStripSeparator2,
            this.openFileLocationToolStripMenuItem,
            this.renameToolStripMenuItem});
            this.contextViewMenu.Name = "contextViewMenu";
            this.contextViewMenu.Size = new System.Drawing.Size(174, 170);
            // 
            // mnViewCopyTo
            // 
            this.mnViewCopyTo.Name = "mnViewCopyTo";
            this.mnViewCopyTo.Size = new System.Drawing.Size(173, 22);
            this.mnViewCopyTo.Text = "&CopyTo";
            // 
            // mnViewMoveTo
            // 
            this.mnViewMoveTo.Name = "mnViewMoveTo";
            this.mnViewMoveTo.Size = new System.Drawing.Size(173, 22);
            this.mnViewMoveTo.Text = "MoveTo";
            // 
            // mnViewSelectAll
            // 
            this.mnViewSelectAll.Name = "mnViewSelectAll";
            this.mnViewSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnViewSelectAll.Size = new System.Drawing.Size(173, 22);
            this.mnViewSelectAll.Text = "Select All";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // mnEditTag
            // 
            this.mnEditTag.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnEditTag.Name = "mnEditTag";
            this.mnEditTag.Size = new System.Drawing.Size(173, 22);
            this.mnEditTag.Text = "Edit Tag";
            this.mnEditTag.Click += new System.EventHandler(this.mnEditTag_Click);
            // 
            // mnDeleteFiles
            // 
            this.mnDeleteFiles.Name = "mnDeleteFiles";
            this.mnDeleteFiles.Size = new System.Drawing.Size(173, 22);
            this.mnDeleteFiles.Text = "Delete Files";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(170, 6);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open File Location";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Name = "View";
            this.Size = new System.Drawing.Size(774, 641);
            this.contextViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        public System.Windows.Forms.ContextMenuStrip contextViewMenu;
        private System.Windows.Forms.ToolStripMenuItem mnViewCopyTo;
        private System.Windows.Forms.ToolStripMenuItem mnViewMoveTo;
        private System.Windows.Forms.ToolStripMenuItem mnViewSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnDeleteFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mnEditTag;
       
    }
}
