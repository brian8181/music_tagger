namespace music_tagger
{
    partial class EditV1Ctrl
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
            this.components = new System.ComponentModel.Container();
            this.taskPane1 = new XPExplorerBar.TaskPane();
            this.expando1 = new XPExplorerBar.Expando();
            this.taskPrevious = new XPExplorerBar.TaskItem();
            this.taskNext = new XPExplorerBar.TaskItem();
            this.taskSwapArtist_Title = new XPExplorerBar.TaskItem();
            this.taskSwapArtist_Album = new XPExplorerBar.TaskItem();
            this.taskSwapTitle_Album = new XPExplorerBar.TaskItem();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFileTag = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.ckComment = new System.Windows.Forms.CheckBox();
            this.ckGenre = new System.Windows.Forms.CheckBox();
            this.ckTrack = new System.Windows.Forms.CheckBox();
            this.ckYear = new System.Windows.Forms.CheckBox();
            this.ckAlbum = new System.Windows.Forms.CheckBox();
            this.ckTitle = new System.Windows.Forms.CheckBox();
            this.ckArtist = new System.Windows.Forms.CheckBox();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip( this.components );
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).BeginInit();
            this.taskPane1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).BeginInit();
            this.expando1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskPane1
            // 
            this.taskPane1.AutoScrollMargin = new System.Drawing.Size( 12, 12 );
            this.taskPane1.Expandos.AddRange( new XPExplorerBar.Expando[] {
            this.expando1} );
            this.taskPane1.Location = new System.Drawing.Point( 1, 2 );
            this.taskPane1.Name = "taskPane1";
            this.taskPane1.Size = new System.Drawing.Size( 210, 213 );
            this.taskPane1.TabIndex = 39;
            this.taskPane1.Text = "taskPane1";
            // 
            // expando1
            // 
            this.expando1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.expando1.ExpandedHeight = 160;
            this.expando1.Font = new System.Drawing.Font( "Tahoma", 8.25F );
            this.expando1.Items.AddRange( new System.Windows.Forms.Control[] {
            this.taskPrevious,
            this.taskNext,
            this.taskSwapArtist_Title,
            this.taskSwapArtist_Album,
            this.taskSwapTitle_Album} );
            this.expando1.Location = new System.Drawing.Point( 12, 12 );
            this.expando1.Name = "expando1";
            this.expando1.Size = new System.Drawing.Size( 186, 160 );
            this.expando1.TabIndex = 0;
            this.expando1.Text = "Commands";
            // 
            // taskPrevious
            // 
            this.taskPrevious.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskPrevious.BackColor = System.Drawing.Color.Transparent;
            this.taskPrevious.Image = null;
            this.taskPrevious.Location = new System.Drawing.Point( 16, 36 );
            this.taskPrevious.Name = "taskPrevious";
            this.taskPrevious.Size = new System.Drawing.Size( 119, 19 );
            this.taskPrevious.TabIndex = 0;
            this.taskPrevious.Text = "Previous File";
            this.taskPrevious.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskPrevious.UseVisualStyleBackColor = false;
            this.taskPrevious.Click += new System.EventHandler( this.taskPrevious_Click );
            // 
            // taskNext
            // 
            this.taskNext.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskNext.BackColor = System.Drawing.Color.Transparent;
            this.taskNext.Image = null;
            this.taskNext.Location = new System.Drawing.Point( 16, 60 );
            this.taskNext.Name = "taskNext";
            this.taskNext.Size = new System.Drawing.Size( 119, 19 );
            this.taskNext.TabIndex = 1;
            this.taskNext.Text = "Next File";
            this.taskNext.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskNext.UseVisualStyleBackColor = false;
            this.taskNext.Click += new System.EventHandler( this.taskNext_Click );
            // 
            // taskSwapArtist_Title
            // 
            this.taskSwapArtist_Title.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskSwapArtist_Title.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapArtist_Title.Image = null;
            this.taskSwapArtist_Title.Location = new System.Drawing.Point( 16, 84 );
            this.taskSwapArtist_Title.Name = "taskSwapArtist_Title";
            this.taskSwapArtist_Title.Size = new System.Drawing.Size( 119, 19 );
            this.taskSwapArtist_Title.TabIndex = 2;
            this.taskSwapArtist_Title.Text = "Swap Artist-Title";
            this.taskSwapArtist_Title.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapArtist_Title.UseVisualStyleBackColor = false;
            this.taskSwapArtist_Title.Click += new System.EventHandler( this.taskSwapArtist_Title_Click );
            // 
            // taskSwapArtist_Album
            // 
            this.taskSwapArtist_Album.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskSwapArtist_Album.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapArtist_Album.Image = null;
            this.taskSwapArtist_Album.Location = new System.Drawing.Point( 16, 108 );
            this.taskSwapArtist_Album.Name = "taskSwapArtist_Album";
            this.taskSwapArtist_Album.Size = new System.Drawing.Size( 119, 19 );
            this.taskSwapArtist_Album.TabIndex = 3;
            this.taskSwapArtist_Album.Text = "Swap Artist-Album";
            this.taskSwapArtist_Album.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapArtist_Album.UseVisualStyleBackColor = false;
            this.taskSwapArtist_Album.Click += new System.EventHandler( this.taskSwapArtist_Album_Click );
            // 
            // taskSwapTitle_Album
            // 
            this.taskSwapTitle_Album.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.taskSwapTitle_Album.BackColor = System.Drawing.Color.Transparent;
            this.taskSwapTitle_Album.Image = null;
            this.taskSwapTitle_Album.Location = new System.Drawing.Point( 16, 132 );
            this.taskSwapTitle_Album.Name = "taskSwapTitle_Album";
            this.taskSwapTitle_Album.Size = new System.Drawing.Size( 119, 19 );
            this.taskSwapTitle_Album.TabIndex = 4;
            this.taskSwapTitle_Album.Text = "Swap Title-Album";
            this.taskSwapTitle_Album.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.taskSwapTitle_Album.UseVisualStyleBackColor = false;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point( 307, 190 );
            this.txtComment.MaxLength = 30;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size( 317, 20 );
            this.txtComment.TabIndex = 6;
            this.txtComment.TextChanged += new System.EventHandler( this.txtComment_TextChanged );
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point( 307, 143 );
            this.txtTrack.MaxLength = 2;
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size( 100, 20 );
            this.txtTrack.TabIndex = 4;
            this.txtTrack.TextChanged += new System.EventHandler( this.txtTrack_TextChanged );
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point( 307, 120 );
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size( 100, 20 );
            this.txtYear.TabIndex = 3;
            this.txtYear.TextChanged += new System.EventHandler( this.txtYear_TextChanged );
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point( 307, 97 );
            this.txtAlbum.MaxLength = 30;
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size( 317, 20 );
            this.txtAlbum.TabIndex = 2;
            this.txtAlbum.TextChanged += new System.EventHandler( this.txtAlbum_TextChanged );
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 225, 123 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 32, 13 );
            this.label4.TabIndex = 26;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 224, 100 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 39, 13 );
            this.label3.TabIndex = 25;
            this.label3.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 224, 78 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 30, 13 );
            this.label2.TabIndex = 24;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 225, 53 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 33, 13 );
            this.label1.TabIndex = 23;
            this.label1.Text = "Artist:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point( 307, 74 );
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size( 317, 20 );
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler( this.txtTitle_TextChanged );
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point( 225, 193 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 54, 13 );
            this.label7.TabIndex = 29;
            this.label7.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 225, 169 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 39, 13 );
            this.label6.TabIndex = 28;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 225, 146 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 78, 13 );
            this.label5.TabIndex = 27;
            this.label5.Text = "Track Number:";
            // 
            // lblFileTag
            // 
            this.lblFileTag.AutoSize = true;
            this.lblFileTag.Location = new System.Drawing.Point( 224, 2 );
            this.lblFileTag.Name = "lblFileTag";
            this.lblFileTag.Size = new System.Drawing.Size( 71, 13 );
            this.lblFileTag.TabIndex = 40;
            this.lblFileTag.Text = "Selected File:";
            this.lblFileTag.Visible = false;
            // 
            // lblFile
            // 
            this.lblFile.AutoEllipsis = true;
            this.lblFile.Location = new System.Drawing.Point( 225, 24 );
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size( 420, 13 );
            this.lblFile.TabIndex = 41;
            this.lblFile.Text = "file...";
            this.toolTip.SetToolTip( this.lblFile, "current path" );
            this.lblFile.Visible = false;
            // 
            // ckComment
            // 
            this.ckComment.AutoSize = true;
            this.ckComment.Location = new System.Drawing.Point( 630, 193 );
            this.ckComment.Name = "ckComment";
            this.ckComment.Size = new System.Drawing.Size( 15, 14 );
            this.ckComment.TabIndex = 13;
            this.ckComment.UseVisualStyleBackColor = true;
            this.ckComment.Visible = false;
            // 
            // ckGenre
            // 
            this.ckGenre.AutoSize = true;
            this.ckGenre.Location = new System.Drawing.Point( 630, 169 );
            this.ckGenre.Name = "ckGenre";
            this.ckGenre.Size = new System.Drawing.Size( 15, 14 );
            this.ckGenre.TabIndex = 12;
            this.ckGenre.UseVisualStyleBackColor = true;
            this.ckGenre.Visible = false;
            // 
            // ckTrack
            // 
            this.ckTrack.AutoSize = true;
            this.ckTrack.Location = new System.Drawing.Point( 630, 146 );
            this.ckTrack.Name = "ckTrack";
            this.ckTrack.Size = new System.Drawing.Size( 15, 14 );
            this.ckTrack.TabIndex = 11;
            this.ckTrack.UseVisualStyleBackColor = true;
            this.ckTrack.Visible = false;
            // 
            // ckYear
            // 
            this.ckYear.AutoSize = true;
            this.ckYear.Location = new System.Drawing.Point( 630, 123 );
            this.ckYear.Name = "ckYear";
            this.ckYear.Size = new System.Drawing.Size( 15, 14 );
            this.ckYear.TabIndex = 10;
            this.ckYear.UseVisualStyleBackColor = true;
            this.ckYear.Visible = false;
            // 
            // ckAlbum
            // 
            this.ckAlbum.AutoSize = true;
            this.ckAlbum.Location = new System.Drawing.Point( 630, 99 );
            this.ckAlbum.Name = "ckAlbum";
            this.ckAlbum.Size = new System.Drawing.Size( 15, 14 );
            this.ckAlbum.TabIndex = 9;
            this.ckAlbum.UseVisualStyleBackColor = true;
            this.ckAlbum.Visible = false;
            // 
            // ckTitle
            // 
            this.ckTitle.AutoSize = true;
            this.ckTitle.Location = new System.Drawing.Point( 630, 77 );
            this.ckTitle.Name = "ckTitle";
            this.ckTitle.Size = new System.Drawing.Size( 15, 14 );
            this.ckTitle.TabIndex = 8;
            this.ckTitle.UseVisualStyleBackColor = true;
            this.ckTitle.Visible = false;
            // 
            // ckArtist
            // 
            this.ckArtist.AutoSize = true;
            this.ckArtist.Location = new System.Drawing.Point( 630, 53 );
            this.ckArtist.Name = "ckArtist";
            this.ckArtist.Size = new System.Drawing.Size( 15, 14 );
            this.ckArtist.TabIndex = 7;
            this.ckArtist.UseVisualStyleBackColor = true;
            this.ckArtist.Visible = false;
            // 
            // txtArtists
            // 
            this.txtArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtArtists.Location = new System.Drawing.Point( 307, 50 );
            this.txtArtists.MaxLength = 30;
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size( 317, 20 );
            this.txtArtists.TabIndex = 0;
            this.txtArtists.DoubleClick += new System.EventHandler( this.txtArtist_DoubleClick );
            this.txtArtists.TextChanged += new System.EventHandler( this.txtArtist_TextChanged );
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange( new object[] {
            "",
            "Acid",
            "Acid Jazz",
            "Acid Punk",
            "Alternative",
            "AlternRock",
            "Ambient",
            "Bass",
            "Blues ",
            "Cabaret",
            "Christian Rap",
            "Classic Rock",
            "Classical",
            "Comedy",
            "Country",
            "Cult",
            "Dance",
            "Darkwave",
            "Disco",
            "Dream",
            "Electronic",
            "Ethnic",
            "Euro-Techno",
            "Eurodance",
            "Fusion",
            "Game",
            "Gangsta",
            "Gospel",
            "Gothic",
            "Grunge",
            "Hard Rock",
            "Hip-Hop",
            "House",
            "Industrial",
            "Instrumental",
            "Instrumental Pop",
            "Instrumental Rock",
            "Jazz",
            "Jazz+Funk",
            "Jungle",
            "Lo-Fi",
            "Meditative",
            "Metal",
            "Musical",
            "Native American",
            "New Age",
            "New Wave",
            "Noise",
            "Oldies",
            "Other",
            "Polka",
            "Pop",
            "Pop-Folk",
            "Pop/Funk",
            "Pranks",
            "Psychadelic",
            "Punk",
            "R&B",
            "Rap",
            "Rave",
            "Reggae",
            "Retro",
            "Rock",
            "Rock & Roll",
            "Showtunes",
            "Ska",
            "Soul",
            "Sound Clip",
            "Soundtrack",
            "Southern Rock",
            "Space",
            "Techno",
            "Techno-Industrial",
            "Top 40",
            "Trailer",
            "Trance",
            "Tribal",
            "Trip-Hop",
            "Vocal"} );
            this.cmbGenre.Location = new System.Drawing.Point( 307, 166 );
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size( 317, 21 );
            this.cmbGenre.Sorted = true;
            this.cmbGenre.TabIndex = 42;
            this.cmbGenre.TextChanged += new System.EventHandler( this.txtGenres_TextChanged );
            // 
            // EditV1Ctrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.cmbGenre );
            this.Controls.Add( this.txtArtists );
            this.Controls.Add( this.ckComment );
            this.Controls.Add( this.ckGenre );
            this.Controls.Add( this.ckTrack );
            this.Controls.Add( this.ckYear );
            this.Controls.Add( this.ckAlbum );
            this.Controls.Add( this.ckTitle );
            this.Controls.Add( this.ckArtist );
            this.Controls.Add( this.lblFile );
            this.Controls.Add( this.lblFileTag );
            this.Controls.Add( this.taskPane1 );
            this.Controls.Add( this.txtComment );
            this.Controls.Add( this.txtTrack );
            this.Controls.Add( this.txtYear );
            this.Controls.Add( this.txtAlbum );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.txtTitle );
            this.Controls.Add( this.label7 );
            this.Controls.Add( this.label6 );
            this.Controls.Add( this.label5 );
            this.Name = "EditV1Ctrl";
            this.Size = new System.Drawing.Size( 655, 215 );
            ( (System.ComponentModel.ISupportInitialize)( this.taskPane1 ) ).EndInit();
            this.taskPane1.ResumeLayout( false );
            ( (System.ComponentModel.ISupportInitialize)( this.expando1 ) ).EndInit();
            this.expando1.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout();

        }
        #endregion

        private XPExplorerBar.TaskPane taskPane1;
        private XPExplorerBar.Expando expando1;
        private XPExplorerBar.TaskItem taskPrevious;
        private XPExplorerBar.TaskItem taskNext;
        private XPExplorerBar.TaskItem taskSwapArtist_Title;
        private XPExplorerBar.TaskItem taskSwapArtist_Album;
        private XPExplorerBar.TaskItem taskSwapTitle_Album;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.CheckBox ckComment;
        public System.Windows.Forms.CheckBox ckGenre;
        public System.Windows.Forms.CheckBox ckTrack;
        public System.Windows.Forms.CheckBox ckYear;
        public System.Windows.Forms.CheckBox ckAlbum;
        public System.Windows.Forms.CheckBox ckTitle;
        public System.Windows.Forms.CheckBox ckArtist;
        public System.Windows.Forms.Label lblFileTag;
        public System.Windows.Forms.Label lblFile;
        public System.Windows.Forms.TextBox txtComment;
        public System.Windows.Forms.TextBox txtTrack;
        public System.Windows.Forms.TextBox txtYear;
        public System.Windows.Forms.TextBox txtAlbum;
        public System.Windows.Forms.TextBox txtTitle;
        public System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ComboBox cmbGenre;
    }
}
