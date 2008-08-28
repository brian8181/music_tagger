namespace music_tagger
{
    partial class EditV2_UserDefinedCtrl
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
            this.txtCommentDescriptor = new System.Windows.Forms.TextBox();
            this.commentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.encodingCol = new System.Windows.Forms.ColumnHeader();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.txtCommentDescriptor );
            this.groupBox1.Controls.Add( this.commentList );
            this.groupBox1.Controls.Add( this.cmbLanguage );
            this.groupBox1.Controls.Add( this.label12 );
            this.groupBox1.Controls.Add( this.label13 );
            this.groupBox1.Location = new System.Drawing.Point( 3, 6 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 629, 214 );
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Defined Text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add( this.textBox1 );
            this.groupBox2.Controls.Add( this.listView1 );
            this.groupBox2.Controls.Add( this.comboBox1 );
            this.groupBox2.Controls.Add( this.label1 );
            this.groupBox2.Controls.Add( this.label2 );
            this.groupBox2.Location = new System.Drawing.Point( 3, 226 );
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size( 629, 214 );
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Defined Web";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point( 94, 39 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size( 275, 20 );
            this.textBox1.TabIndex = 82;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7} );
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point( 16, 92 );
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size( 587, 107 );
            this.listView1.TabIndex = 81;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Decriptor";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Comment";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Language";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Encoding";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point( 94, 65 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size( 275, 21 );
            this.comboBox1.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 16, 42 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 58, 13 );
            this.label1.TabIndex = 79;
            this.label1.Text = "Descriptor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 16, 68 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 58, 13 );
            this.label2.TabIndex = 80;
            this.label2.Text = "Language:";
            // 
            // EditV2_UserDefinedCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox2 );
            this.Controls.Add( this.groupBox1 );
            this.Name = "EditV2_UserDefinedCtrl";
            this.Size = new System.Drawing.Size( 635, 510 );
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout( false );
            this.groupBox2.PerformLayout();
            this.ResumeLayout( false );

        }

        #endregion

        public System.Windows.Forms.TextBox txtCommentDescriptor;
        public System.Windows.Forms.ListView commentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader encodingCol;
        public System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
