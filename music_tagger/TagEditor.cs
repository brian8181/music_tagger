using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace music_tagger
{
    class TagEditor
    {
        private TagLib.File tag_file = null;
        private TagLib.Tag v1;
        private TagLib.Tag v2;
        private ListView lv = null;
        private int idx = -1;
        public TagEditor()
        {
        }
    }
}
