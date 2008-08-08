namespace music_tagger
{
    partial class PrefFrm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add( this.tabPage1 );
            this.tabControl1.Controls.Add( this.tabPage2 );
            this.tabControl1.Controls.Add( this.tabPage3 );
            this.tabControl1.Controls.Add( this.tabPage4 );
            this.tabControl1.Controls.Add( this.tabPage5 );
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point( 0, 0 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 499, 354 );
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add( this.comboBox3 );
            this.tabPage1.Controls.Add( this.comboBox2 );
            this.tabPage1.Controls.Add( this.comboBox1 );
            this.tabPage1.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage1.Size = new System.Drawing.Size( 491, 328 );
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler( this.tabPage1_Click );
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage2.Size = new System.Drawing.Size( 491, 328 );
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Columns";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size( 491, 328 );
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FreeDB";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size( 491, 328 );
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Colors";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size( 491, 328 );
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Tools";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point( 33, 51 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size( 121, 21 );
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point( 160, 51 );
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size( 121, 21 );
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point( 287, 51 );
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size( 121, 150 );
            this.comboBox3.TabIndex = 2;
            // 
            // PrefFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 499, 354 );
            this.Controls.Add( this.tabControl1 );
            this.Name = "PrefFrm";
            this.Text = "PrefFrm";
            this.tabControl1.ResumeLayout( false );
            this.tabPage1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}