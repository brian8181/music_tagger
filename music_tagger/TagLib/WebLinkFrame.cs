using System;
using System.Collections.Generic;
using System.Text;

namespace TagLib.Id3v2
{
    class WebLinkFrame : Frame
    {
        #region Private Fields

        /// <summary>
        ///    Contains the encoding to use for the text.
        /// </summary>
        private StringType encoding = Id3v2.Tag.DefaultEncoding;

        /// <summary>
        ///    Contains the text fields.
        /// </summary>
        private string[] text_fields = new string[0];

        /// <summary>
        ///    Contains the raw data from the frame, or <see
        ///    langword="null" /> if it has been processed.
        /// </summary>
        /// <remarks>
        ///    Rather than processing the data when the frame is loaded,
        ///    it is parsed on demand, reducing the ammount of
        ///    unnecessary conversion.
        /// </remarks>
        private ByteVector raw_data = null;

        /// <summary>
        ///    Contains the ID3v2 version of <see cref="raw_data" />.
        /// </summary>
        private byte raw_version = 0;

        #endregion

        public WebLinkFrame( ByteVector ident,
		                             StringType encoding)
			: base (ident, 4)
		{
			this.encoding = encoding;
		}

        public virtual string[] Text
        {
            get
            {
                ParseRawData();
                return (string[])text_fields.Clone();
            }
            set
            {
                raw_data = null;
                text_fields = value != null ?
                    (string[])value.Clone() :
                    new string[0];
            }
        }

        public StringType TextEncoding
        {
            get
            {
                ParseRawData();
                return encoding;
            }
            set { encoding = value; }
        }

        public static WebLinkFrame Get( Tag tag,
                                                ByteVector ident,
                                                bool create )
        {
            return Get( tag, ident, Tag.DefaultEncoding, create );
        }

        public static WebLinkFrame Get( Tag tag,
                                                ByteVector ident,
                                                StringType encoding,
                                                bool create )
        {
            if(tag == null)
                throw new ArgumentNullException( "tag" );

            if(ident == null)
                throw new ArgumentNullException( "ident" );

            if(ident.Count != 4)
                throw new ArgumentException(
                    "Identifier must be four bytes long.",
                    "ident" );

            foreach(WebLinkFrame frame in
                tag.GetFrames<WebLinkFrame>( ident ))
                return frame;

            if(!create)
                return null;

            WebLinkFrame new_frame =
                new WebLinkFrame( ident, encoding );
            tag.AddFrame( new_frame );
            return new_frame;
        }

        /// <summary>
        ///    Gets a string representation of the current instance.
        /// </summary>
        /// <returns>
        ///    A <see cref="string" /> containing the joined text.
        /// </returns>
        public override string ToString()
        {
            ParseRawData();
            return string.Join( "; ", Text );
        }

        public override ByteVector Render( byte version )
        {
            //if(version != 3 || FrameId != FrameType.TDRC)
            //    return base.Render( version );

            string text = ToString();
            if(text.Length < 10 || text[4] != '-' ||
                text[7] != '-')
                return base.Render( version );

            ByteVector output = new ByteVector();
            WebLinkFrame f = null;


            // todo


            output.Add( f.Render( version ) );
            return output;
        }

        /// <summary>
        ///    Performs the actual parsing of the raw data.
        /// </summary>
        /// <remarks>
        ///    Because of the high parsing cost and relatively low usage
        ///    of the class, <see cref="ParseFields" /> only stores the
        ///    field data so it can be parsed on demand. Whenever a
        ///    property or method is called which requires the data,
        ///    this method is called, and only on the first call does it
        ///    actually parse the data.
        /// </remarks>
        protected void ParseRawData()
        {
            if(raw_data == null)
                return;

            ByteVector data = raw_data;
            raw_data = null;

            // read the string data type (the first byte of the
            // field data)
            encoding = (StringType)data[0];
            List<string> field_list = new List<string>();

            ByteVector delim = ByteVector.TextDelimiter( encoding );

            //if(raw_version > 3 || FrameId == FrameType.TXXX)
            //{
            //    field_list.AddRange( data.ToStrings( encoding, 1 ) );
            //}
            //else if(data.Count > 1 && !data.Mid( 1,
            //    delim.Count ).Equals( delim ))
            //{
            //    string value = data.ToString( encoding, 1,
            //        data.Count - 1 );

            //    // Do a fast removal of end bytes.
            //    if(value.Length > 1 &&
            //        value[value.Length - 1] == 0)
            //        for(int i = value.Length - 1; i >= 0; i--)
            //            if(value[i] != 0)
            //            {
            //                value = value.Substring( 0, i + 1 );
            //                break;
            //            }

            //    if(FrameId == FrameType.TCOM ||
            //        FrameId == FrameType.TEXT ||
            //        FrameId == FrameType.TOLY ||
            //        FrameId == FrameType.TOPE ||
            //        FrameId == FrameType.TPE1 ||
            //        FrameId == FrameType.TPE2 ||
            //        FrameId == FrameType.TPE3 ||
            //        FrameId == FrameType.TPE4)
            //    {
            //        field_list.AddRange( value.Split( '/' ) );
            //    }
            //    else if(FrameId == FrameType.TCON)
            //    {
            //        while(value.Length > 1 && value[0] == '(')
            //        {
            //            int closing = value.IndexOf( ')' );
            //            if(closing < 0)
            //                break;

            //            string number = value.Substring( 1,
            //                    closing - 1 );

            //            field_list.Add( number );

            //            value = value.Substring(
            //                closing + 1 ).TrimStart( '/', ' ' );

                     
            //        }

            //        if(value.Length > 0)
            //            field_list.AddRange( value.Split( new char[] { '/' } ) );
            //    }
            //    else
            //    {
            //        field_list.Add( value );
            //    }
            //}

            //// Bad tags may have one or more nul characters at the
            //// end of a string, resulting in empty strings at the
            //// end of the FieldList. Strip them off.
            //while(field_list.Count != 0 &&
            //    string.IsNullOrEmpty( field_list[
            //        field_list.Count - 1] ))
            //    field_list.RemoveAt( field_list.Count - 1 );

            //text_fields = field_list.ToArray();
        }

        protected override void ParseFields( ByteVector data, byte version )
        {
            
        }

        protected override ByteVector RenderFields( byte version )
        {
            return new ByteVector();
        }
    }
}
