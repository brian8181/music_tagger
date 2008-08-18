namespace music_tagger
{
    partial class EditV2_PictureCtrl
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.commentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox ) ).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point( 430, 12 );
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size( 175, 175 );
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 3, 18 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 94, 13 );
            this.label1.TabIndex = 1;
            this.label1.Text = "Picture Descriptor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 3, 44 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 70, 13 );
            this.label2.TabIndex = 2;
            this.label2.Text = "Picture Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 3, 73 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 79, 13 );
            this.label3.TabIndex = 3;
            this.label3.Text = "Path to picture:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point( 103, 41 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size( 305, 21 );
            this.comboBox1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point( 103, 68 );
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size( 305, 20 );
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point( 103, 15 );
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size( 305, 20 );
            this.textBox2.TabIndex = 10;
            // 
            // commentList
            // 
            this.commentList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3} );
            this.commentList.GridLines = true;
            this.commentList.Location = new System.Drawing.Point( 3, 211 );
            this.commentList.Name = "commentList";
            this.commentList.Size = new System.Drawing.Size( 609, 296 );
            this.commentList.TabIndex = 58;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point( 94, 164 );
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size( 75, 23 );
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point( 175, 164 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 75, 23 );
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point( 256, 164 );
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size( 75, 23 );
            this.btnImport.TabIndex = 61;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point( 337, 164 );
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size( 75, 23 );
            this.btnExtract.TabIndex = 62;
            this.btnExtract.Text = "&Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point( 103, 98 );
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size( 122, 17 );
            this.checkBox1.TabIndex = 63;
            this.checkBox1.Text = "Save Picture To File";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point( 103, 121 );
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size( 112, 17 );
            this.checkBox2.TabIndex = 64;
            this.checkBox2.Text = "Use Relative Path";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // EditV2_PictureCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.checkBox2 );
            this.Controls.Add( this.checkBox1 );
            this.Controls.Add( this.btnExtract );
            this.Controls.Add( this.btnImport );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.btnAdd );
            this.Controls.Add( this.commentList );
            this.Controls.Add( this.textBox2 );
            this.Controls.Add( this.textBox1 );
            this.Controls.Add( this.comboBox1 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.pictureBox );
            this.Name = "EditV2_PictureCtrl";
            this.Size = new System.Drawing.Size( 615, 510 );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListView commentList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
