using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace music_tagger
{
    public class FormatEvaluator
    {
        private string exp = @"\<[ABCEGKPRTY]\>";
        private TagLib.Tag tag = null;
        private string value;

        public string Value
        {
            get
            {
                return value;
            }
        }

        public FormatEvaluator( string format, TagLib.Tag tag )
        {
            this.tag = tag;

            Regex regx = new Regex( exp );
            MatchEvaluator meval = new MatchEvaluator( ReplaceFunc );
            value = regx.Replace( format, meval );
        }

        private string ReplaceFunc( Match m )
        {
            switch(m.Value)
            {
            case "<A>":
                return tag.FirstPerformer;
            case "<B>":
                return tag.Album;
            case "<T>":
                return tag.Title;
            case "<K>":
                return tag.Title;
            default:
                return m.Value;
            }
        }

    }
}
