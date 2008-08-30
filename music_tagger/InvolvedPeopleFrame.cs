using System;
using System.Collections.Generic;
using System.Text;
using TagLib.Id3v2;

namespace music_tagger
{
    class InvolvedPeopleFrame
    {
        private UnknownFrame frame = null;
        private string[] strings = null;
        private string[] persons = null;
        private string[] functions = null;

        public InvolvedPeopleFrame( UnknownFrame frame )
        {
            this.frame = frame;
            strings = this.frame.Data.ToStrings( TagLib.StringType.UTF8, 1 );

            int len = (int)( strings.Length / 2 );
            int total_len = strings.Length;
            persons = new string[len];
            functions = new string[len];
            for(int i = 0; i < len; i++)
            {
                int idx = (int)(i * 2);
                persons[i] = strings[idx];
                functions[i] = strings[idx+1];
            }
        }

        public string[] Person
        {
            get
            {
                return persons;
            }
        }

        public string[] Function
        {
            get
            {
                return functions;
            }
        }
    }
}
