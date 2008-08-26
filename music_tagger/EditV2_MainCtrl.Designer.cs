namespace music_tagger
{
    partial class EditV2_MainCtrl
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
            this.btnV1Title = new System.Windows.Forms.Button();
            this.btnV1Album = new System.Windows.Forms.Button();
            this.btnV1Year = new System.Windows.Forms.Button();
            this.btnV1Track = new System.Windows.Forms.Button();
            this.btnV1Genre = new System.Windows.Forms.Button();
            this.btnV1Comment = new System.Windows.Forms.Button();
            this.txtBPM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDisc = new System.Windows.Forms.TextBox();
            this.lblDics = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscCount = new System.Windows.Forms.TextBox();
            this.txtTrackCount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTrack = new System.Windows.Forms.TextBox();
            this.cmbCommentLang = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.commentList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.encodingCol = new System.Windows.Forms.ColumnHeader();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnRemoveComment = new System.Windows.Forms.Button();
            this.btnTopComment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCommentDescriptor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtArtists = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point( 117, 67 );
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size( 414, 86 );
            this.txtComment.TabIndex = 31;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point( 120, 82 );
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size( 100, 20 );
            this.txtYear.TabIndex = 29;
            this.txtYear.TextChanged += new System.EventHandler( this.txtYear_TextChanged );
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point( 121, 59 );
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size( 413, 20 );
            this.txtAlbum.TabIndex = 28;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point( 121, 38 );
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size( 413, 20 );
            this.txtTitle.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point( 7, 71 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 54, 13 );
            this.label7.TabIndex = 26;
            this.label7.Text = "Comment:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point( 7, 152 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 44, 13 );
            this.label6.TabIndex = 25;
            this.label6.Text = "Genres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 7, 107 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 78, 13 );
            this.label5.TabIndex = 24;
            this.label5.Text = "Track Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 6, 86 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 32, 13 );
            this.label4.TabIndex = 23;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 7, 64 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 39, 13 );
            this.label3.TabIndex = 22;
            this.label3.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 7, 42 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 30, 13 );
            this.label2.TabIndex = 21;
            this.label2.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 7, 20 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 38, 13 );
            this.label1.TabIndex = 20;
            this.label1.Text = "Artists:";
            // 
            // btnV1Title
            // 
            this.btnV1Title.Location = new System.Drawing.Point( 537, 59 );
            this.btnV1Title.Name = "btnV1Title";
            this.btnV1Title.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Title.TabIndex = 35;
            this.btnV1Title.Text = "<-- Ver 1";
            this.btnV1Title.UseVisualStyleBackColor = true;
            this.btnV1Title.Click += new System.EventHandler( this.btnV1Title_Click );
            // 
            // btnV1Album
            // 
            this.btnV1Album.Location = new System.Drawing.Point( 537, 38 );
            this.btnV1Album.Name = "btnV1Album";
            this.btnV1Album.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Album.TabIndex = 36;
            this.btnV1Album.Text = "<-- Ver 1";
            this.btnV1Album.UseVisualStyleBackColor = true;
            this.btnV1Album.Click += new System.EventHandler( this.btnV1Album_Click );
            // 
            // btnV1Year
            // 
            this.btnV1Year.Location = new System.Drawing.Point( 226, 82 );
            this.btnV1Year.Name = "btnV1Year";
            this.btnV1Year.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Year.TabIndex = 37;
            this.btnV1Year.Text = "<-- Ver 1";
            this.btnV1Year.UseVisualStyleBackColor = true;
            this.btnV1Year.Click += new System.EventHandler( this.btnV1Year_Click );
            // 
            // btnV1Track
            // 
            this.btnV1Track.Location = new System.Drawing.Point( 226, 105 );
            this.btnV1Track.Name = "btnV1Track";
            this.btnV1Track.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Track.TabIndex = 38;
            this.btnV1Track.Text = "<-- Ver 1";
            this.btnV1Track.UseVisualStyleBackColor = true;
            this.btnV1Track.Click += new System.EventHandler( this.btnV1Track_Click );
            // 
            // btnV1Genre
            // 
            this.btnV1Genre.Location = new System.Drawing.Point( 537, 148 );
            this.btnV1Genre.Name = "btnV1Genre";
            this.btnV1Genre.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Genre.TabIndex = 39;
            this.btnV1Genre.Text = "<-- Ver 1";
            this.btnV1Genre.UseVisualStyleBackColor = true;
            this.btnV1Genre.Click += new System.EventHandler( this.btnV1Genre_Click );
            // 
            // btnV1Comment
            // 
            this.btnV1Comment.Location = new System.Drawing.Point( 537, 67 );
            this.btnV1Comment.Name = "btnV1Comment";
            this.btnV1Comment.Size = new System.Drawing.Size( 59, 20 );
            this.btnV1Comment.TabIndex = 40;
            this.btnV1Comment.Text = "<-- Ver 1";
            this.btnV1Comment.UseVisualStyleBackColor = true;
            this.btnV1Comment.Click += new System.EventHandler( this.btnV1Comment_Click );
            // 
            // txtBPM
            // 
            this.txtBPM.Location = new System.Drawing.Point( 431, 81 );
            this.txtBPM.Name = "txtBPM";
            this.txtBPM.Size = new System.Drawing.Size( 103, 20 );
            this.txtBPM.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point( 380, 82 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 33, 13 );
            this.label8.TabIndex = 42;
            this.label8.Text = "BPM:";
            // 
            // txtDisc
            // 
            this.txtDisc.Location = new System.Drawing.Point( 431, 103 );
            this.txtDisc.Name = "txtDisc";
            this.txtDisc.Size = new System.Drawing.Size( 35, 20 );
            this.txtDisc.TabIndex = 45;
            // 
            // lblDics
            // 
            this.lblDics.AutoSize = true;
            this.lblDics.Location = new System.Drawing.Point( 380, 107 );
            this.lblDics.Name = "lblDics";
            this.lblDics.Size = new System.Drawing.Size( 31, 13 );
            this.lblDics.TabIndex = 44;
            this.lblDics.Text = "Disc:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point( 294, 484 );
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size( 120, 20 );
            this.numericUpDown1.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point( 122, 486 );
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size( 166, 13 );
            this.label20.TabIndex = 46;
            this.label20.Text = "Number of digits on track number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point( 472, 107 );
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size( 16, 13 );
            this.label10.TabIndex = 48;
            this.label10.Text = "of";
            // 
            // txtDiscCount
            // 
            this.txtDiscCount.Location = new System.Drawing.Point( 500, 103 );
            this.txtDiscCount.Name = "txtDiscCount";
            this.txtDiscCount.Size = new System.Drawing.Size( 35, 20 );
            this.txtDiscCount.TabIndex = 49;
            // 
            // txtTrackCount
            // 
            this.txtTrackCount.Location = new System.Drawing.Point( 184, 104 );
            this.txtTrackCount.Name = "txtTrackCount";
            this.txtTrackCount.Size = new System.Drawing.Size( 35, 20 );
            this.txtTrackCount.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point( 161, 107 );
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size( 16, 13 );
            this.label11.TabIndex = 51;
            this.label11.Text = "of";
            // 
            // txtTrack
            // 
            this.txtTrack.Location = new System.Drawing.Point( 120, 104 );
            this.txtTrack.Name = "txtTrack";
            this.txtTrack.Size = new System.Drawing.Size( 35, 20 );
            this.txtTrack.TabIndex = 50;
            // 
            // cmbCommentLang
            // 
            this.cmbCommentLang.FormattingEnabled = true;
            this.cmbCommentLang.Location = new System.Drawing.Point( 117, 40 );
            this.cmbCommentLang.Name = "cmbCommentLang";
            this.cmbCommentLang.Size = new System.Drawing.Size( 414, 21 );
            this.cmbCommentLang.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point( 6, 18 );
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size( 105, 13 );
            this.label12.TabIndex = 55;
            this.label12.Text = "Comment Descriptor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point( 6, 43 );
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size( 105, 13 );
            this.label13.TabIndex = 56;
            this.label13.Text = "Comment Language:";
            // 
            // commentList
            // 
            this.commentList.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.encodingCol} );
            this.commentList.GridLines = true;
            this.commentList.Location = new System.Drawing.Point( 117, 159 );
            this.commentList.Name = "commentList";
            this.commentList.Size = new System.Drawing.Size( 479, 107 );
            this.commentList.TabIndex = 57;
            this.commentList.UseCompatibleStateImageBehavior = false;
            this.commentList.View = System.Windows.Forms.View.Details;
            this.commentList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler( this.commentList_ItemSelectionChanged );
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
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point( 538, 93 );
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size( 59, 20 );
            this.btnAddComment.TabIndex = 62;
            this.btnAddComment.Text = "Add";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler( this.btnAddComment_Click );
            // 
            // btnRemoveComment
            // 
            this.btnRemoveComment.Location = new System.Drawing.Point( 182, 268 );
            this.btnRemoveComment.Name = "btnRemoveComment";
            this.btnRemoveComment.Size = new System.Drawing.Size( 59, 20 );
            this.btnRemoveComment.TabIndex = 61;
            this.btnRemoveComment.Text = "Remove";
            this.btnRemoveComment.UseVisualStyleBackColor = true;
            this.btnRemoveComment.Click += new System.EventHandler( this.btnRemoveComment_Click );
            // 
            // btnTopComment
            // 
            this.btnTopComment.Location = new System.Drawing.Point( 117, 268 );
            this.btnTopComment.Name = "btnTopComment";
            this.btnTopComment.Size = new System.Drawing.Size( 59, 20 );
            this.btnTopComment.TabIndex = 63;
            this.btnTopComment.Text = "Top";
            this.btnTopComment.UseVisualStyleBackColor = true;
            this.btnTopComment.Click += new System.EventHandler( this.btnTopComment_Click );
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.txtCommentDescriptor );
            this.groupBox1.Controls.Add( this.btnTopComment );
            this.groupBox1.Controls.Add( this.label7 );
            this.groupBox1.Controls.Add( this.btnAddComment );
            this.groupBox1.Controls.Add( this.commentList );
            this.groupBox1.Controls.Add( this.txtComment );
            this.groupBox1.Controls.Add( this.btnRemoveComment );
            this.groupBox1.Controls.Add( this.btnV1Comment );
            this.groupBox1.Controls.Add( this.cmbCommentLang );
            this.groupBox1.Controls.Add( this.label12 );
            this.groupBox1.Controls.Add( this.label13 );
            this.groupBox1.Location = new System.Drawing.Point( 3, 184 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 608, 294 );
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // txtCommentDescriptor
            // 
            this.txtCommentDescriptor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCommentDescriptor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCommentDescriptor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCommentDescriptor.Location = new System.Drawing.Point( 117, 14 );
            this.txtCommentDescriptor.Name = "txtCommentDescriptor";
            this.txtCommentDescriptor.Size = new System.Drawing.Size( 413, 20 );
            this.txtCommentDescriptor.TabIndex = 77;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add( this.label9 );
            this.groupBox3.Controls.Add( this.txtGenre );
            this.groupBox3.Controls.Add( this.txtArtists );
            this.groupBox3.Controls.Add( this.label6 );
            this.groupBox3.Controls.Add( this.cmbGenre );
            this.groupBox3.Controls.Add( this.btnV1Genre );
            this.groupBox3.Controls.Add( this.button4 );
            this.groupBox3.Controls.Add( this.label1 );
            this.groupBox3.Controls.Add( this.label2 );
            this.groupBox3.Controls.Add( this.txtTrackCount );
            this.groupBox3.Controls.Add( this.label3 );
            this.groupBox3.Controls.Add( this.label11 );
            this.groupBox3.Controls.Add( this.label4 );
            this.groupBox3.Controls.Add( this.txtTrack );
            this.groupBox3.Controls.Add( this.label5 );
            this.groupBox3.Controls.Add( this.txtDiscCount );
            this.groupBox3.Controls.Add( this.txtTitle );
            this.groupBox3.Controls.Add( this.label10 );
            this.groupBox3.Controls.Add( this.txtAlbum );
            this.groupBox3.Controls.Add( this.txtYear );
            this.groupBox3.Controls.Add( this.txtDisc );
            this.groupBox3.Controls.Add( this.lblDics );
            this.groupBox3.Controls.Add( this.btnV1Title );
            this.groupBox3.Controls.Add( this.txtBPM );
            this.groupBox3.Controls.Add( this.btnV1Album );
            this.groupBox3.Controls.Add( this.label8 );
            this.groupBox3.Controls.Add( this.btnV1Year );
            this.groupBox3.Controls.Add( this.btnV1Track );
            this.groupBox3.Location = new System.Drawing.Point( 4, 0 );
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size( 608, 178 );
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point( 7, 129 );
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size( 61, 13 );
            this.label9.TabIndex = 76;
            this.label9.Text = "Add Genre:";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point( 120, 149 );
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size( 414, 20 );
            this.txtGenre.TabIndex = 75;
            // 
            // txtArtists
            // 
            this.txtArtists.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtArtists.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArtists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtArtists.Location = new System.Drawing.Point( 121, 17 );
            this.txtArtists.Name = "txtArtists";
            this.txtArtists.Size = new System.Drawing.Size( 413, 20 );
            this.txtArtists.TabIndex = 74;
            this.txtArtists.DoubleClick += new System.EventHandler( this.txtArtists_DoubleClick );
            // 
            // cmbGenre
            // 
            this.cmbGenre.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange( new object[] {
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
            "Hard Rock"} );
            this.cmbGenre.Location = new System.Drawing.Point( 120, 126 );
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size( 414, 21 );
            this.cmbGenre.TabIndex = 65;
            this.cmbGenre.TextChanged += new System.EventHandler( this.cmbGenre_TextChanged );
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point( 537, 16 );
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size( 59, 20 );
            this.button4.TabIndex = 69;
            this.button4.Text = "<- Ver 1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // EditV2_MainCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add( this.groupBox3 );
            this.Controls.Add( this.groupBox1 );
            this.Controls.Add( this.numericUpDown1 );
            this.Controls.Add( this.label20 );
            this.Name = "EditV2_MainCtrl";
            this.Size = new System.Drawing.Size( 615, 510 );
            ( (System.ComponentModel.ISupportInitialize)( this.numericUpDown1 ) ).EndInit();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout( false );
            this.groupBox3.PerformLayout();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnV1Title;
        private System.Windows.Forms.Button btnV1Album;
        private System.Windows.Forms.Button btnV1Year;
        private System.Windows.Forms.Button btnV1Track;
        private System.Windows.Forms.Button btnV1Genre;
        private System.Windows.Forms.Button btnV1Comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDics;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnRemoveComment;
        private System.Windows.Forms.Button btnTopComment;
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
        public System.Windows.Forms.ListView commentList;
        public System.Windows.Forms.TextBox txtComment;
        public System.Windows.Forms.ComboBox cmbCommentLang;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.ColumnHeader encodingCol;
        public System.Windows.Forms.TextBox txtArtists;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGenre;
        public System.Windows.Forms.TextBox txtCommentDescriptor;
    }
}
