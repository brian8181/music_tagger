namespace universal_tagger
{
    partial class EditMainCtrl
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
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.lblDics = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscCount = new System.Windows.Forms.TextBox();
            this.txtTrackCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckComment = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckTrack = new System.Windows.Forms.CheckBox();
            this.ckYear = new System.Windows.Forms.CheckBox();
            this.ckGenre = new System.Windows.Forms.CheckBox();
            this.ckDisc = new System.Windows.Forms.CheckBox();
            this.ckBMP = new System.Windows.Forms.CheckBox();
            this.ckAlbum = new System.Windows.Forms.CheckBox();
            this.ckTitle = new System.Windows.Forms.CheckBox();
            this.ckArtist = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(121, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(414, 133);
            this.txtComment.TabIndex = 31;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(120, 82);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 29;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(121, 59);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(413, 20);
            this.txtAlbum.TabIndex = 28;
            this.txtAlbum.TextChanged += new System.EventHandler(this.txtAlbum_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(413, 20);
            this.txtTitle.TabIndex = 27;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Genres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Track Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Artists:";
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point(431, 81);
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size(103, 20);
            this.txtBPM.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "BPM:";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point(431, 103);
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size(35, 20);
            this.txtDisc.TabIndex = 45;
            // 
            // lblDics
            // 
            this.lblDics.AutoSize = true;
            this.lblDics.Location = new System.Drawing.Point(380, 107);
            this.lblDics.Name = "lblDics";
            this.lblDics.Size = new System.Drawing.Size(31, 13);
            this.lblDics.TabIndex = 44;
            this.lblDics.Text = "Disc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(472, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "of";
            // 
            // txtDiscCount
            // 
            this.txtDiscCount.Location = new System.Drawing.Point(500, 103);
            this.txtDiscCount.Name = "txtDiscCount";
            this.txtDiscCount.Size = new System.Drawing.Size(35, 20);
            this.txtDiscCount.TabIndex = 49;
            // 
            // txtTrackCount
            // 
            this.txtTrackCount.Location = new System.Drawing.Point(184, 104);
            this.txtTrackCount.Name = "txtTrackCount";
            this.txtTrackCount.Size = new System.Drawing.Size(35, 20);
            this.txtTrackCount.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "of";
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point(120, 104);
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size(35, 20);
            this.txtTrack.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckComment);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Location = new System.Drawing.Point(3, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 294);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // ckComment
            // 
            this.ckComment.AutoSize = true;
            this.ckComment.Location = new System.Drawing.Point(603, 22);
            this.ckComment.Name = "ckComment";
            this.ckComment.Size = new System.Drawing.Size(15, 14);
            this.ckComment.TabIndex = 87;
            this.ckComment.UseVisualStyleBackColor = true;
            this.ckComment.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckTrack);
            this.groupBox3.Controls.Add(this.ckYear);
            this.groupBox3.Controls.Add(this.ckGenre);
            this.groupBox3.Controls.Add(this.ckDisc);
            this.groupBox3.Controls.Add(this.ckBMP);
            this.groupBox3.Controls.Add(this.ckAlbum);
            this.groupBox3.Controls.Add(this.ckTitle);
            this.groupBox3.Controls.Add(this.ckArtist);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtGenres);
            this.groupBox3.Controls.Add(this.txtArtists);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbGenre);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtTrackCount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTrack);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtDiscCount);
            this.groupBox3.Controls.Add(this.txtTitle);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtAlbum);
            this.groupBox3.Controls.Add(this.txtYear);
            this.groupBox3.Controls.Add(this.txtDisc);
            this.groupBox3.Controls.Add(this.lblDics);
            this.groupBox3.Controls.Add(this.txtBPM);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(4, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(626, 178);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // ckTrack
            // 
            this.ckTrack.AutoSize = true;
            this.ckTrack.Location = new System.Drawing.Point(226, 107);
            this.ckTrack.Name = "ckTrack";
            this.ckTrack.Size = new System.Drawing.Size(15, 14);
            this.ckTrack.TabIndex = 85;
            this.ckTrack.UseVisualStyleBackColor = true;
            this.ckTrack.Visible = false;
            // 
            // ckYear
            // 
            this.ckYear.AutoSize = true;
            this.ckYear.Location = new System.Drawing.Point(226, 86);
            this.ckYear.Name = "ckYear";
            this.ckYear.Size = new System.Drawing.Size(15, 14);
            this.ckYear.TabIndex = 84;
            this.ckYear.UseVisualStyleBackColor = true;
            this.ckYear.Visible = false;
            // 
            // ckGenre
            // 
            this.ckGenre.AutoSize = true;
            this.ckGenre.Location = new System.Drawing.Point(602, 152);
            this.ckGenre.Name = "ckGenre";
            this.ckGenre.Size = new System.Drawing.Size(15, 14);
            this.ckGenre.TabIndex = 82;
            this.ckGenre.UseVisualStyleBackColor = true;
            this.ckGenre.Visible = false;
            // 
            // ckDisc
            // 
            this.ckDisc.AutoSize = true;
            this.ckDisc.Location = new System.Drawing.Point(555, 104);
            this.ckDisc.Name = "ckDisc";
            this.ckDisc.Size = new System.Drawing.Size(15, 14);
            this.ckDisc.TabIndex = 81;
            this.ckDisc.UseVisualStyleBackColor = true;
            this.ckDisc.Visible = false;
            // 
            // ckBMP
            // 
            this.ckBMP.AutoSize = true;
            this.ckBMP.Location = new System.Drawing.Point(555, 84);
            this.ckBMP.Name = "ckBMP";
            this.ckBMP.Size = new System.Drawing.Size(15, 14);
            this.ckBMP.TabIndex = 80;
            this.ckBMP.UseVisualStyleBackColor = true;
            this.ckBMP.Visible = false;
            // 
            // ckAlbum
            // 
            this.ckAlbum.AutoSize = true;
            this.ckAlbum.Location = new System.Drawing.Point(602, 63);
            this.ckAlbum.Name = "ckAlbum";
            this.ckAlbum.Size = new System.Drawing.Size(15, 14);
            this.ckAlbum.TabIndex = 79;
            this.ckAlbum.UseVisualStyleBackColor = true;
            this.ckAlbum.Visible = false;
            // 
            // ckTitle
            // 
            this.ckTitle.AutoSize = true;
            this.ckTitle.Location = new System.Drawing.Point(602, 41);
            this.ckTitle.Name = "ckTitle";
            this.ckTitle.Size = new System.Drawing.Size(15, 14);
            this.ckTitle.TabIndex = 78;
            this.ckTitle.UseVisualStyleBackColor = true;
            this.ckTitle.Visible = false;
            // 
            // ckArtist
            // 
            this.ckArtist.AutoSize = true;
            this.ckArtist.Location = new System.Drawing.Point(602, 17);
            this.ckArtist.Name = "ckArtist";
            this.ckArtist.Size = new System.Drawing.Size(15, 14);
            this.ckArtist.TabIndex = 77;
            this.ckArtist.UseVisualStyleBackColor = true;
            this.ckArtist.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Add Genre:";
            // 
            // txtGenres
            // 
            this.txtGenres.Location = new System.Drawing.Point(120, 149);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(414, 20);
            this.txtGenres.TabIndex = 75;
            // 
            // txtArtists
            // 
            this.txtArtists.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtArtists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtArtists.Location = new System.Drawing.Point(121, 17);
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size(413, 20);
            this.txtArtists.TabIndex = 74;
            this.txtArtists.DoubleClick += new System.EventHandler(this.txtArtists_DoubleClick);
            this.txtArtists.TextChanged += new System.EventHandler(this.txtArtists_TextChanged);
            // 
            // cmbGenre
            // 
            this.cmbGenre.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Blues",
            "Classic Rock",
            "Country",
            "Dance",
            "Disco",
            "Grunge",
            "Hip-Hop",
            "Jazz",
            "Metal",
            "New Age",
            "Oldies",
            "Other",
            "Pop",
            "R&B",
            "Rap",
            "Reggae",
            "Rock",
            "Techno",
            "Industrial",
            "Alternative",
            "Ska",
            "Pranks",
            "Soundtrack",
            "Euro-Techno",
            "Ambient",
            "Trip-Hop",
            "Vocal",
            "Jazz+Funk",
            "Fusion",
            "Trance",
            "Classical",
            "Instrumental",
            "Acid",
            "House",
            "Game",
            "Sound Clip",
            "Gospel",
            "Noise",
            "AlternRock",
            "Bass",
            "Soul",
            "Punk",
            "Space",
            "Meditative",
            "Instrumental Pop",
            "Instrumental Rock",
            "Ethnic",
            "Gothic",
            "Darkwave",
            "Techno-Industrial",
            "Electronic",
            "Pop-Folk",
            "Eurodance",
            "Dream",
            "Southern Rock",
            "Comedy",
            "Cult",
            "Gangsta",
            "Top 40",
            "Christian Rap",
            "Pop/Funk",
            "Jungle",
            "Native American",
            "Cabaret",
            "New Wave",
            "Psychadelic",
            "Rave",
            "Showtunes",
            "Trailer",
            "Lo-Fi",
            "Tribal",
            "Acid Punk",
            "Acid Jazz",
            "Polka",
            "Retro",
            "Musical",
            "Rock & Roll",
            "Hard Rock"});
            this.cmbGenre.Location = new System.Drawing.Point(120, 126);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(414, 21);
            this.cmbGenre.TabIndex = 65;
            this.cmbGenre.TextChanged += new System.EventHandler(this.cmbGenre_TextChanged);
            // 
            // EditMainCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditMainCtrl";
            this.Size = new System.Drawing.Size(635, 503);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDics;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtAlbum;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtBPM;
        public System.Windows.Forms.TextBox txtDisc;
        public System.Windows.Forms.TextBox txtDiscCount;
        public System.Windows.Forms.TextBox txtTrackCount;
        public System.Windows.Forms.TextBox txtTrack;
        public System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbGenre;
        public System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.CheckBox ckComment;
        private System.Windows.Forms.CheckBox ckTrack;
        private System.Windows.Forms.CheckBox ckYear;
        private System.Windows.Forms.CheckBox ckGenre;
        private System.Windows.Forms.CheckBox ckDisc;
        private System.Windows.Forms.CheckBox ckBMP;
        private System.Windows.Forms.CheckBox ckAlbum;
        private System.Windows.Forms.CheckBox ckTitle;
        private System.Windows.Forms.CheckBox ckArtist;
    }
}
