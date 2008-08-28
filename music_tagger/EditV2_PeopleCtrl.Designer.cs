namespace music_tagger
{
    partial class EditV2_PeopleCtrl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCommentDescriptor = new System.Windows.Forms.TextBox();
            this.commentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.encodingCol = new System.Windows.Forms.ColumnHeader();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.txtCommentDescriptor );
            this.groupBox1.Controls.Add( this.commentList );
            this.groupBox1.Controls.Add( this.cmbLanguage );
            this.groupBox1.Controls.Add( this.label12 );
            this.groupBox1.Controls.Add( this.label13 );
            this.groupBox1.Location = new System.Drawing.Point( 3, 3 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 629, 214 );
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Involved Person";
            // 
            // txtCommentDescriptor
            // 
            this.txtCommentDescriptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCommentDescriptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCommentDescriptor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCommentDescriptor.Location = new System.Drawing.Point( 95, 39 );
            this.txtCommentDescriptor.Name = "txtCommentDescriptor";
            this.txtCommentDescriptor.Size = new System.Drawing.Size( 274, 20 );
            this.txtCommentDescriptor.TabIndex = 82;
            // 
            // commentList
            // 
            this.commentList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.encodingCol} );
            this.commentList.FullRowSelect = true;
            this.commentList.GridLines = true;
            this.commentList.Location = new System.Drawing.Point( 16, 92 );
            this.commentList.Name = "commentList";
            this.commentList.Size = new System.Drawing.Size( 587, 107 );
            this.commentList.TabIndex = 81;
            this.commentList.UseCompatibleStateImageBehavior = false;
            this.commentList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decriptor";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comment";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Language";
            this.columnHeader3.Width = 100;
            // 
            // encodingCol
            // 
            this.encodingCol.Text = "Encoding";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point( 95, 65 );
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size( 274, 21 );
            this.cmbLanguage.TabIndex = 78;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point( 16, 42 );
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size( 58, 13 );
            this.label12.TabIndex = 79;
            this.label12.Text = "Descriptor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point( 16, 68 );
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size( 58, 13 );
            this.label13.TabIndex = 80;
            this.label13.Text = "Language:";
            // 
            // EditV2_PeopleCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox1 );
            this.Name = "EditV2_PeopleCtrl";
            this.Size = new System.Drawing.Size( 637, 221 );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtCommentDescriptor;
        public System.Windows.Forms.ListView commentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader encodingCol;
        public System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
