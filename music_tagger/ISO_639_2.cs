using System;
using System.Collections.Generic;
using System.Text;
namespace music_tagger
{
    class ISO_639_2
    {
        private string alpha_2 = string.Empty;
        private string alpha_3 = string.Empty;
        private string english = string.Empty;
        private string french = string.Empty;

        public string Alpha_2
        {
            get { return alpha_2; }
            set { alpha_2 = value; }
        }
        public string Alpha_3
        {
            get { return alpha_3; }
            set { alpha_3 = value; }
        }
        public string EnglishName
        {
            get { return english; }
            set { english = value; }
        }
        public string FrenchName
        {
            get { return french; }
            set { french = value; }
        }
        public ISO_639_2()
        {
        }
        public ISO_639_2( string alpha_3, string english )
            : this( string.Empty, alpha_3, english )
        {
        }
        public ISO_639_2( string alpha_2, string alpha_3, string english )
            : this( alpha_2, alpha_3, english, string.Empty )
        {
        }
        public ISO_639_2( string alpha_2, string alpha_3, string english, string french )
        {
            this.alpha_2 = alpha_2;
            this.alpha_3 = alpha_3;
            this.english = english;
            this.french = french;
        }
        public override string ToString()
        {
            return String.Format( "{0} ({1})", alpha_3, english );
        }
    }
}
