namespace universal_tagger
{
    partial class EditTagFrm
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
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.taskMain = new XPExplorerBar.TaskItem();
            this.taskDetails = new XPExplorerBar.TaskItem();
            this.taskLyrics = new XPExplorerBar.TaskItem();
            this.taskPicture = new XPExplorerBar.TaskItem();
            this.taskWeb = new XPExplorerBar.TaskItem();
            this.taskOriginal = new XPExplorerBar.TaskItem();
            this.taskPeople = new XPExplorerBar.TaskItem();
            this.taskUserDefined = new XPExplorerBar.TaskItem();
            this.taskRating = new XPExplorerBar.TaskItem();
            this.expando2 = new XPExplorerBar.Expando();
            this.taskPrevious = new XPExplorerBar.TaskItem();
            this.taskNext = new XPExplorerBar.TaskItem();
            this.taskSwapArtist_Title = new XPExplorerBar.TaskItem();
            this.taskSwapArtist_Album = new XPExplorerBar.TaskItem();
            this.taskSwapTitle_Album = new XPExplorerBar.TaskItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).BeginInit();
            this.taskPane1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).BeginInit();
            this.expando1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).BeginInit();
            this.expando2.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.taskPane1.Expandos.AddRange(new XPExplorerBar.Expando[] {
            this.expando1,
            this.expando2});
            this.taskPane1.Location = new System.Drawing.Point(0, 12);
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size(210, 529);
            this.taskPane1.TabIndex = 0;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando1.ExpandedHeight = 275;
            this.expando1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskMain,
            this.taskDetails,
            this.taskLyrics,
            this.taskPicture,
            this.taskWeb,
            this.taskOriginal,
            this.taskPeople,
            this.taskUserDefined,
            this.taskRating});
            this.expando1.Location = new System.Drawing.Point(12, 12);
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size(186, 275);
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Tag Information";
            // 
            // taskMain
            // 
            this.taskMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskMain.BackColor = System.Drawing.Color.Transparent;
            this.taskMain.Image = null;
            this.taskMain.Location = new System.Drawing.Point(13, 35);
            this.taskMain.Name = "taskMain";
            this.taskMain.Size = new System.Drawing.Size(146, 16);
            this.taskMain.TabIndex = 0;
            this.taskMain.Text = "Main";
            this.taskMain.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskMain.UseVisualStyleBackColor = false;
            this.taskMain.Click += new System.EventHandler(this.taskMain_Click);
            // 
            // taskDetails
            // 
            this.taskDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskDetails.BackColor = System.Drawing.Color.Transparent;
            this.taskDetails.Image = null;
            this.taskDetails.Location = new System.Drawing.Point(13, 58);
            this.taskDetails.Name = "taskDetails";
            this.taskDetails.Size = new System.Drawing.Size(146, 16);
            this.taskDetails.TabIndex = 1;
            this.taskDetails.Text = "Detail Information";
            this.taskDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskDetails.UseVisualStyleBackColor = false;
            this.taskDetails.Click += new System.EventHandler(this.taskDetails_Click);
            // 
            // taskLyrics
            // 
            this.taskLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskLyrics.BackColor = System.Drawing.Color.Transparent;
            this.taskLyrics.Image = null;
            this.taskLyrics.Location = new System.Drawing.Point(13, 104);
            this.taskLyrics.Name = "taskLyrics";
            this.taskLyrics.Size = new System.Drawing.Size(146, 16);
            this.taskLyrics.TabIndex = 2;
            this.taskLyrics.Text = "Lyrics";
            this.taskLyrics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskLyrics.UseVisualStyleBackColor = false;
            this.taskLyrics.Click += new System.EventHandler(this.taskLyrics_Click);
            // 
            // taskPicture
            // 
            this.taskPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPicture.BackColor = System.Drawing.Color.Transparent;
            this.taskPicture.Image = null;
            this.taskPicture.Location = new System.Drawing.Point(13, 150);
            this.taskPicture.Name = "taskPicture";
            this.taskPicture.Size = new System.Drawing.Size(146, 16);
            this.taskPicture.TabIndex = 3;
            this.taskPicture.Text = "Pictures";
            this.taskPicture.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPicture.UseVisualStyleBackColor = false;
            this.taskPicture.Click += new System.EventHandler(this.taskPicture_Click);
            // 
            // taskWeb
            // 
            this.taskWeb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskWeb.BackColor = System.Drawing.Color.Transparent;
            this.taskWeb.Image = null;
            this.taskWeb.Location = new System.Drawing.Point(13, 127);
            this.taskWeb.Name = "taskWeb";
            this.taskWeb.Size = new System.Drawing.Size(146, 16);
            this.taskWeb.TabIndex = 4;
            this.taskWeb.Text = "Web";
            this.taskWeb.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskWeb.UseVisualStyleBackColor = false;
            this.taskWeb.Click += new System.EventHandler(this.taskWeb_Click);
            // 
            // taskOriginal
            // 
            this.taskOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskOriginal.BackColor = System.Drawing.Color.Transparent;
            this.taskOriginal.Image = null;
            this.taskOriginal.Location = new System.Drawing.Point(13, 81);
            this.taskOriginal.Name = "taskOriginal";
            this.taskOriginal.Size = new System.Drawing.Size(146, 16);
            this.taskOriginal.TabIndex = 5;
            this.taskOriginal.Text = "Original Information";
            this.taskOriginal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskOriginal.UseVisualStyleBackColor = false;
            this.taskOriginal.Click += new System.EventHandler(this.taskOriginal_Click);
            // 
            // taskPeople
            // 
            this.taskPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPeople.BackColor = System.Drawing.Color.Transparent;
            this.taskPeople.Image = null;
            this.taskPeople.Location = new System.Drawing.Point(13, 172);
            this.taskPeople.Name = "taskPeople";
            this.taskPeople.Size = new System.Drawing.Size(146, 16);
            this.taskPeople.TabIndex = 6;
            this.taskPeople.Text = "Involved People";
            this.taskPeople.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPeople.UseVisualStyleBackColor = false;
            this.taskPeople.Click += new System.EventHandler(this.taskPeople_Click);
            // 
            // taskUserDefined
            // 
            this.taskUserDefined.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskUserDefined.BackColor = System.Drawing.Color.Transparent;
            this.taskUserDefined.Image = null;
            this.taskUserDefined.Location = new System.Drawing.Point(13, 194);
            this.taskUserDefined.Name = "taskUserDefined";
            this.taskUserDefined.Size = new System.Drawing.Size(146, 16);
            this.taskUserDefined.TabIndex = 7;
            this.taskUserDefined.Text = "User Defined Infromation";
            this.taskUserDefined.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskUserDefined.UseVisualStyleBackColor = false;
            this.taskUserDefined.Click += new System.EventHandler(this.taskUserDefined_Click);
            // 
            // taskRating
            // 
            this.taskRating.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskRating.BackColor = System.Drawing.Color.Transparent;
            this.taskRating.Image = null;
            this.taskRating.Location = new System.Drawing.Point(13, 216);
            this.taskRating.Name = "taskRating";
            this.taskRating.Size = new System.Drawing.Size(146, 16);
            this.taskRating.TabIndex = 8;
            this.taskRating.Text = "Ratings";
            this.taskRating.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskRating.UseVisualStyleBackColor = false;
            this.taskRating.Click += new System.EventHandler(this.taskRating_Click);
            // 
            // expando2
            // 
            this.expando2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.expando2.ExpandedHeight = 200;
            this.expando2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.expando2.Items.AddRange(new System.Windows.Forms.Control[] {
            this.taskPrevious,
            this.taskNext,
            this.taskSwapArtist_Title,
            this.taskSwapArtist_Album,
            this.taskSwapTitle_Album});
            this.expando2.Location = new System.Drawing.Point(12, 299);
            this.expando2.Name = "expando2";
            this.expando2.Size = new System.Drawing.Size(186, 200);
            this.expando2.TabIndex = 1;
            this.expando2.Text = "Commands";
            // 
            // taskPrevious
            // 
            this.taskPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPrevious.BackColor = System.Drawing.Color.Transparent;
            this.taskPrevious.Image = null;
            this.taskPrevious.Location = new System.Drawing.Point(16, 36);
            this.taskPrevious.Name = "taskPrevious";
            this.taskPrevious.Size = new System.Drawing.Size(119, 19);
            this.taskPrevious.TabIndex = 0;
            this.taskPrevious.Text = "Previous File";
            this.taskPrevious.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPrevious.UseVisualStyleBackColor = false;
            this.taskPrevious.Click += new System.EventHandler(this.taskPrevious_Click);
            // 
            // taskNext
            // 
            this.taskNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNext.BackColor = System.Drawing.Color.Transparent;
            this.taskNext.Image = null;
            this.taskNext.Location = new System.Drawing.Point(16, 60);
            this.taskNext.Name = "taskNext";
            this.taskNext.Size = new System.Drawing.Size(119, 19);
            this.taskNext.TabIndex = 1;
            this.taskNext.Text = "Next File";
            this.taskNext.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskNext.UseVisualStyleBackColor = false;
            this.taskNext.Click += new System.EventHandler(this.taskNext_Click);
            // 
            // taskSwapArtist_Title
            // 
            this.taskSwapArtist_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSwapArtist_Title.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapArtist_Title.Image = null;
            this.taskSwapArtist_Title.Location = new System.Drawing.Point(16, 84);
            this.taskSwapArtist_Title.Name = "taskSwapArtist_Title";
            this.taskSwapArtist_Title.Size = new System.Drawing.Size(119, 19);
            this.taskSwapArtist_Title.TabIndex = 2;
            this.taskSwapArtist_Title.Text = "Swap Artist-Title";
            this.taskSwapArtist_Title.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapArtist_Title.UseVisualStyleBackColor = false;
            this.taskSwapArtist_Title.Click += new System.EventHandler(this.taskSwapArtist_Title_Click);
            // 
            // taskSwapArtist_Album
            // 
            this.taskSwapArtist_Album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSwapArtist_Album.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapArtist_Album.Image = null;
            this.taskSwapArtist_Album.Location = new System.Drawing.Point(16, 108);
            this.taskSwapArtist_Album.Name = "taskSwapArtist_Album";
            this.taskSwapArtist_Album.Size = new System.Drawing.Size(119, 19);
            this.taskSwapArtist_Album.TabIndex = 3;
            this.taskSwapArtist_Album.Text = "Swap Artist-Album";
            this.taskSwapArtist_Album.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapArtist_Album.UseVisualStyleBackColor = false;
            this.taskSwapArtist_Album.Click += new System.EventHandler(this.taskSwapArtist_Album_Click);
            // 
            // taskSwapTitle_Album
            // 
            this.taskSwapTitle_Album.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.taskSwapTitle_Album.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapTitle_Album.Image = null;
            this.taskSwapTitle_Album.Location = new System.Drawing.Point(16, 132);
            this.taskSwapTitle_Album.Name = "taskSwapTitle_Album";
            this.taskSwapTitle_Album.Size = new System.Drawing.Size(119, 19);
            this.taskSwapTitle_Album.TabIndex = 4;
            this.taskSwapTitle_Album.Text = "Swap Title-Album";
            this.taskSwapTitle_Album.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapTitle_Album.UseVisualStyleBackColor = false;
            this.taskSwapTitle_Album.Click += new System.EventHandler(this.taskSwapTitle_Album_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(215, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 512);
            this.panel1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(694, 518);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(775, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditV2Frm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(852, 543);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taskPane1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditV2Frm";
            this.Text = "Edit Tag Version 2 ";
            ((System.ComponentModel.ISupportInitialize)(this.taskPane1)).EndInit();
            this.taskPane1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando1)).EndInit();
            this.expando1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expando2)).EndInit();
            this.expando2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private System.Windows.Forms.Panel panel1;
        private XPExplorerBar.TaskItem taskMain;
        private XPExplorerBar.TaskItem taskDetails;
        private XPExplorerBar.TaskItem taskLyrics;
        private XPExplorerBar.TaskItem taskPicture;
        private XPExplorerBar.Expando expando2;
        private XPExplorerBar.TaskItem taskPrevious;
        private XPExplorerBar.TaskItem taskNext;
        private XPExplorerBar.TaskItem taskSwapArtist_Title;
        private XPExplorerBar.TaskItem taskSwapArtist_Album;
        private XPExplorerBar.TaskItem taskSwapTitle_Album;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private XPExplorerBar.TaskItem taskWeb;
        private XPExplorerBar.TaskItem taskOriginal;
        private XPExplorerBar.TaskItem taskPeople;
        private XPExplorerBar.TaskItem taskUserDefined;
        private XPExplorerBar.TaskItem taskRating;
    }
}