using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Tools
{
    public class Functions
    {
        // todo - error handling
        public static void MoveTo(FileInfo fi, string dest, bool overwrite)
        {
            if(File.Exists( dest ) && overwrite)
            {
                if(overwrite)
                    File.Delete( dest );
                else
                    return;
            }
            fi.MoveTo( dest );
        }
    }
}
