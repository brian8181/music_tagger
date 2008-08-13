using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace music_tagger
{
    public class EditUserControl : UserControl
    {
        //private ListView lv = null;
        //private int idx = -1;
          
        protected System.Windows.Forms.ComboBox cmbArtist;
        protected System.Windows.Forms.TextBox txtComment;
        protected System.Windows.Forms.TextBox txtTrack;
        protected System.Windows.Forms.TextBox txtYear;
        protected System.Windows.Forms.TextBox txtAlbum;
        protected System.Windows.Forms.TextBox txtTitle;

        public EditUserControl()
        {
        }

        //public System.Windows.Forms.CheckBox ckComment;
        //public System.Windows.Forms.CheckBox ckGenre;
        //public System.Windows.Forms.CheckBox ckTrack;
        //public System.Windows.Forms.CheckBox ckYear;
        //public System.Windows.Forms.CheckBox ckAlbum;
        //public System.Windows.Forms.CheckBox ckTitle;
        //public System.Windows.Forms.CheckBox ckArtist;
        //public System.Windows.Forms.Label lblFileTag;
        //public System.Windows.Forms.Label lblFile;

        ///// <summary>
        ///// intialize listview  
        ///// </summary>
        ///// <param name="lv"></param>
        //public virtual void Initialize( ListView lv )
        //{
        //    this.lv = lv;
        //    if(lv.SelectedItems.Count > 0)
        //    {
        //        idx = 0;
        //        Fill( idx );
        //    }
        //}
        ///// <summary>
        /////  fill from tag
        ///// </summary>
        ///// <param name="idx"></param>
        //public void Fill( int idx )
        //{
        //    FileInfo fi = (FileInfo)lv.SelectedItems[idx].Tag;
        //    //lblFile.Text = fi.FullName;

        //    TagLib.File tag_file = TagLib.File.Create( fi.FullName );
        //    TagLib.Tag id3v1 = tag_file.GetTag( TagLib.TagTypes.Id3v1 );
        //    Fill( id3v1 );
        //}
        ///// <summary>
        /////  fill from tag
        ///// </summary>
        ///// <param name="idx"></param>
        //public void Fill( TagLib.Tag id3v1 )
        //{
        //    if(id3v1 != null)
        //    {
        //        //if(id3v1.Performers.Length > 0)
        //        //{
        //        //    cmbArtist.Items.AddRange( id3v1.Performers );
        //        //    cmbArtist.SelectedIndex = 0;
        //        //}
        //        //txtAlbum.Text = id3v1.Album;
        //        //txtTitle.Text = id3v1.Title;
        //        //txtYear.Text = id3v1.Year.ToString();
        //        //txtTrack.Text = id3v1.Track.ToString();
        //        //if(id3v1.Genres.Length > 0)
        //        //{
        //        //    cmbGenre.Items.AddRange( id3v1.Genres );
        //        //    cmbGenre.SelectedIndex = 0;
        //        //}
        //        //txtComment.Text = id3v1.Comment;
        //    }
        //}
    }
}
