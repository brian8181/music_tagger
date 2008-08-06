namespace music_tagger
{
    partial class EditV2Frm
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
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.expando2 = new XPExplorerBar.Expando();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editV2_MainCtrl1 = new music_tagger.EditV2_MainCtrl();
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).BeginInit();
            this.taskPane1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.expando2 ) ).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size( 12, 12 );
            this.taskPane1.Expandos.AddRange( new XPExplorerBar.Expando[] {
            this.expando1,
            this.expando2} );
            this.taskPane1.Location = new System.Drawing.Point( 0, 12 );
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size( 210, 386 );
            this.taskPane1.TabIndex = 0;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.expando1.Font = new System.Drawing.Font( "Tahoma", 8.25F );
            this.expando1.Location = new System.Drawing.Point( 12, 12 );
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size( 186, 100 );
            this.expando1.TabIndex = 0;
            this.expando1.Text = "expando1";
            // 
            // expando2
            // 
            this.expando2.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.expando2.Font = new System.Drawing.Font( "Tahoma", 8.25F );
            this.expando2.Location = new System.Drawing.Point( 12, 124 );
            this.expando2.Name = "expando2";
            this.expando2.Size = new System.Drawing.Size( 186, 254 );
            this.expando2.TabIndex = 1;
            this.expando2.Text = "expando2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.editV2_MainCtrl1 );
            this.panel1.Location = new System.Drawing.Point( 216, 12 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 520, 499 );
            this.panel1.TabIndex = 1;
            // 
            // editV2_MainCtrl1
            // 
            this.editV2_MainCtrl1.Location = new System.Drawing.Point( 3, 3 );
            this.editV2_MainCtrl1.Name = "editV2_MainCtrl1";
            this.editV2_MainCtrl1.Size = new System.Drawing.Size( 502, 489 );
            this.editV2_MainCtrl1.TabIndex = 0;
            // 
            // EditV2Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 739, 513 );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.taskPane1 );
            this.Name = "EditV2Frm";
            this.Text = "EditV2Frm";
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).EndInit();
            this.taskPane1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.expando2 ) ).EndInit();
            this.panel1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.Expando expando2;
        private System.Windows.Forms.Panel panel1;
        private EditV2_MainCtrl editV2_MainCtrl1;
    }
}