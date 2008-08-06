namespace music_tagger
{
    partial class EditV1Ctrl
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
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.taskPrevious = new XPExplorerBar.TaskItem();
            this.taskNext = new XPExplorerBar.TaskItem();
            this.taskItem3 = new XPExplorerBar.TaskItem();
            this.taskItem4 = new XPExplorerBar.TaskItem();
            this.taskItem5 = new XPExplorerBar.TaskItem();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
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
            this.taskPane1.Location = new System.Drawing.Point( 1, 2 );
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size( 210, 281 );
            this.taskPane1.TabIndex = 39;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.expando1.ExpandedHeight = 200;
            this.expando1.Font = new System.Drawing.Font( "Tahoma", 8.25F );
            this.expando1.Items.AddRange( new System.Windows.Forms.Control[] {
            this.taskPrevious,
            this.taskNext,
            this.taskItem3,
            this.taskItem4,
            this.taskItem5} );
            this.expando1.Location = new System.Drawing.Point( 12, 12 );
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size( 186, 200 );
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Commands";
            // 
            // taskPrevious
            // 
            this.taskPrevious.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskPrevious.BackColor = System.Drawing.Color.Transparent;
            this.taskPrevious.Image = null;
            this.taskPrevious.Location = new System.Drawing.Point( 16, 36 );
            this.taskPrevious.Name = "taskPrevious";
            this.taskPrevious.Size = new System.Drawing.Size( 119, 19 );
            this.taskPrevious.TabIndex = 0;
            this.taskPrevious.Text = "Previous File";
            this.taskPrevious.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPrevious.UseVisualStyleBackColor = false;
            // 
            // taskNext
            // 
            this.taskNext.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskNext.BackColor = System.Drawing.Color.Transparent;
            this.taskNext.Image = null;
            this.taskNext.Location = new System.Drawing.Point( 16, 60 );
            this.taskNext.Name = "taskNext";
            this.taskNext.Size = new System.Drawing.Size( 119, 19 );
            this.taskNext.TabIndex = 1;
            this.taskNext.Text = "Next File";
            this.taskNext.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskNext.UseVisualStyleBackColor = false;
            // 
            // taskItem3
            // 
            this.taskItem3.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskItem3.BackColor = System.Drawing.Color.Transparent;
            this.taskItem3.Image = null;
            this.taskItem3.Location = new System.Drawing.Point( 16, 84 );
            this.taskItem3.Name = "taskItem3";
            this.taskItem3.Size = new System.Drawing.Size( 119, 19 );
            this.taskItem3.TabIndex = 2;
            this.taskItem3.Text = "Swap Artist-Title";
            this.taskItem3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem3.UseVisualStyleBackColor = false;
            // 
            // taskItem4
            // 
            this.taskItem4.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskItem4.BackColor = System.Drawing.Color.Transparent;
            this.taskItem4.Image = null;
            this.taskItem4.Location = new System.Drawing.Point( 16, 108 );
            this.taskItem4.Name = "taskItem4";
            this.taskItem4.Size = new System.Drawing.Size( 119, 19 );
            this.taskItem4.TabIndex = 3;
            this.taskItem4.Text = "Swap Artist-Album";
            this.taskItem4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem4.UseVisualStyleBackColor = false;
            // 
            // taskItem5
            // 
            this.taskItem5.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskItem5.BackColor = System.Drawing.Color.Transparent;
            this.taskItem5.Image = null;
            this.taskItem5.Location = new System.Drawing.Point( 16, 132 );
            this.taskItem5.Name = "taskItem5";
            this.taskItem5.Size = new System.Drawing.Size( 119, 19 );
            this.taskItem5.TabIndex = 4;
            this.taskItem5.Text = "Swap Title-Album";
            this.taskItem5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskItem5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 550, 260 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 75, 23 );
            this.button2.TabIndex = 38;
            this.button2.Text = "&OK";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point( 308, 198 );
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size( 317, 21 );
            this.cmbGenre.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 469, 260 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 37;
            this.button1.Text = "&Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbArtist
            // 
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point( 308, 48 );
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size( 317, 21 );
            this.cmbArtist.TabIndex = 35;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point( 308, 228 );
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size( 317, 20 );
            this.txtComment.TabIndex = 34;
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point( 308, 171 );
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size( 100, 20 );
            this.txtTrack.TabIndex = 33;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point( 308, 140 );
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size( 100, 20 );
            this.txtYear.TabIndex = 32;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point( 308, 110 );
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size( 317, 20 );
            this.txtAlbum.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 225, 141 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 32, 13 );
            this.label4.TabIndex = 26;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 225, 111 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 39, 13 );
            this.label3.TabIndex = 25;
            this.label3.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 225, 81 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 30, 13 );
            this.label2.TabIndex = 24;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 225, 51 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 33, 13 );
            this.label1.TabIndex = 23;
            this.label1.Text = "Artist:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point( 308, 78 );
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size( 317, 20 );
            this.txtTitle.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point( 225, 231 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 54, 13 );
            this.label7.TabIndex = 29;
            this.label7.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 225, 201 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 39, 13 );
            this.label6.TabIndex = 28;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 225, 171 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 78, 13 );
            this.label5.TabIndex = 27;
            this.label5.Text = "Track Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point( 224, 14 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 71, 13 );
            this.label8.TabIndex = 40;
            this.label8.Text = "Selected File:";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point( 305, 14 );
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size( 29, 13 );
            this.lblFile.TabIndex = 41;
            this.lblFile.Text = "file...";
            // 
            // EditV1Ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.lblFile );
            this.Controls.Add( this.label8 );
            this.Controls.Add( this.taskPane1 );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.cmbGenre );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.cmbArtist );
            this.Controls.Add( this.txtComment );
            this.Controls.Add( this.txtTrack );
            this.Controls.Add( this.txtYear );
            this.Controls.Add( this.txtAlbum );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.txtTitle );
            this.Controls.Add( this.label7 );
            this.Controls.Add( this.label6 );
            this.Controls.Add( this.label5 );
            this.Name = "EditV1Ctrl";
            this.Size = new System.Drawing.Size( 632, 287 );
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).EndInit();
            this.taskPane1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).EndInit();
            this.expando1.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.TaskItem taskPrevious;
        private XPExplorerBar.TaskItem taskNext;
        private XPExplorerBar.TaskItem taskItem3;
        private XPExplorerBar.TaskItem taskItem4;
        private XPExplorerBar.TaskItem taskItem5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtTrack;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFile;
    }
}
