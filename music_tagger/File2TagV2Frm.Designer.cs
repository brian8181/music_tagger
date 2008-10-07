namespace music_tagger
{
    partial class File2TagV2Frm
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
            this.cmbFormat = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.fromatCtrl1 = new music_tagger.FormatCtrl();
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFormat
            // 
            this.cmbFormat.FormattingEnabled = true;
            this.cmbFormat.Location = new System.Drawing.Point( 47, 12 );
            this.cmbFormat.Name = "cmbFormat";
            this.cmbFormat.Size = new System.Drawing.Size( 395, 21 );
            this.cmbFormat.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 367, 309 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 286, 309 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 75, 23 );
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point( -1, 15 );
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size( 42, 13 );
            this.label19.TabIndex = 17;
            this.label19.Text = "Format:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point( 78, 50 );
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size( 166, 13 );
            this.label20.TabIndex = 18;
            this.label20.Text = "Number of digits on track number:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point( 250, 48 );
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size( 120, 20 );
            this.numericUpDown1.TabIndex = 20;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point( 81, 78 );
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size( 207, 17 );
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Save filename to orginal filename entry";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // fromatCtrl1
            // 
            this.fromatCtrl1.Location = new System.Drawing.Point( 2, 74 );
            this.fromatCtrl1.Name = "fromatCtrl1";
            this.fromatCtrl1.Size = new System.Drawing.Size( 440, 229 );
            this.fromatCtrl1.TabIndex = 22;
            // 
            // File2TagV2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 448, 333 );
            this.Controls.Add( this.fromatCtrl1 );
            this.Controls.Add( this.checkBox1 );
            this.Controls.Add( this.numericUpDown1 );
            this.Controls.Add( this.label20 );
            this.Controls.Add( this.label19 );
            this.Controls.Add( this.button2 );
            this.Controls.Add( this.button1 );
            this.Controls.Add( this.cmbFormat );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "File2TagV2Frm";
            this.Text = "File2TagV2Frm";
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFormat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private FormatCtrl fromatCtrl1;
    }
}