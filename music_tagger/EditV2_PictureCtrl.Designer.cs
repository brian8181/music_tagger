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
            this.cmbPicType = new System.Windows.Forms.ComboBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.pictureList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.ckInclude = new System.Windows.Forms.CheckBox();
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
            // cmbPicType
            // 
            this.cmbPicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPicType.FormattingEnabled = true;
            this.cmbPicType.Items.AddRange( new object[] {
            "Other",
            "32x32 pixels \'file icon\' (PNG only)",
            "Other file icon",
            "Cover (front)",
            "Cover (back)",
            "Leaflet page",
            "Media (e.g. lable side of CD)",
            "Lead artist/lead performer/soloist",
            "Artist/performer",
            "Conductor",
            "Band/Orchestra",
            "Composer",
            "Lyricist/text writer",
            "Recording Location",
            "During recording",
            "During performance",
            "Movie/video screen capture",
            "A bright coloured fish",
            "Illustration",
            "Band/artist logotype",
            "Publisher/Studio logotype"} );
            this.cmbPicType.Location = new System.Drawing.Point( 103, 41 );
            this.cmbPicType.Name = "cmbPicType";
            this.cmbPicType.Size = new System.Drawing.Size( 305, 21 );
            this.cmbPicType.TabIndex = 8;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point( 103, 68 );
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size( 305, 20 );
            this.txtPath.TabIndex = 9;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point( 103, 15 );
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size( 305, 20 );
            this.txtDesc.TabIndex = 10;
            // 
            // pictureList
            // 
            this.pictureList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4} );
            this.pictureList.GridLines = true;
            this.pictureList.Location = new System.Drawing.Point( 3, 211 );
            this.pictureList.Name = "pictureList";
            this.pictureList.Size = new System.Drawing.Size( 609, 296 );
            this.pictureList.TabIndex = 58;
            this.pictureList.UseCompatibleStateImageBehavior = false;
            this.pictureList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Decriptor";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Path";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Include";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point( 94, 164 );
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size( 75, 23 );
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler( this.btnAdd_Click );
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point( 175, 164 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 75, 23 );
            this.btnRemove.TabIndex = 60;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler( this.btnRemove_Click );
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point( 256, 164 );
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size( 75, 23 );
            this.btnImport.TabIndex = 61;
            this.btnImport.Text = "&Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler( this.btnImport_Click );
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point( 337, 164 );
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size( 75, 23 );
            this.btnExtract.TabIndex = 62;
            this.btnExtract.Text = "&Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler( this.btnExtract_Click );
            // 
            // ckInclude
            // 
            this.ckInclude.AutoSize = true;
            this.ckInclude.Checked = true;
            this.ckInclude.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckInclude.Enabled = false;
            this.ckInclude.Location = new System.Drawing.Point( 103, 98 );
            this.ckInclude.Name = "ckInclude";
            this.ckInclude.Size = new System.Drawing.Size( 122, 17 );
            this.ckInclude.TabIndex = 63;
            this.ckInclude.Text = "Save Picture To File";
            this.ckInclude.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
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
            this.Controls.Add( this.ckInclude );
            this.Controls.Add( this.btnExtract );
            this.Controls.Add( this.btnImport );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.btnAdd );
            this.Controls.Add( this.pictureList );
            this.Controls.Add( this.txtDesc );
            this.Controls.Add( this.txtPath );
            this.Controls.Add( this.cmbPicType );
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
        private System.Windows.Forms.ComboBox cmbPicType;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ListView pictureList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.CheckBox ckInclude;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
