using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace universal_tagger
{
    public class FormatEvaluator
    {
        protected string exp = null;
        protected string value;
        protected int digits = 2;

        public FormatEvaluator( string exp )
        {
            this.exp = exp;
        }
    }

    public class FromTagEvaluator : FormatEvaluator
    {
         protected TagLib.Tag tag = null;
        /// <summary>
        /// return formatted string
        /// </summary>
        public string Value
        {
            get
            {
                return value;
            }
        }
        /// <summary>
        /// default constuctor
        /// </summary>
        /// <param name="format"></param>
        /// <param name="tag"></param>
        public FromTagEvaluator( string format, TagLib.Tag tag, string exp )
            : base( exp )
        {
            this.tag = tag;
            Regex regx = new Regex( exp );
            MatchEvaluator meval = new MatchEvaluator( ReplaceFunc );
            value = regx.Replace( format, meval );
        }
        /// <summary>
        /// match evaluator callback function
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private string ReplaceFunc( Match m )
        {
            return Replacer( m );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="tag"></param>
        /// <returns></returns>
        protected virtual string Replacer( Match m )
        {
            switch(m.Value)
            {
            case "<A>":
                return tag.FirstPerformer;
            case "<B>":
                return tag.Album;
            case "<C>":
                return tag.Comment;
            case "<P>":
                return tag.Disc.ToString();
            case "<p>":
                return tag.DiscCount.ToString();
            case "<R>":
                return tag.FirstComposer;
            case "<E>":
                return tag.BeatsPerMinute.ToString();
            case "<I>":
                goto default;
            case "<T>":
                return tag.Title;
            case "<K>":
                string track_format = new string( '0', digits );
                return tag.Track.ToString( track_format );
            case "<k>":
                return tag.TrackCount.ToString();
            case "<Y>":
                return tag.Year.ToString();
            case "<G>":
                return tag.FirstGenre;
            case "<M>":
                goto default;
            case "<N>":
                return tag.Conductor;
            case "<O>":
                goto default;
            case "<S>":
                goto default;
            case "<U>":
                return tag.Grouping;
            default:
                return m.Value;
            }
        }
    }

    /// <summary>
    /// evaluate and replace format specifers with content
    /// </summary>
    public class OrganizeFormatEvaluator : FromTagEvaluator
    {
        //todo 
        /// <summary>
        /// default constuctor
        /// </summary>
        /// <param name="format"></param>
        /// <param name="tag"></param>
        public OrganizeFormatEvaluator( string format, TagLib.Tag tag )
            : base( format, tag, @"\<[ABCEGKPRTYkp]\>" )
        {
        }
    }

   public class Tag2FileFormatEvaluator  : FromTagEvaluator
   {
       //todo
       /// <summary>
        /// default constuctor
        /// </summary>
        /// <param name="format"></param>
        /// <param name="tag"></param>
       public Tag2FileFormatEvaluator( string format, TagLib.Tag tag )
            : base( format, tag, "TODO" )
        {
        }
   }

    public class File2TagFormatEvaluator : FormatEvaluator
    {
        private TagLib.File file = null;
        private TagLib.Tag tag = null;

        public File2TagFormatEvaluator( string format, TagLib.File file )
            : base( @"\<[ABCEGKPRTYkp]\>" )
        {
            this.file = file;
            tag = file.GetTag( TagLib.TagTypes.Id3v1 );
            string fname = System.IO.Path.GetFileNameWithoutExtension( file.Name );
            Regex regx = new Regex( exp );
            MatchEvaluator meval = new MatchEvaluator( ReplaceFunc );
            value = regx.Replace( format, meval );

            Regex file_regx = new Regex( value );
            Match m = file_regx.Match( fname );

            string[] grp_names = file_regx.GetGroupNames();
            foreach(string name in grp_names)
            {
                Group g = m.Groups[name];
                WriteTag( name, g.Value );
            }
        }
        /// <summary>
        /// match evaluator callback function
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private string ReplaceFunc( Match m )
        {
            return string.Format( @"(?{0}.+|\s)", m.Value );
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        private void WriteTag( string name, string value )
        {
            switch(name)
            {
            case "A":
                tag.Performers = new string[1] { value };
                break;
            case "B":
                tag.Album = value;
                break;
            case "C":
                break;
            case "P":
                //tag.Disc.ToString();
                break;
            case "p":
                //tag.DiscCount.ToString();
                break;
            case "R":
                //tag.FirstComposer;
                break;
            case "E":
                break;
            case "I":
                break;
            case "T":
                tag.Title = value;
                break;
            case "K":
                tag.Track = uint.Parse( value );
                break;
            case "k":
                tag.TrackCount = uint.Parse( value ); ;
                break;
            case "Y":
                tag.Year = uint.Parse( value );
                break;
            case "G":
                //tag.FirstGenre;
                break;
            case "M":
                goto default;
            case "N":
                //tag.Conductor;
                break;
            case "O":
                goto default;
            case "S":
                goto default;
            case "U":
                //tag.Grouping;
                break;
            default:
                return;
            }
        }
    }
}