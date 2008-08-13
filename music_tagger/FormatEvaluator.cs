using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace music_tagger
{
    /// <summary>
    /// evaluate and replace format specifers with content
    /// </summary>
    public class FormatEvaluator
    {
        private string exp = @"\<[ABCEGKPRTYkp]\>";
        private TagLib.Tag tag = null;
        private string value;

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
        public FormatEvaluator( string format, TagLib.Tag tag )
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
                return tag.Track.ToString();
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
}