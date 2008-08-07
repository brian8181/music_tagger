namespace music_tagger
{
    partial class EditV1Frm
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
            this.editCtrl = new music_tagger.EditV1Ctrl();
            this.SuspendLayout();
            // 
            // editCtrl
            // 
            this.editCtrl.Location = new System.Drawing.Point( 1, 0 );
            this.editCtrl.Name = "editCtrl";
            this.editCtrl.Size = new System.Drawing.Size( 630, 280 );
            this.editCtrl.TabIndex = 0;
            // 
            // EditV1Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 636, 282 );
            this.Controls.Add( this.editCtrl );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditV1Frm";
            this.Text = "Edit Version 1 Tag";
            this.ResumeLayout( false );

        }

        #endregion

        public EditV1Ctrl editCtrl;


    }
}