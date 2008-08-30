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
            this.txtName = new System.Windows.Forms.TextBox();
            this.personList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFunction = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.txtFunction );
            this.groupBox1.Controls.Add( this.txtName );
            this.groupBox1.Controls.Add( this.personList );
            this.groupBox1.Controls.Add( this.label12 );
            this.groupBox1.Controls.Add( this.label13 );
            this.groupBox1.Location = new System.Drawing.Point( 3, 3 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 629, 214 );
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Involved Person";
            // 
            // txtName
            // 
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtName.Location = new System.Drawing.Point( 95, 29 );
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size( 274, 20 );
            this.txtName.TabIndex = 82;
            // 
            // personList
            // 
            this.personList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2} );
            this.personList.FullRowSelect = true;
            this.personList.GridLines = true;
            this.personList.Location = new System.Drawing.Point( 16, 92 );
            this.personList.Name = "personList";
            this.personList.Size = new System.Drawing.Size( 587, 107 );
            this.personList.TabIndex = 81;
            this.personList.UseCompatibleStateImageBehavior = false;
            this.personList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 225;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Function";
            this.columnHeader2.Width = 225;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point( 16, 29 );
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size( 38, 13 );
            this.label12.TabIndex = 79;
            this.label12.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point( 16, 58 );
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size( 51, 13 );
            this.label13.TabIndex = 80;
            this.label13.Text = "Function:";
            // 
            // txtFunction
            // 
            this.txtFunction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFunction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFunction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFunction.Location = new System.Drawing.Point( 95, 58 );
            this.txtFunction.Name = "txtFunction";
            this.txtFunction.Size = new System.Drawing.Size( 274, 20 );
            this.txtFunction.TabIndex = 83;
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
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.ListView personList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtFunction;
    }
}
