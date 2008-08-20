namespace music_tagger
{
    partial class ProgressCtrl
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar.Location = new System.Drawing.Point( 7, 42 );
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size( 384, 21 );
            this.progressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 4, 14 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 75, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Source File:";
            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.lblFile.Location = new System.Drawing.Point( 85, 14 );
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size( 306, 19 );
            this.lblFile.TabIndex = 2;
            this.lblFile.Text = "...";
            // 
            // ProgressCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add( this.lblFile );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.progressBar );
            this.Name = "ProgressCtrl";
            this.Size = new System.Drawing.Size( 397, 76 );
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFile;
        public System.Windows.Forms.ProgressBar progressBar;
    }
}
