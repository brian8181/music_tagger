using System;
using System.Collections.Generic;
using System.Text;
using TagLib.Id3v2;

namespace music_tagger
{
    class TagV2Ext
    {
        private TagLib.Id3v2.Tag tag = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        public TagV2Ext( TagLib.Id3v2.Tag tag )
        {
            this.tag = tag;
        }

        #region Properties
        /// <summary>
        /// Original album/movie/show title
        /// </summary>
        public string TOAL
        {
            get
            {
                return GetText( "TOAL" );
            }
            set
            {
                SetText( "TOAL", value );
            }
        }
        /// <summary>
        ///  Original filename
        /// </summary>
        public string TOFN
        {
            get
            {
                return GetText( "TOFN" );
            }
            set
            {
                SetText( "TOFN", value );
            }
        }
        /// <summary>
        ///  Original lyricist(s)/text writer(s)
        /// </summary>
        public string TOLY
        {
            get
            {
                return GetText( "TOLY" );
            }
            set
            {
                SetText( "TOLY", value );
            }
        }
        /// <summary>
        /// Original artist(s)/performer(s)
        /// </summary>
        public string TOPE
        {
            get
            {
                return GetText( "TOPE" );
            }
            set
            {
                SetText( "TOPE", value );
            }
        }
        /// <summary>
        /// Original release year
        /// </summary>
        public string TORY
        {
            get
            {
                return GetText( "TORY" );
            }
            set
            {
                SetText( "TORY", value );
            }
        }
        /// <summary>
        /// File owner/licensee
        /// </summary>
        public string TOWN
        {
            get
            {
                return GetText( "TOWN" );
            }
            set
            {
                SetText( "TOWN", value );
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TDOR
        {
            get
            {
                return GetText( "TDOR" );
            }
            set
            {
                SetText( "TDOR", value );
            }
        }
        /// <summary>
        /// Publisher
        /// </summary>
        public string TPUB
        {
            get
            {
                return GetText( "TPUB" );
            }
            set
            {
                SetText( "TPUB", value );
            }
        }
        /// <summary>
        /// Lyricist/Text writer
        /// </summary>
        public string TEXT
        {
            get
            {
                return GetText( "TEXT" );
            }
            set
            {
                SetText( "TEXT", value );
            }
        }
        /// <summary>
        /// Band/orchestra/accompaniment
        /// </summary>
        public string TPE2
        {
            get
            {
                return GetText( "TPE2" );
            }
            set
            {
                SetText( "TPE2", value );
            }
        }
        /// <summary>
        /// Interpreted, remixed, or otherwise modified by
        /// </summary>
        public string TPE4
        {
            get
            {
                return GetText( "TPE4" );
            }
            set
            {
                SetText( "TPE4", value );
            }
        }
        /// <summary>
        /// Encoded by
        /// </summary>
        public string TENC
        {
            get
            {
                return GetText( "TENC" );
            }
            set
            {
                SetText( "TENC", value );
            }
        }
        /// <summary>
        /// Subtitle/Description refinement
        /// </summary>
        public string TIT3
        {
            get
            {
                return GetText( "TIT3" );
            }
            set
            {
                SetText( "TIT3", value );
            }
        }
        /// <summary>
        /// Media type
        /// </summary>
        public string TMED
        {
            get
            {
                return GetText( "TMED" );
            }
            set
            {
                SetText( "TMED", value );
            }
        }
        /// <summary>
        /// Length
        /// </summary>
        public string TLEN
        {
            get
            {
                return GetText( "TLEN" );
            }
            set
            {
                SetText( "TLEN", value );
            }
        }
        /// <summary>
        /// Commercial information
        /// </summary>
        public string WCOM
        {
            get
            {
                return GetText( "WCOM" );
            }
            set
            {
                SetText( "WCOM", value );
            }
        }
        /// <summary>
        ///  Copyright/Legal information
        /// </summary>
        public string WCOP
        {
            get
            {
                return GetText( "WCOP" );
            }
            set
            {
                SetText( "WCOP", value );
            }
        }
        /// <summary>
        ///  Official audio file webpage
        /// </summary>
        public string WOAF
        {
            get
            {
                return GetText( "WOAF" );
            }
            set
            {
                SetText( "WOAF", value );
            }
        }
        /// <summary>
        /// Official artist/performer webpage
        /// </summary>
        public string WOAR
        {
            get
            {
                return GetText( "WOAR" );
            }
            set
            {
                SetText( "WOAR", value );
            }
        }
        /// <summary>
        /// Official audio source webpage
        /// </summary>
        public string WOAS
        {
            get
            {
                return GetText( "WOAS" );
            }
            set
            {
                SetText( "WOAS", value );
            }
        }
        /// <summary>
        /// Official internet radio station homepage
        /// </summary>
        public string WORS
        {
            get
            {
                return GetText( "WORS" );
            }
            set
            {
                SetText( "WORS", value );
            }
        }
        /// <summary>
        /// Payment
        /// </summary>
        public string WPAY
        {
            get
            {
                return GetText( "WPAY" );
            }
            set
            {
                SetText( "WPAY", value );
            }
        }
        /// <summary>
        /// Publishers official webpage
        /// </summary>
        public string WPUB
        {
            get
            {
                return GetText( "WPUB" );
            }
            set
            {
                SetText( "WPUB", value );
            }
        }
        /// <summary>
        /// User defined URL link frame
        /// </summary>
        public string WXXX
        {
            get
            {
                return GetText( "WXXX" );
            }
            set
            {
                SetText( "WXXX", value );
            }
        }
        #endregion

        /// <summary>
        ///  get text from id
        /// </summary>
        /// <param name="code">the frame ifd</param>
        /// <returns></returns>
        public string GetText( string code )
        {
            if(code.StartsWith( "T" ))
            {
                TextInformationFrame frame = GetTextFrame( code );
                if(frame != null && frame.Text.Length > 0)
                {
                    return frame.Text[0];
                }
            }
            else if(code.StartsWith( "W" ))
            {
                UnknownFrame frame = GetUnknownFrame( code );
                if(frame != null)
                {
                    // todo
                    //string[] strs = frame.Data.ToStrings( TagLib.StringType.UTF8 );
                    // gets the first frame
                    return frame.Data.ToString( TagLib.StringType.UTF8, 0, frame.Data.Count - 1 );
                }
            }
            return string.Empty;
        }
        /// <summary>
        /// set text frame from id
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string code, string text)
        {
            if(text != null)
            {
                if(code.StartsWith( "T" ))
                {
                    TextInformationFrame frame = GetTextFrame( code, true );

                    // add frame
                    if(frame == null)
                    {
                        frame = new TextInformationFrame( code );
                        tag.AddFrame( frame );    
                    }

                    if(frame.Text.Length < 2) // one or zero
                    {
                        frame.Text = new string[1] { text };
                    }
                    else  // more than one
                    {
                        // add to front
                        string[] strs = new string[frame.Text.Length];
                        strs[0] = text;
                        Array.Copy( frame.Text, 1, strs, 1, frame.Text.Length - 1 );
                    }
                }
                else if(code.StartsWith( "W" ))
                {
                    UnknownFrame frame = GetUnknownFrame( code );
                    if(frame != null)
                    {
                        byte[] byts = UTF8Encoding.UTF8.GetBytes( text );
                        frame.Data = new TagLib.ByteVector( byts );
                        frame.Data.Add( (byte)0 );
                    }
                }
            }
        }
        /// <summary>
        ///  get text frame from id
        /// </summary>
        /// <param name="code">the frame id</param>
        /// <returns></returns>
        public TextInformationFrame GetTextFrame( string code )
        {
            return GetTextFrame( code, false );
        }
        /// <summary>
        /// get text frame from id
        /// </summary>
        /// <param name="code">the frame id</param>
        /// <param name="create">if true creates the frame</param>
        /// <returns></returns>
        public TextInformationFrame GetTextFrame( string code, bool create )
        {
            return TextInformationFrame.Get( tag, code, create );
        }
        /// <summary>
        ///  get text frame from id
        /// </summary>
        /// <param name="code">the frame id</param>
        /// <returns></returns>
        public UnknownFrame GetUnknownFrame( string code )
        {
            return GetUnknownFrame( code, false );
        }
        /// <summary>
        /// get text frame from id
        /// </summary>
        /// <param name="code">the frame id</param>
        /// <param name="create">if true creates the frame</param>
        /// <returns></returns>
        public UnknownFrame GetUnknownFrame( string code, bool create )
        {
            foreach(TagLib.Id3v2.UnknownFrame frame in
            ( (TagLib.Id3v2.Tag)tag ).GetFrames<TagLib.Id3v2.UnknownFrame>( code ) )
            {
                return frame;
            }

            UnknownFrame new_frame = null;
            if(create)
            {
                new_frame = new UnknownFrame( code );
                tag.AddFrame( new_frame );
            }
            return new_frame;
        }
    }
}
