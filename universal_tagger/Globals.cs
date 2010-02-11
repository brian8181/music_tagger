using System;
using System.Collections.Generic;
using System.Text;

namespace universal_tagger
{
    /// <summary>
    /// Column enumeration
    /// </summary>
    public enum Column
    {
        File,
        Path,
        Size,
        Attributes,
        Created,
        Accessed,
        Modified,
        Album,
        Artist,
        Title,
        Track,
        TrackCount,
        Disc,
        DiscCount,
        Comment,
        Year,
        Genre,
        Length
    }

    public enum Genre
    {
        Blues,
        Classic_Rock,
        Country,
        Dance,
        Disco,
        Grunge,
        Hip_Hop,
        Jazz,
        Metal,
        New_Age,
        Oldies,
        Other,
        Pop,
        R_and_B,
        Rap,
        Reggae,
        Rock,
        Techno,
        Industrial,
        Alternative,
        Ska,
        Pranks,
        Soundtrack,
        Euro_Techno,
        Ambient,
        Trip_Hop,
        Vocal,
        Jazz_Funk,
        Fusion,
        Trance,
        Classical,
        Instrumental,
        Acid,
        House,
        Game,
        Sound_Clip,
        Gospel,
        Noise,
        AlternRock,
        Bass,
        Soul,
        Punk,
        Space,
        Meditative,
        Instrumental_Pop,
        Instrumental_Rock,
        Ethnic,
        Gothic,
        Darkwave,
        Techno_Industrial,
        Electronic,
        Pop_Folk,
        Eurodance,
        Dream,
        Southern_Rock,
        Comedy,
        Cult,
        Gangsta,
        Top_40,
        Christian_Rap,
        Pop_Funk,
        Jungle,
        Native_American,
        Cabaret,
        New_Wave,
        Psychadelic,
        Rave,
        Showtunes,
        Trailer,
        Lo_Fi,
        Tribal,
        Acid_Punk,
        Acid_Jazz,
        Polka,
        Retro,
        Musical,
        Rock_and_Roll,
        Hard_Rock
    }

    public enum MediaTypes
    {
        //todo expand on media types
    }

    /// <summary>
    /// globals
    /// </summary>
    public static class Functions
    {
        /// <summary>
        /// helper function creates an array from ';' delimited value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>the created array</returns>
        public static string[] GetArray( string value )
        {
            if(!String.IsNullOrEmpty( value ))
            {
                string[] splits = value.Split( ';' );
                // trim space
                int len = splits.Length;
                for(int i = 0; i < len; ++i)
                {
                    splits[i] = splits[i].Trim();
                }
                // set tag
                return splits;
            }
            return null;
        }
        /// <summary>
        /// helper creates a ';' delimited string from array 
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string GetString( string[] strs )
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in strs)
            {
                sb.Append( s );
                sb.Append( "; " );
            }
            sb.Remove( sb.Length - 2, 2 ); // remove comma
            return sb.ToString();
        }   
    }
}