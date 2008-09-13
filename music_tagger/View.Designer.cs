namespace music_tagger
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
            this.contextViewMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.mnViewCopyTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditV2 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.listView.Location = new System.Drawing.Point( 0, 0 );
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size( 774, 641 );
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler( this.listView_DoubleClick );
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler( this.listView_DragDrop );
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler( this.listView_ColumnClick );
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler( this.listView_DragEnter );
            this.listView.DragLeave += new System.EventHandler( this.listView_DragLeave );
            this.listView.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler( this.listView_GiveFeedback );
            this.listView.ColumnReordered += new System.Windows.Forms.ColumnReorderedEventHandler( this.listView_ColumnReordered );
            this.listView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler( this.listView_ItemDrag );
            this.listView.DragOver += new System.Windows.Forms.DragEventHandler( this.listView_DragOver );
            // 
            // contextViewMenu
            // 
            this.contextViewMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.mnViewCopyTo,
            this.mnViewMoveTo,
            this.mnViewSelectAll,
            this.toolStripSeparator1,
            this.mnEditV1,
            this.mnEditV2} );
            this.contextViewMenu.Name = "contextViewMenu";
            this.contextViewMenu.Size = new System.Drawing.Size( 168, 142 );
            // 
            // mnViewCopyTo
            // 
            this.mnViewCopyTo.Name = "mnViewCopyTo";
            this.mnViewCopyTo.Size = new System.Drawing.Size( 167, 22 );
            this.mnViewCopyTo.Text = "&CopyTo";
            this.mnViewCopyTo.Click += new System.EventHandler( this.mnViewCopyTo_Click );
            // 
            // mnViewMoveTo
            // 
            this.mnViewMoveTo.Name = "mnViewMoveTo";
            this.mnViewMoveTo.Size = new System.Drawing.Size( 167, 22 );
            this.mnViewMoveTo.Text = "MoveTo";
            this.mnViewMoveTo.Click += new System.EventHandler( this.mnViewMoveTo_Click );
            // 
            // mnViewSelectAll
            // 
            this.mnViewSelectAll.Name = "mnViewSelectAll";
            this.mnViewSelectAll.ShortcutKeys = ( (System.Windows.Forms.Keys)( ( System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A ) ) );
            this.mnViewSelectAll.Size = new System.Drawing.Size( 167, 22 );
            this.mnViewSelectAll.Text = "Select All";
            this.mnViewSelectAll.Click += new System.EventHandler( this.mnViewSelectAll_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 164, 6 );
            // 
            // mnEditV1
            // 
            this.mnEditV1.Image = global::music_tagger.Properties.Resources.v1;
            this.mnEditV1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnEditV1.Name = "mnEditV1";
            this.mnEditV1.Size = new System.Drawing.Size( 167, 22 );
            this.mnEditV1.Text = "Edit Tag Ver. 1";
            // 
            // mnEditV2
            // 
            this.mnEditV2.Name = "mnEditV2";
            this.mnEditV2.Size = new System.Drawing.Size( 167, 22 );
            this.mnEditV2.Text = "Edit Tag Ver. 2";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.listView );
            this.Name = "View";
            this.Size = new System.Drawing.Size( 774, 641 );
            this.contextViewMenu.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ToolStripMenuItem mnViewCopyTo;
        private System.Windows.Forms.ToolStripMenuItem mnViewMoveTo;
        private System.Windows.Forms.ToolStripMenuItem mnViewSelectAll;
        public System.Windows.Forms.ContextMenuStrip contextViewMenu;
        private System.Windows.Forms.ToolStripMenuItem mnEditV1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnEditV2;
    }
}
