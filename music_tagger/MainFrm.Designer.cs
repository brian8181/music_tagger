namespace music_tagger
{
    partial class MainFrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnFileCopyTo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFileOrganize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.copyVer1TagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyVer2TagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyVer12TagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditPast = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.spit1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.split2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnViewV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.mnViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.iD3FunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEditV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMultiEditV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRemoveTagV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFile2TagV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTag2FileV1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.mnEditV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMultiEditV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRemoveTagV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnFile2TagV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTag2FileV2 = new System.Windows.Forms.ToolStripMenuItem();
            this.extentedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_Transfer = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOptionsScanSubs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrefs = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelpContents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHelpIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCurrentPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsVersionShown = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsScanSubs = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tree = new Tools.FileTreeView();
            this.view = new music_tagger.View();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsb_EditV1 = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditV1Multi = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_RemoveV1 = new System.Windows.Forms.ToolStripButton();
            this.tsFile2TagV1 = new System.Windows.Forms.ToolStripButton();
            this.tsTagV12File = new System.Windows.Forms.ToolStripButton();
            this.tsb_ToggleVer = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditV2 = new System.Windows.Forms.ToolStripButton();
            this.tsb_EditV2Multi = new System.Windows.Forms.ToolStripButton();
            this.tsb_RemoveV2 = new System.Windows.Forms.ToolStripButton();
            this.tsFile2TagV2 = new System.Windows.Forms.ToolStripButton();
            this.tsTagV22File = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.iD3FunctionsToolStripMenuItem,
            this.extentedFunctionsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "mnEdit";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFileSave,
            this.toolStripSeparator2,
            this.mnFileCopyTo,
            this.mnFileMoveTo,
            this.deleteFilesToolStripMenuItem,
            this.mnFileOrganize,
            this.toolStripSeparator15,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // mnFileSave
            // 
            this.mnFileSave.Image = ((System.Drawing.Image)(resources.GetObject("mnFileSave.Image")));
            this.mnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnFileSave.Name = "mnFileSave";
            this.mnFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnFileSave.Size = new System.Drawing.Size(192, 22);
            this.mnFileSave.Text = "&Save";
            this.mnFileSave.Click += new System.EventHandler(this.On_Save);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // mnFileCopyTo
            // 
            this.mnFileCopyTo.Name = "mnFileCopyTo";
            this.mnFileCopyTo.Size = new System.Drawing.Size(192, 22);
            this.mnFileCopyTo.Text = "CopyTo";
            this.mnFileCopyTo.Click += new System.EventHandler(this.mnFileCopyTo_Click);
            // 
            // mnFileMoveTo
            // 
            this.mnFileMoveTo.Name = "mnFileMoveTo";
            this.mnFileMoveTo.Size = new System.Drawing.Size(192, 22);
            this.mnFileMoveTo.Text = "MoveTo";
            this.mnFileMoveTo.Click += new System.EventHandler(this.mnFileMoveTo_Click);
            // 
            // deleteFilesToolStripMenuItem
            // 
            this.deleteFilesToolStripMenuItem.Name = "deleteFilesToolStripMenuItem";
            this.deleteFilesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.deleteFilesToolStripMenuItem.Text = "Delete Files";
            this.deleteFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteFilesToolStripMenuItem_Click);
            // 
            // mnFileOrganize
            // 
            this.mnFileOrganize.Name = "mnFileOrganize";
            this.mnFileOrganize.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnFileOrganize.Size = new System.Drawing.Size(192, 22);
            this.mnFileOrganize.Text = "&Organize Files";
            this.mnFileOrganize.Click += new System.EventHandler(this.mnFileOrganize_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEditUndo,
            this.mnEditRedo,
            this.toolStripSeparator3,
            this.mnEditCut,
            this.toolStripSeparator4,
            this.mnEditCopy,
            this.mnEditPast,
            this.toolStripSeparator16,
            this.spit1ToolStripMenuItem,
            this.split2ToolStripMenuItem,
            this.toolStripSeparator17,
            this.mnEditSelectAll});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // mnEditUndo
            // 
            this.mnEditUndo.Name = "mnEditUndo";
            this.mnEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnEditUndo.Size = new System.Drawing.Size(249, 22);
            this.mnEditUndo.Text = "&Undo";
            this.mnEditUndo.Click += new System.EventHandler(this.mnEditUndo_Click);
            // 
            // mnEditRedo
            // 
            this.mnEditRedo.Name = "mnEditRedo";
            this.mnEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnEditRedo.Size = new System.Drawing.Size(249, 22);
            this.mnEditRedo.Text = "&Redo";
            this.mnEditRedo.Click += new System.EventHandler(this.mnEditRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(246, 6);
            // 
            // mnEditCut
            // 
            this.mnEditCut.Image = ((System.Drawing.Image)(resources.GetObject("mnEditCut.Image")));
            this.mnEditCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnEditCut.Name = "mnEditCut";
            this.mnEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnEditCut.Size = new System.Drawing.Size(249, 22);
            this.mnEditCut.Text = "Search";
            this.mnEditCut.Click += new System.EventHandler(this.mnEditCut_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(246, 6);
            // 
            // mnEditCopy
            // 
            this.mnEditCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyVer1TagToolStripMenuItem,
            this.copyVer2TagToolStripMenuItem,
            this.copyVer12TagToolStripMenuItem});
            this.mnEditCopy.Image = ((System.Drawing.Image)(resources.GetObject("mnEditCopy.Image")));
            this.mnEditCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnEditCopy.Name = "mnEditCopy";
            this.mnEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnEditCopy.Size = new System.Drawing.Size(249, 22);
            this.mnEditCopy.Text = "&Copy Tag Infomration";
            this.mnEditCopy.Click += new System.EventHandler(this.mnEditCopy_Click);
            // 
            // copyVer1TagToolStripMenuItem
            // 
            this.copyVer1TagToolStripMenuItem.Name = "copyVer1TagToolStripMenuItem";
            this.copyVer1TagToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyVer1TagToolStripMenuItem.Text = "Copy Ver. 1 Tag ";
            // 
            // copyVer2TagToolStripMenuItem
            // 
            this.copyVer2TagToolStripMenuItem.Name = "copyVer2TagToolStripMenuItem";
            this.copyVer2TagToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyVer2TagToolStripMenuItem.Text = "Copy Ver. 2 Tag";
            // 
            // copyVer12TagToolStripMenuItem
            // 
            this.copyVer12TagToolStripMenuItem.Name = "copyVer12TagToolStripMenuItem";
            this.copyVer12TagToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.copyVer12TagToolStripMenuItem.Text = "Copy Ver. 1 & 2 Tag";
            // 
            // mnEditPast
            // 
            this.mnEditPast.Image = ((System.Drawing.Image)(resources.GetObject("mnEditPast.Image")));
            this.mnEditPast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnEditPast.Name = "mnEditPast";
            this.mnEditPast.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnEditPast.Size = new System.Drawing.Size(249, 22);
            this.mnEditPast.Text = "&Paste Tag Information";
            this.mnEditPast.Click += new System.EventHandler(this.mnEditPast_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(246, 6);
            // 
            // spit1ToolStripMenuItem
            // 
            this.spit1ToolStripMenuItem.Name = "spit1ToolStripMenuItem";
            this.spit1ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.spit1ToolStripMenuItem.Text = "Split Artist into Artist && Title Ver. 1";
            // 
            // split2ToolStripMenuItem
            // 
            this.split2ToolStripMenuItem.Name = "split2ToolStripMenuItem";
            this.split2ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.split2ToolStripMenuItem.Text = "Split Artist into Artist && Title Ver. 2";
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(246, 6);
            // 
            // mnEditSelectAll
            // 
            this.mnEditSelectAll.Name = "mnEditSelectAll";
            this.mnEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnEditSelectAll.Size = new System.Drawing.Size(249, 22);
            this.mnEditSelectAll.Text = "Select &All";
            this.mnEditSelectAll.Click += new System.EventHandler(this.mnEditSelectAll_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.CheckOnClick = true;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnViewV1,
            this.mnViewV2,
            this.toolStripSeparator13,
            this.mnViewRefresh});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // mnViewV1
            // 
            this.mnViewV1.Checked = true;
            this.mnViewV1.CheckOnClick = true;
            this.mnViewV1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnViewV1.Name = "mnViewV1";
            this.mnViewV1.Size = new System.Drawing.Size(160, 22);
            this.mnViewV1.Text = "View Tag Ver. 1";
            this.mnViewV1.Click += new System.EventHandler(this.mnViewV1_Click);
            // 
            // mnViewV2
            // 
            this.mnViewV2.CheckOnClick = true;
            this.mnViewV2.Name = "mnViewV2";
            this.mnViewV2.Size = new System.Drawing.Size(160, 22);
            this.mnViewV2.Text = "View Tag Ver. 2";
            this.mnViewV2.Click += new System.EventHandler(this.mnViewV2_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(157, 6);
            // 
            // mnViewRefresh
            // 
            this.mnViewRefresh.Name = "mnViewRefresh";
            this.mnViewRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnViewRefresh.Size = new System.Drawing.Size(160, 22);
            this.mnViewRefresh.Text = "Refresh";
            this.mnViewRefresh.Click += new System.EventHandler(this.On_Refresh);
            // 
            // iD3FunctionsToolStripMenuItem
            // 
            this.iD3FunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEditV1,
            this.mnMultiEditV1,
            this.mnRemoveTagV1,
            this.mnFile2TagV1,
            this.mnTag2FileV1,
            this.toolStripSeparator14,
            this.mnEditV2,
            this.mnMultiEditV2,
            this.mnRemoveTagV2,
            this.mnFile2TagV2,
            this.mnTag2FileV2});
            this.iD3FunctionsToolStripMenuItem.Name = "iD3FunctionsToolStripMenuItem";
            this.iD3FunctionsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.iD3FunctionsToolStripMenuItem.Text = "&ID3-Functions";
            // 
            // mnEditV1
            // 
            this.mnEditV1.Image = global::music_tagger.Properties.Resources.v1;
            this.mnEditV1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.mnEditV1.Name = "mnEditV1";
            this.mnEditV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnEditV1.Size = new System.Drawing.Size(234, 22);
            this.mnEditV1.Text = "Edit Tag Ver. 1";
            this.mnEditV1.Click += new System.EventHandler(this.OnEditV1_Click);
            // 
            // mnMultiEditV1
            // 
            this.mnMultiEditV1.Image = global::music_tagger.Properties.Resources.v1_many;
            this.mnMultiEditV1.Name = "mnMultiEditV1";
            this.mnMultiEditV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnMultiEditV1.Size = new System.Drawing.Size(234, 22);
            this.mnMultiEditV1.Text = "Multi-Tag Edit Ver. 1";
            this.mnMultiEditV1.Click += new System.EventHandler(this.OnEditV1Multi_Click);
            // 
            // mnRemoveTagV1
            // 
            this.mnRemoveTagV1.Image = global::music_tagger.Properties.Resources.delv1;
            this.mnRemoveTagV1.Name = "mnRemoveTagV1";
            this.mnRemoveTagV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
            this.mnRemoveTagV1.Size = new System.Drawing.Size(234, 22);
            this.mnRemoveTagV1.Text = "Remove Tag Ver. 1 ";
            // 
            // mnFile2TagV1
            // 
            this.mnFile2TagV1.Image = global::music_tagger.Properties.Resources.file2v1;
            this.mnFile2TagV1.Name = "mnFile2TagV1";
            this.mnFile2TagV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnFile2TagV1.Size = new System.Drawing.Size(234, 22);
            this.mnFile2TagV1.Text = "Filename -> Tag Ver. 1";
            this.mnFile2TagV1.Click += new System.EventHandler(this.mnFile2TagV1_Click);
            // 
            // mnTag2FileV1
            // 
            this.mnTag2FileV1.Image = global::music_tagger.Properties.Resources.v12file;
            this.mnTag2FileV1.Name = "mnTag2FileV1";
            this.mnTag2FileV1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnTag2FileV1.Size = new System.Drawing.Size(234, 22);
            this.mnTag2FileV1.Text = "Tag Ver. 1 -> Filename";
            this.mnTag2FileV1.Click += new System.EventHandler(this.mnTag2FileV1_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(231, 6);
            // 
            // mnEditV2
            // 
            this.mnEditV2.Image = global::music_tagger.Properties.Resources.v2;
            this.mnEditV2.Name = "mnEditV2";
            this.mnEditV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnEditV2.Size = new System.Drawing.Size(234, 22);
            this.mnEditV2.Text = "Edit Tag Ver. 2";
            this.mnEditV2.Click += new System.EventHandler(this.OnEditV2_Click);
            // 
            // mnMultiEditV2
            // 
            this.mnMultiEditV2.Image = global::music_tagger.Properties.Resources.v2_many;
            this.mnMultiEditV2.Name = "mnMultiEditV2";
            this.mnMultiEditV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnMultiEditV2.Size = new System.Drawing.Size(234, 22);
            this.mnMultiEditV2.Text = "Multi-Tag Edit Ver. 2";
            this.mnMultiEditV2.Click += new System.EventHandler(this.OnEditV2Multi_Click);
            // 
            // mnRemoveTagV2
            // 
            this.mnRemoveTagV2.Image = global::music_tagger.Properties.Resources.delv2;
            this.mnRemoveTagV2.Name = "mnRemoveTagV2";
            this.mnRemoveTagV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
            this.mnRemoveTagV2.Size = new System.Drawing.Size(234, 22);
            this.mnRemoveTagV2.Text = "Remove Tag Ver. 2";
            this.mnRemoveTagV2.Click += new System.EventHandler(this.OnRemoveTagV2_Click);
            // 
            // mnFile2TagV2
            // 
            this.mnFile2TagV2.Image = global::music_tagger.Properties.Resources.file2v2;
            this.mnFile2TagV2.Name = "mnFile2TagV2";
            this.mnFile2TagV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnFile2TagV2.Size = new System.Drawing.Size(234, 22);
            this.mnFile2TagV2.Text = "Filename -> Tag Ver. 2";
            this.mnFile2TagV2.Click += new System.EventHandler(this.OnFile2TagV2_Click);
            // 
            // mnTag2FileV2
            // 
            this.mnTag2FileV2.Image = global::music_tagger.Properties.Resources.v22file;
            this.mnTag2FileV2.Name = "mnTag2FileV2";
            this.mnTag2FileV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnTag2FileV2.Size = new System.Drawing.Size(234, 22);
            this.mnTag2FileV2.Text = "Tag Ver. 2 -> Filename";
            this.mnTag2FileV2.Click += new System.EventHandler(this.OnTag2FileV2_Click);
            // 
            // extentedFunctionsToolStripMenuItem
            // 
            this.extentedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseConversionToolStripMenuItem,
            this.tsb_Transfer});
            this.extentedFunctionsToolStripMenuItem.Name = "extentedFunctionsToolStripMenuItem";
            this.extentedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.extentedFunctionsToolStripMenuItem.Text = "E&xtended Functions";
            // 
            // caseConversionToolStripMenuItem
            // 
            this.caseConversionToolStripMenuItem.Name = "caseConversionToolStripMenuItem";
            this.caseConversionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.caseConversionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.caseConversionToolStripMenuItem.Text = "Case Conversion";
            this.caseConversionToolStripMenuItem.Click += new System.EventHandler(this.On_CaseConvert);
            // 
            // tsb_Transfer
            // 
            this.tsb_Transfer.Name = "tsb_Transfer";
            this.tsb_Transfer.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsb_Transfer.Size = new System.Drawing.Size(214, 22);
            this.tsb_Transfer.Text = "Transfer/Convert Tags";
            this.tsb_Transfer.Click += new System.EventHandler(this.On_Transfer_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOptionsScanSubs,
            this.mnPrefs});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // mnOptionsScanSubs
            // 
            this.mnOptionsScanSubs.CheckOnClick = true;
            this.mnOptionsScanSubs.Name = "mnOptionsScanSubs";
            this.mnOptionsScanSubs.Size = new System.Drawing.Size(179, 22);
            this.mnOptionsScanSubs.Text = "Scan Subdirectories";
            this.mnOptionsScanSubs.Click += new System.EventHandler(this.mnOptionsScanSubs_Click);
            // 
            // mnPrefs
            // 
            this.mnPrefs.Name = "mnPrefs";
            this.mnPrefs.Size = new System.Drawing.Size(179, 22);
            this.mnPrefs.Text = "Preferences";
            this.mnPrefs.Click += new System.EventHandler(this.mnPrefs_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHelpContents,
            this.mnHelpIndex,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnHelpContents
            // 
            this.mnHelpContents.Name = "mnHelpContents";
            this.mnHelpContents.Size = new System.Drawing.Size(129, 22);
            this.mnHelpContents.Text = "&Contents";
            this.mnHelpContents.Click += new System.EventHandler(this.OnHelp_Clicked);
            // 
            // mnHelpIndex
            // 
            this.mnHelpIndex.Name = "mnHelpIndex";
            this.mnHelpIndex.Size = new System.Drawing.Size(129, 22);
            this.mnHelpIndex.Text = "&Index";
            this.mnHelpIndex.Click += new System.EventHandler(this.OnHelp_Clicked);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(126, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1119, 559);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1119, 630);
            this.toolStripContainer.TabIndex = 1;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFileCount,
            this.tsCurrentPath,
            this.tsVersionShown,
            this.tsScanSubs});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1119, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // tsFileCount
            // 
            this.tsFileCount.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsFileCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsFileCount.Name = "tsFileCount";
            this.tsFileCount.Size = new System.Drawing.Size(65, 17);
            this.tsFileCount.Text = "tsFileCount";
            // 
            // tsCurrentPath
            // 
            this.tsCurrentPath.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsCurrentPath.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsCurrentPath.Name = "tsCurrentPath";
            this.tsCurrentPath.Size = new System.Drawing.Size(886, 17);
            this.tsCurrentPath.Spring = true;
            this.tsCurrentPath.Text = "C:\\\\";
            // 
            // tsVersionShown
            // 
            this.tsVersionShown.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsVersionShown.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsVersionShown.Name = "tsVersionShown";
            this.tsVersionShown.Size = new System.Drawing.Size(87, 17);
            this.tsVersionShown.Text = "tsVersionShown";
            // 
            // tsScanSubs
            // 
            this.tsScanSubs.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tsScanSubs.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.tsScanSubs.Name = "tsScanSubs";
            this.tsScanSubs.Size = new System.Drawing.Size(66, 17);
            this.tsScanSubs.Text = "tsScanSubs";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.view);
            this.splitContainer1.Size = new System.Drawing.Size(1119, 559);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.AllowDrop = true;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageIndex = 0;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(284, 559);
            this.tree.TabIndex = 0;
            // 
            // view
            // 
            this.view.Dock = System.Windows.Forms.DockStyle.Fill;
            this.view.Location = new System.Drawing.Point(0, 0);
            this.view.Name = "view";
            this.view.SearchOption = System.IO.SearchOption.TopDirectoryOnly;
            this.view.Size = new System.Drawing.Size(831, 559);
            this.view.TabIndex = 0;
            this.view.Type = TagLib.TagTypes.Id3v1;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Save,
            this.toolStripSeparator6,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator7,
            this.helpToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(3, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(139, 25);
            this.mainToolStrip.TabIndex = 1;
            // 
            // tsb_Save
            // 
            this.tsb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Save.Image")));
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(23, 22);
            this.tsb_Save.Text = "&Save";
            this.tsb_Save.Click += new System.EventHandler(this.On_Save);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_EditV1,
            this.tsb_EditV1Multi,
            this.toolStripSeparator8,
            this.tsb_RemoveV1,
            this.tsFile2TagV1,
            this.tsTagV12File,
            this.tsb_ToggleVer,
            this.tsb_EditV2,
            this.tsb_EditV2Multi,
            this.tsb_RemoveV2,
            this.tsFile2TagV2,
            this.tsTagV22File,
            this.toolStripSeparator1,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3});
            this.toolStrip2.Location = new System.Drawing.Point(142, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(455, 25);
            this.toolStrip2.TabIndex = 2;
            // 
            // tsb_EditV1
            // 
            this.tsb_EditV1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditV1.Image = global::music_tagger.Properties.Resources.v1;
            this.tsb_EditV1.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsb_EditV1.Name = "tsb_EditV1";
            this.tsb_EditV1.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditV1.Text = "Edit Ver.1";
            this.tsb_EditV1.Click += new System.EventHandler(this.OnEditV1_Click);
            // 
            // tsb_EditV1Multi
            // 
            this.tsb_EditV1Multi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditV1Multi.Image = global::music_tagger.Properties.Resources.v1_many;
            this.tsb_EditV1Multi.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsb_EditV1Multi.Name = "tsb_EditV1Multi";
            this.tsb_EditV1Multi.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditV1Multi.Text = "Edit Multi-Ver.1";
            this.tsb_EditV1Multi.Click += new System.EventHandler(this.OnEditV1Multi_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsb_RemoveV1
            // 
            this.tsb_RemoveV1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_RemoveV1.Image = ((System.Drawing.Image)(resources.GetObject("tsb_RemoveV1.Image")));
            this.tsb_RemoveV1.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_RemoveV1.Name = "tsb_RemoveV1";
            this.tsb_RemoveV1.Size = new System.Drawing.Size(23, 22);
            this.tsb_RemoveV1.Text = "Delete Tag Ver. 1";
            this.tsb_RemoveV1.Click += new System.EventHandler(this.OnRemoveTagV1_Click);
            // 
            // tsFile2TagV1
            // 
            this.tsFile2TagV1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFile2TagV1.Image = ((System.Drawing.Image)(resources.GetObject("tsFile2TagV1.Image")));
            this.tsFile2TagV1.ImageTransparentColor = System.Drawing.Color.White;
            this.tsFile2TagV1.Name = "tsFile2TagV1";
            this.tsFile2TagV1.Size = new System.Drawing.Size(23, 22);
            this.tsFile2TagV1.Text = "toolStripButton7";
            this.tsFile2TagV1.Click += new System.EventHandler(this.mnFile2TagV1_Click);
            // 
            // tsTagV12File
            // 
            this.tsTagV12File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTagV12File.Image = ((System.Drawing.Image)(resources.GetObject("tsTagV12File.Image")));
            this.tsTagV12File.ImageTransparentColor = System.Drawing.Color.White;
            this.tsTagV12File.Name = "tsTagV12File";
            this.tsTagV12File.Size = new System.Drawing.Size(23, 22);
            this.tsTagV12File.Text = "toolStripButton8";
            this.tsTagV12File.Click += new System.EventHandler(this.mnTag2FileV1_Click);
            // 
            // tsb_ToggleVer
            // 
            this.tsb_ToggleVer.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ToggleVer.Image")));
            this.tsb_ToggleVer.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_ToggleVer.Name = "tsb_ToggleVer";
            this.tsb_ToggleVer.Size = new System.Drawing.Size(91, 22);
            this.tsb_ToggleVer.Text = "Shown Ver. 2";
            this.tsb_ToggleVer.Click += new System.EventHandler(this.OnToggleVer);
            // 
            // tsb_EditV2
            // 
            this.tsb_EditV2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditV2.Image = global::music_tagger.Properties.Resources.v2;
            this.tsb_EditV2.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsb_EditV2.Name = "tsb_EditV2";
            this.tsb_EditV2.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditV2.Text = "Edit Ver.2";
            this.tsb_EditV2.Click += new System.EventHandler(this.OnEditV2_Click);
            // 
            // tsb_EditV2Multi
            // 
            this.tsb_EditV2Multi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_EditV2Multi.Image = global::music_tagger.Properties.Resources.v2_many;
            this.tsb_EditV2Multi.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.tsb_EditV2Multi.Name = "tsb_EditV2Multi";
            this.tsb_EditV2Multi.Size = new System.Drawing.Size(23, 22);
            this.tsb_EditV2Multi.Text = "Edit Multi-Ver.2";
            this.tsb_EditV2Multi.Click += new System.EventHandler(this.OnEditV2Multi_Click);
            // 
            // tsb_RemoveV2
            // 
            this.tsb_RemoveV2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_RemoveV2.Image = ((System.Drawing.Image)(resources.GetObject("tsb_RemoveV2.Image")));
            this.tsb_RemoveV2.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_RemoveV2.Name = "tsb_RemoveV2";
            this.tsb_RemoveV2.Size = new System.Drawing.Size(23, 22);
            this.tsb_RemoveV2.Text = "Delete Tag Ver. 1";
            this.tsb_RemoveV2.Click += new System.EventHandler(this.OnRemoveTagV2_Click);
            // 
            // tsFile2TagV2
            // 
            this.tsFile2TagV2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsFile2TagV2.Image = ((System.Drawing.Image)(resources.GetObject("tsFile2TagV2.Image")));
            this.tsFile2TagV2.ImageTransparentColor = System.Drawing.Color.White;
            this.tsFile2TagV2.Name = "tsFile2TagV2";
            this.tsFile2TagV2.Size = new System.Drawing.Size(23, 22);
            this.tsFile2TagV2.Text = "toolStripButton9";
            this.tsFile2TagV2.Click += new System.EventHandler(this.OnFile2TagV2_Click);
            // 
            // tsTagV22File
            // 
            this.tsTagV22File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsTagV22File.Image = ((System.Drawing.Image)(resources.GetObject("tsTagV22File.Image")));
            this.tsTagV22File.ImageTransparentColor = System.Drawing.Color.White;
            this.tsTagV22File.Name = "tsTagV22File";
            this.tsTagV22File.Size = new System.Drawing.Size(23, 22);
            this.tsTagV22File.Text = "toolStripButton10";
            this.tsTagV22File.Click += new System.EventHandler(this.OnTag2FileV2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton1";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton2";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton2.Text = "Al";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem4.Text = "Album <-> Tile";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem5.Text = "Artist <-> Album";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem6.Text = "Tile <-> Album";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.toolStripSplitButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton3.Image")));
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton3.Text = "toolStripButton4";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem7.Text = "Album <-> Tile";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem8.Text = "Artist <-> Album";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem9.Text = "Tile <-> Album";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 630);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "ID3 Tools";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnEditUndo;
        private System.Windows.Forms.ToolStripMenuItem mnEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnEditCut;
        private System.Windows.Forms.ToolStripMenuItem mnEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mnEditPast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnEditSelectAll;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnHelpContents;
        private System.Windows.Forms.ToolStripMenuItem mnHelpIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsb_EditV1;
        private System.Windows.Forms.ToolStripButton tsb_EditV1Multi;
        private System.Windows.Forms.ToolStripButton tsb_EditV2;
        private System.Windows.Forms.ToolStripButton tsb_EditV2Multi;
        private System.Windows.Forms.ToolStripButton tsb_RemoveV1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsb_RemoveV2;
        private System.Windows.Forms.ToolStripButton tsFile2TagV1;
        private System.Windows.Forms.ToolStripButton tsTagV12File;
        private System.Windows.Forms.ToolStripButton tsFile2TagV2;
        private System.Windows.Forms.ToolStripButton tsTagV22File;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Tools.FileTreeView tree;
        private View view;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iD3FunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extentedFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnViewV1;
        private System.Windows.Forms.ToolStripMenuItem mnViewV2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem mnEditV1;
        private System.Windows.Forms.ToolStripMenuItem mnEditV2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem mnMultiEditV1;
        private System.Windows.Forms.ToolStripMenuItem mnRemoveTagV1;
        private System.Windows.Forms.ToolStripMenuItem mnFile2TagV1;
        private System.Windows.Forms.ToolStripMenuItem mnTag2FileV1;
        private System.Windows.Forms.ToolStripMenuItem mnMultiEditV2;
        private System.Windows.Forms.ToolStripMenuItem mnRemoveTagV2;
        private System.Windows.Forms.ToolStripMenuItem mnFile2TagV2;
        private System.Windows.Forms.ToolStripMenuItem mnTag2FileV2;
        private System.Windows.Forms.ToolStripMenuItem caseConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsb_Transfer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem mnFileOrganize;
        private System.Windows.Forms.ToolStripMenuItem mnPrefs;
        private System.Windows.Forms.ToolStripButton tsb_ToggleVer;
        private System.Windows.Forms.ToolStripMenuItem mnOptionsScanSubs;
        private System.Windows.Forms.ToolStripMenuItem mnFileMoveTo;
        private System.Windows.Forms.ToolStripMenuItem mnFileCopyTo;
        private System.Windows.Forms.ToolStripMenuItem copyVer1TagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyVer2TagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyVer12TagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spit1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem split2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator17;
        private System.Windows.Forms.ToolStripStatusLabel tsFileCount;
        private System.Windows.Forms.ToolStripStatusLabel tsCurrentPath;
        private System.Windows.Forms.ToolStripStatusLabel tsVersionShown;
        private System.Windows.Forms.ToolStripStatusLabel tsScanSubs;
        private System.Windows.Forms.ToolStripMenuItem mnViewRefresh;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
    }
}

