namespace universal_tagger
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressCtrl = new universal_tagger.Threading.ProgressCtrl();
            this.SuspendLayout();
            // 
            // progressCtrl
            // 
            this.progressCtrl.BackColor = System.Drawing.SystemColors.Control;
            this.progressCtrl.Location = new System.Drawing.Point(3, 3);
            this.progressCtrl.Name = "progressCtrl";
            this.progressCtrl.Size = new System.Drawing.Size(452, 78);
            this.progressCtrl.TabIndex = 0;
            // 
            // ProgressFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 84);
            this.Controls.Add(this.progressCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProgressFrm";
            this.Text = "ProgressFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private universal_tagger.Threading.ProgressCtrl progressCtrl;
    }
}