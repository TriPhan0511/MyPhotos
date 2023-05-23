using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // for Bitmap class
using System.IO; // for Path class

namespace TriPhan.MyPhotoAlbum
{
    public class AlbumManager
    {
        // Define a static private field
        // and public property to hold a
        // default storage location for
        // photo albums
        static private string _defaultPath;
        static public string DefaultPath
        {
            get { return _defaultPath; }
            set { _defaultPath = value; }
        }

        // Define a static constructor to 
        // initialize the default location to 
        // an Albums directory in the 
        // user's My Document folder.
        static AlbumManager()
        {
            _defaultPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\Albums";
        }

        // Define private fields to hold the album,
        // position within the album, and album name
        private int _pos = -1;
        private string _name = String.Empty;
        private PhotoAlbum _album;


        // Define a default constructor that initializes the class
        // for an empty album.
        public AlbumManager()
        {
            _album = new PhotoAlbum();
        }

        // Define a constructor that loads an existing album.
        public AlbumManager(string name): this()
        {
            _name = name;
            // TODO: load the album
            throw new NotImplementedException();
        }

        // Define a read-only Album property,
        // and a Fullname property that only be set internally.
        public PhotoAlbum Album
        {
            get { return _album; }
        }
        public string FullName
        {
            get { return _name; }
            private set { _name = value; }
        }

        // Define a read-only ShortName property that
        // returns the base
    }
}
