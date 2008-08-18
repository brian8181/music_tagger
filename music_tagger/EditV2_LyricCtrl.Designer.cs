namespace music_tagger
{
    partial class EditV2_LyricCtrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.txtDescriptor = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lyricsList = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 3, 14 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 58, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "Descriptor:";
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point( 68, 64 );
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size( 544, 237 );
            this.txtLyrics.TabIndex = 1;
            // 
            // txtDescriptor
            // 
            this.txtDescriptor.Location = new System.Drawing.Point( 68, 11 );
            this.txtDescriptor.Name = "txtDescriptor";
            this.txtDescriptor.Size = new System.Drawing.Size( 299, 20 );
            this.txtDescriptor.TabIndex = 2;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point( 68, 37 );
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size( 299, 21 );
            this.cmbLanguage.TabIndex = 3;
            // 
            // lyricsList
            // 
            this.lyricsList.Location = new System.Drawing.Point( 3, 336 );
            this.lyricsList.Name = "lyricsList";
            this.lyricsList.Size = new System.Drawing.Size( 609, 171 );
            this.lyricsList.TabIndex = 4;
            this.lyricsList.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point( 68, 307 );
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size( 75, 23 );
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point( 149, 307 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 75, 23 );
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnTop
            // 
            this.btnTop.Location = new System.Drawing.Point( 456, 307 );
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size( 75, 23 );
            this.btnTop.TabIndex = 7;
            this.btnTop.Text = "Top";
            this.btnTop.UseVisualStyleBackColor = true;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point( 537, 307 );
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size( 75, 23 );
            this.btnFile.TabIndex = 8;
            this.btnFile.Text = "From File";
            this.btnFile.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 3, 40 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 58, 13 );
            this.label2.TabIndex = 9;
            this.label2.Text = "Language:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 3, 67 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 37, 13 );
            this.label3.TabIndex = 10;
            this.label3.Text = "Lyrics:";
            // 
            // EditV2_LyricCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.btnFile );
            this.Controls.Add( this.btnTop );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.btnAdd );
            this.Controls.Add( this.lyricsList );
            this.Controls.Add( this.cmbLanguage );
            this.Controls.Add( this.txtDescriptor );
            this.Controls.Add( this.txtLyrics );
            this.Controls.Add( this.label1 );
            this.Name = "EditV2_LyricCtrl";
            this.Size = new System.Drawing.Size( 615, 510 );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.TextBox txtDescriptor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.ListView lyricsList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
