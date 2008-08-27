using System;
using System.Collections.Generic;
using System.Text;
using TagLib.Id3v2;

namespace music_tagger
{
    class TagExt
    {
        public TagLib.Id3v2.Tag tag = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tag"></param>
        public TagExt( TagLib.Id3v2.Tag tag )
        {
            this.tag = tag;
        }
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
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string GetText( string code )
        {
            TextInformationFrame frame = GetTextFrame( code );
            if(frame != null && frame.Text.Length > 0)
            {
                return frame.Text[0];
            }
            return string.Empty;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public void SetText(string code, string text)
        {
            if(text != null)
            {
                TextInformationFrame frame = GetTextFrame( code, true );
                if(frame != null && frame.Text.Length > 0)
                {
                    // todo check for multi!!
                    frame.Text = new string[1] { text };
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public TextInformationFrame GetTextFrame( string code )
        {
            return GetTextFrame( code, false );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="code"></param>
        /// <param name="create"></param>
        /// <returns></returns>
        public TextInformationFrame GetTextFrame( string code, bool create )
        {
            return TextInformationFrame.Get( tag, code, create );
        }
    }
}
