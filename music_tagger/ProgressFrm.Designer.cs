namespace music_tagger
{
    partial class ProgressFrm
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
            this.progressCtrl = new music_tagger.ProgressCtrl();
            this.SuspendLayout();
            // 
            // progressCtrl
            // 
            this.progressCtrl.Location = new System.Drawing.Point( 1, 12 );
            this.progressCtrl.Name = "progressCtrl";
            this.progressCtrl.Size = new System.Drawing.Size( 390, 98 );
            this.progressCtrl.TabIndex = 0;
            // 
            // OrgProgressFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 395, 119 );
            this.ControlBox = false;
            this.Controls.Add( this.progressCtrl );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OrgProgressFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Progress";
            this.ResumeLayout( false );

        }

        #endregion

        public ProgressCtrl progressCtrl;

    }
}