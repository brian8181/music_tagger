namespace music_tagger
{
    partial class EditListCtrl
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
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point( 162, 110 );
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size( 58, 20 );
            this.btnDown.TabIndex = 75;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler( this.btnDown_Click );
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point( 162, 53 );
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size( 58, 20 );
            this.btnUp.TabIndex = 74;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler( this.btnUp_Click );
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point( 162, 1 );
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size( 58, 20 );
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler( this.btnAdd_Click );
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point( 162, 27 );
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size( 58, 20 );
            this.btnRemove.TabIndex = 72;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler( this.btnRemove_Click );
            // 
            // cmb
            // 
            this.cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmb.FormattingEnabled = true;
            this.cmb.Location = new System.Drawing.Point( 0, 0 );
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size( 156, 138 );
            this.cmb.TabIndex = 71;
            // 
            // EditListCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.btnDown );
            this.Controls.Add( this.btnUp );
            this.Controls.Add( this.btnAdd );
            this.Controls.Add( this.btnRemove );
            this.Controls.Add( this.cmb );
            this.Name = "EditListCtrl";
            this.Size = new System.Drawing.Size( 222, 139 );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        public System.Windows.Forms.ComboBox cmb;

    }
}
