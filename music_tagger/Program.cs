using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace music_tagger
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
            if( args.Length > 0 )
                MessageBox.Show(args[0]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new MainFrm() );
        }

    }
}