namespace music_tagger
{
    partial class EditV2_RatingCtrl
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
            this.ckComment = new System.Windows.Forms.CheckBox();
            this.btnTopComment = new System.Windows.Forms.Button();
            this.ratingList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnRemoveComment = new System.Windows.Forms.Button();
            this.udRating = new System.Windows.Forms.NumericUpDown();
            this.udCounter = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // ckComment
            // 
            this.ckComment.AutoSize = true;
            this.ckComment.Location = new System.Drawing.Point(617, 97);
            this.ckComment.Name = "ckComment";
            this.ckComment.Size = new System.Drawing.Size(15, 14);
            this.ckComment.TabIndex = 91;
            this.ckComment.UseVisualStyleBackColor = true;
            this.ckComment.Visible = false;
            // 
            // btnTopComment
            // 
            this.btnTopComment.Location = new System.Drawing.Point(6, 206);
            this.btnTopComment.Name = "btnTopComment";
            this.btnTopComment.Size = new System.Drawing.Size(59, 20);
            this.btnTopComment.TabIndex = 90;
            this.btnTopComment.Text = "Top";
            this.btnTopComment.UseVisualStyleBackColor = true;
            this.btnTopComment.Click += new System.EventHandler(this.btnTopComment_Click);
            // 
            // ratingList
            // 
            this.ratingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ratingList.FullRowSelect = true;
            this.ratingList.GridLines = true;
            this.ratingList.Location = new System.Drawing.Point(3, 97);
            this.ratingList.Name = "ratingList";
            this.ratingList.Size = new System.Drawing.Size(608, 107);
            this.ratingList.TabIndex = 88;
            this.ratingList.UseCompatibleStateImageBehavior = false;
            this.ratingList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Email";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rating";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Play Count";
            this.columnHeader3.Width = 150;
            // 
            // btnRemoveComment
            // 
            this.btnRemoveComment.Location = new System.Drawing.Point(71, 206);
            this.btnRemoveComment.Name = "btnRemoveComment";
            this.btnRemoveComment.Size = new System.Drawing.Size(59, 20);
            this.btnRemoveComment.TabIndex = 89;
            this.btnRemoveComment.Text = "Remove";
            this.btnRemoveComment.UseVisualStyleBackColor = true;
            this.btnRemoveComment.Click += new System.EventHandler(this.btnRemoveComment_Click);
            // 
            // udRating
            // 
            this.udRating.Location = new System.Drawing.Point(116, 30);
            this.udRating.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.udRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.udRating.Name = "udRating";
            this.udRating.Size = new System.Drawing.Size(120, 20);
            this.udRating.TabIndex = 92;
            this.udRating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // udCounter
            // 
            this.udCounter.Location = new System.Drawing.Point(116, 56);
            this.udCounter.Name = "udCounter";
            this.udCounter.Size = new System.Drawing.Size(120, 20);
            this.udCounter.TabIndex = 93;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(325, 20);
            this.txtEmail.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "User email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Play counter:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(552, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 20);
            this.btnAdd.TabIndex = 99;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EditV2_RatingCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.udCounter);
            this.Controls.Add(this.udRating);
            this.Controls.Add(this.ckComment);
            this.Controls.Add(this.btnTopComment);
            this.Controls.Add(this.ratingList);
            this.Controls.Add(this.btnRemoveComment);
            this.Name = "EditV2_RatingCtrl";
            this.Size = new System.Drawing.Size(635, 229);
            ((System.ComponentModel.ISupportInitialize)(this.udRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckComment;
        private System.Windows.Forms.Button btnTopComment;
        public System.Windows.Forms.ListView ratingList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnRemoveComment;
        private System.Windows.Forms.NumericUpDown udRating;
        private System.Windows.Forms.NumericUpDown udCounter;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
    }
}
