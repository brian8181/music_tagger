namespace music_tagger
{
    partial class EditListFrm
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
            this.editListCtrl = new music_tagger.EditListCtrl();
            this.SuspendLayout();
            // 
            // editListCtrl
            // 
            this.editListCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editListCtrl.Location = new System.Drawing.Point( 0, 0 );
            this.editListCtrl.Name = "editListCtrl";
            this.editListCtrl.Size = new System.Drawing.Size( 222, 132 );
            this.editListCtrl.TabIndex = 0;
            // 
            // EditListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 222, 132 );
            this.Controls.Add( this.editListCtrl );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditListFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditListFrm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.EditListFrm_FormClosing );
            this.ResumeLayout( false );

        }

        #endregion

        private EditListCtrl editListCtrl;
    }
}