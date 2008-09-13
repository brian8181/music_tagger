namespace music_tagger
{
    partial class OrganizeFrm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ckOverwrite = new System.Windows.Forms.CheckBox();
            this.ckCopy = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbV1 = new System.Windows.Forms.RadioButton();
            this.rbV2 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.formatCtrl1 = new music_tagger.FormatCtrl();
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point( 284, 360 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler( this.btnOK_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 365, 360 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancle";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 2, 15 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 58, 13 );
            this.label1.TabIndex = 3;
            this.label1.Text = "Root Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 2, 41 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 42, 13 );
            this.label2.TabIndex = 4;
            this.label2.Text = "Format:";
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point( 70, 33 );
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size( 354, 21 );
            this.cmbFormat.TabIndex = 6;
            // 
            // txtPath
            // 
            this.txtPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtPath.Location = new System.Drawing.Point( 70, 12 );
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size( 289, 20 );
            this.txtPath.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point( 365, 10 );
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size( 58, 22 );
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler( this.btnBrowse_Click );
            // 
            // ckOverwrite
            // 
            this.ckOverwrite.AutoSize = true;
            this.ckOverwrite.Location = new System.Drawing.Point( 5, 366 );
            this.ckOverwrite.Name = "ckOverwrite";
            this.ckOverwrite.Size = new System.Drawing.Size( 71, 17 );
            this.ckOverwrite.TabIndex = 12;
            this.ckOverwrite.Text = "Overwrite";
            this.ckOverwrite.UseVisualStyleBackColor = true;
            // 
            // ckCopy
            // 
            this.ckCopy.AutoSize = true;
            this.ckCopy.Location = new System.Drawing.Point( 82, 366 );
            this.ckCopy.Name = "ckCopy";
            this.ckCopy.Size = new System.Drawing.Size( 50, 17 );
            this.ckCopy.TabIndex = 13;
            this.ckCopy.Text = "Copy";
            this.ckCopy.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point( 267, 57 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 75, 23 );
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point( 348, 57 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 75, 23 );
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler( this.btnRemove_Click );
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 73, 109 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 155, 13 );
            this.label3.TabIndex = 16;
            this.label3.Text = "Number digits in track numbers:";
            // 
            // rbV1
            // 
            this.rbV1.AutoSize = true;
            this.rbV1.Location = new System.Drawing.Point( 159, 88 );
            this.rbV1.Name = "rbV1";
            this.rbV1.Size = new System.Drawing.Size( 69, 17 );
            this.rbV1.TabIndex = 17;
            this.rbV1.TabStop = true;
            this.rbV1.Text = "Version 1";
            this.rbV1.UseVisualStyleBackColor = true;
            this.rbV1.CheckedChanged += new System.EventHandler( this.rbV1_CheckedChanged );
            // 
            // rbV2
            // 
            this.rbV2.AutoSize = true;
            this.rbV2.Location = new System.Drawing.Point( 76, 88 );
            this.rbV2.Name = "rbV2";
            this.rbV2.Size = new System.Drawing.Size( 69, 17 );
            this.rbV2.TabIndex = 18;
            this.rbV2.TabStop = true;
            this.rbV2.Text = "Version 2";
            this.rbV2.UseVisualStyleBackColor = true;
            this.rbV2.CheckedChanged += new System.EventHandler( this.rbV2_CheckedChanged );
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point( 246, 103 );
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size( 60, 20 );
            this.numericUpDown1.TabIndex = 19;
            // 
            // formatCtrl1
            // 
            this.formatCtrl1.Location = new System.Drawing.Point( 0, 126 );
            this.formatCtrl1.Name = "formatCtrl1";
            this.formatCtrl1.Size = new System.Drawing.Size( 440, 229 );
            this.formatCtrl1.TabIndex = 0;
            // 
            // OrganizeFrm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 442, 386 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.rbV1 );
            this.Controls.Add( this.rbV2 );
            this.Controls.Add( this.numericUpDown1 );
            this.Controls.Add( this.ckCopy );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.ckOverwrite );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.btnBrowse );
            this.Controls.Add( this.txtPath );
            this.Controls.Add( this.cmbFormat );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.Controls.Add( this.formatCtrl1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrganizeFrm";
            this.Text = "OrganizeFrm";
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private FormatCtrl formatCtrl1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox ckOverwrite;
        private System.Windows.Forms.CheckBox ckCopy;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbV1;
        private System.Windows.Forms.RadioButton rbV2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}