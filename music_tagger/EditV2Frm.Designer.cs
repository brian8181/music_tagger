namespace music_tagger
{
    partial class EditV2Frm
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
            this.panel1 = new System.Windows.Forms.Panel();
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).BeginInit();
            this.taskPane1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).BeginInit();
            this.expando1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size( 12, 12 );
            this.taskPane1.Expandos.AddRange( new XPExplorerBar.Expando[] {
            this.expando1} );
            this.taskPane1.Location = new System.Drawing.Point( 0, 12 );
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size( 210, 386 );
            this.taskPane1.TabIndex = 0;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.expando1.ExpandedHeight = 200;
            this.expando1.Font = new System.Drawing.Font( "Tahoma", 8.25F );
            this.expando1.Items.AddRange( new System.Windows.Forms.Control[] {
            this.taskMain,
            this.taskDetails,
            this.taskLyrics,
            this.taskPicture} );
            this.expando1.Location = new System.Drawing.Point( 12, 12 );
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size( 186, 200 );
            this.expando1.TabIndex = 0;
            this.expando1.Text = "expando1";
            // 
            // taskMain
            // 
            this.taskMain.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskMain.BackColor = System.Drawing.Color.Transparent;
            this.taskMain.Image = null;
            this.taskMain.Location = new System.Drawing.Point( 13, 41 );
            this.taskMain.Name = "taskMain";
            this.taskMain.Size = new System.Drawing.Size( 146, 16 );
            this.taskMain.TabIndex = 0;
            this.taskMain.Text = "Main";
            this.taskMain.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskMain.UseVisualStyleBackColor = false;
            this.taskMain.Click += new System.EventHandler( this.taskMain_Click );
            // 
            // taskDetails
            // 
            this.taskDetails.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskDetails.BackColor = System.Drawing.Color.Transparent;
            this.taskDetails.Image = null;
            this.taskDetails.Location = new System.Drawing.Point( 13, 63 );
            this.taskDetails.Name = "taskDetails";
            this.taskDetails.Size = new System.Drawing.Size( 146, 16 );
            this.taskDetails.TabIndex = 1;
            this.taskDetails.Text = "Detailed";
            this.taskDetails.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskDetails.UseVisualStyleBackColor = false;
            this.taskDetails.Click += new System.EventHandler( this.taskDetails_Click );
            // 
            // taskLyrics
            // 
            this.taskLyrics.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskLyrics.BackColor = System.Drawing.Color.Transparent;
            this.taskLyrics.Image = null;
            this.taskLyrics.Location = new System.Drawing.Point( 13, 85 );
            this.taskLyrics.Name = "taskLyrics";
            this.taskLyrics.Size = new System.Drawing.Size( 146, 16 );
            this.taskLyrics.TabIndex = 2;
            this.taskLyrics.Text = "Lyrics";
            this.taskLyrics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskLyrics.UseVisualStyleBackColor = false;
            this.taskLyrics.Click += new System.EventHandler( this.taskLyrics_Click );
            // 
            // taskPicture
            // 
            this.taskPicture.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskPicture.BackColor = System.Drawing.Color.Transparent;
            this.taskPicture.Image = null;
            this.taskPicture.Location = new System.Drawing.Point( 13, 107 );
            this.taskPicture.Name = "taskPicture";
            this.taskPicture.Size = new System.Drawing.Size( 146, 16 );
            this.taskPicture.TabIndex = 3;
            this.taskPicture.Text = "Pictures";
            this.taskPicture.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPicture.UseVisualStyleBackColor = false;
            this.taskPicture.Click += new System.EventHandler( this.taskPicture_Click );
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point( 216, 2 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 612, 510 );
            this.panel1.TabIndex = 1;
            // 
            // EditV2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 831, 515 );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.taskPane1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditV2Frm";
            this.Text = "Edit Tag Version 2 ";
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).EndInit();
            this.taskPane1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).EndInit();
            this.expando1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private System.Windows.Forms.Panel panel1;
        private XPExplorerBar.TaskItem taskMain;
        private XPExplorerBar.TaskItem taskDetails;
        private XPExplorerBar.TaskItem taskLyrics;
        private XPExplorerBar.TaskItem taskPicture;
    }
}