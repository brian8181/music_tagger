namespace music_tagger
{
    partial class TransferFrm
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
            this.rbTarnsferV1V2 = new System.Windows.Forms.RadioButton();
            this.rbTarnsferV2V1 = new System.Windows.Forms.RadioButton();
            this.ckArtist = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCommentDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckOverwrite = new System.Windows.Forms.CheckBox();
            this.ckTitle = new System.Windows.Forms.CheckBox();
            this.ckYear = new System.Windows.Forms.CheckBox();
            this.ckTrack = new System.Windows.Forms.CheckBox();
            this.ckGenre = new System.Windows.Forms.CheckBox();
            this.ckAlbum = new System.Windows.Forms.CheckBox();
            this.ckComment = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbTarnsferV1V2
            // 
            this.rbTarnsferV1V2.AutoSize = true;
            this.rbTarnsferV1V2.Checked = true;
            this.rbTarnsferV1V2.Location = new System.Drawing.Point( 13, 28 );
            this.rbTarnsferV1V2.Name = "rbTarnsferV1V2";
            this.rbTarnsferV1V2.Size = new System.Drawing.Size( 160, 17 );
            this.rbTarnsferV1V2.TabIndex = 0;
            this.rbTarnsferV1V2.TabStop = true;
            this.rbTarnsferV1V2.Text = "Transfer Tag Ver. 1 -> Ver. 2";
            this.rbTarnsferV1V2.UseVisualStyleBackColor = true;
            // 
            // rbTarnsferV2V1
            // 
            this.rbTarnsferV2V1.AutoSize = true;
            this.rbTarnsferV2V1.Location = new System.Drawing.Point( 215, 28 );
            this.rbTarnsferV2V1.Name = "rbTarnsferV2V1";
            this.rbTarnsferV2V1.Size = new System.Drawing.Size( 160, 17 );
            this.rbTarnsferV2V1.TabIndex = 1;
            this.rbTarnsferV2V1.TabStop = true;
            this.rbTarnsferV2V1.Text = "Transfer Tag Ver. 2 -> Ver. 1";
            this.rbTarnsferV2V1.UseVisualStyleBackColor = true;
            // 
            // ckArtist
            // 
            this.ckArtist.AutoSize = true;
            this.ckArtist.Location = new System.Drawing.Point( 13, 24 );
            this.ckArtist.Name = "ckArtist";
            this.ckArtist.Size = new System.Drawing.Size( 49, 17 );
            this.ckArtist.TabIndex = 2;
            this.ckArtist.Text = "Artist";
            this.ckArtist.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.txtCommentDesc );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Controls.Add( this.ckOverwrite );
            this.groupBox1.Controls.Add( this.ckTitle );
            this.groupBox1.Controls.Add( this.ckYear );
            this.groupBox1.Controls.Add( this.ckTrack );
            this.groupBox1.Controls.Add( this.ckGenre );
            this.groupBox1.Controls.Add( this.ckAlbum );
            this.groupBox1.Controls.Add( this.ckComment );
            this.groupBox1.Controls.Add( this.ckArtist );
            this.groupBox1.Location = new System.Drawing.Point( 2, 85 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 402, 163 );
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // txtCommentDesc
            // 
            this.txtCommentDesc.Location = new System.Drawing.Point( 117, 109 );
            this.txtCommentDesc.Name = "txtCommentDesc";
            this.txtCommentDesc.Size = new System.Drawing.Size( 258, 20 );
            this.txtCommentDesc.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 10, 112 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 105, 13 );
            this.label1.TabIndex = 10;
            this.label1.Text = "Comment Descriptor:";
            // 
            // ckOverwrite
            // 
            this.ckOverwrite.AutoSize = true;
            this.ckOverwrite.Location = new System.Drawing.Point( 10, 140 );
            this.ckOverwrite.Name = "ckOverwrite";
            this.ckOverwrite.Size = new System.Drawing.Size( 71, 17 );
            this.ckOverwrite.TabIndex = 9;
            this.ckOverwrite.Text = "Overwrite";
            this.ckOverwrite.UseVisualStyleBackColor = true;
            // 
            // ckTitle
            // 
            this.ckTitle.AutoSize = true;
            this.ckTitle.Location = new System.Drawing.Point( 278, 24 );
            this.ckTitle.Name = "ckTitle";
            this.ckTitle.Size = new System.Drawing.Size( 46, 17 );
            this.ckTitle.TabIndex = 8;
            this.ckTitle.Text = "Title";
            this.ckTitle.UseVisualStyleBackColor = true;
            // 
            // ckYear
            // 
            this.ckYear.AutoSize = true;
            this.ckYear.Location = new System.Drawing.Point( 13, 70 );
            this.ckYear.Name = "ckYear";
            this.ckYear.Size = new System.Drawing.Size( 48, 17 );
            this.ckYear.TabIndex = 7;
            this.ckYear.Text = "Year";
            this.ckYear.UseVisualStyleBackColor = true;
            // 
            // ckTrack
            // 
            this.ckTrack.AutoSize = true;
            this.ckTrack.Location = new System.Drawing.Point( 117, 47 );
            this.ckTrack.Name = "ckTrack";
            this.ckTrack.Size = new System.Drawing.Size( 94, 17 );
            this.ckTrack.TabIndex = 6;
            this.ckTrack.Text = "Track Number";
            this.ckTrack.UseVisualStyleBackColor = true;
            // 
            // ckGenre
            // 
            this.ckGenre.AutoSize = true;
            this.ckGenre.Location = new System.Drawing.Point( 278, 47 );
            this.ckGenre.Name = "ckGenre";
            this.ckGenre.Size = new System.Drawing.Size( 55, 17 );
            this.ckGenre.TabIndex = 5;
            this.ckGenre.Text = "Genre";
            this.ckGenre.UseVisualStyleBackColor = true;
            // 
            // ckAlbum
            // 
            this.ckAlbum.AutoSize = true;
            this.ckAlbum.Location = new System.Drawing.Point( 117, 24 );
            this.ckAlbum.Name = "ckAlbum";
            this.ckAlbum.Size = new System.Drawing.Size( 55, 17 );
            this.ckAlbum.TabIndex = 4;
            this.ckAlbum.Text = "Album";
            this.ckAlbum.UseVisualStyleBackColor = true;
            // 
            // ckComment
            // 
            this.ckComment.AutoSize = true;
            this.ckComment.Location = new System.Drawing.Point( 13, 47 );
            this.ckComment.Name = "ckComment";
            this.ckComment.Size = new System.Drawing.Size( 70, 17 );
            this.ckComment.TabIndex = 3;
            this.ckComment.Text = "Comment";
            this.ckComment.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.rbTarnsferV2V1 );
            this.groupBox2.Controls.Add( this.rbTarnsferV1V2 );
            this.groupBox2.Location = new System.Drawing.Point( 2, 12 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 402, 67 );
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transfer From / To";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 329, 254 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "&Cancle";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point( 251, 254 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
            // 
            // TransferFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 407, 281 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Name = "TransferFrm";
            this.Text = "TransferFrm";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTarnsferV1V2;
        private System.Windows.Forms.RadioButton rbTarnsferV2V1;
        private System.Windows.Forms.CheckBox ckArtist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckOverwrite;
        private System.Windows.Forms.CheckBox ckTitle;
        private System.Windows.Forms.CheckBox ckYear;
        private System.Windows.Forms.CheckBox ckTrack;
        private System.Windows.Forms.CheckBox ckGenre;
        private System.Windows.Forms.CheckBox ckAlbum;
        private System.Windows.Forms.CheckBox ckComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCommentDesc;
    }
}