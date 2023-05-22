using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriPhan.MyPhotoAlbum
{
    /// <summary>
    /// The Photograph class represents a
    /// photographic image stored in the 
    /// file system.
    /// </summary>
    public class Photograph: IDisposable
    {
        // Private member variables
        private string _fileName;
        private Bitmap _bitmap;
        private string _caption;
        private string _photographer;
        private DateTime _dateTaken = DateTime.Now;
        private string _notes = "";
        private bool _hasChanged = true;


        // A constructor
        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = null;
            _caption = System.IO.Path.GetFileNameWithoutExtension(fileName);
        }

        // A FileName property
        public string FileName
        {
            get { return _fileName; }
        }

        // An Image property
        public Bitmap Image
        {
            get
            {
                if (_bitmap == null)
                {
                    _bitmap = new Bitmap(_fileName);
                }
                return _bitmap;
            }
        }

        // A HasChanged property
        public bool HasChanged
        {
            get { return _hasChanged; }
            internal set { _hasChanged = value; }
        }

        // A Caption property
        public string Caption
        {
            get { return _caption; }
            set 
            {
                if (_caption != value)
                {
                    _caption = value;
                    HasChanged = true;
                }
            }
        }

        // A Photographer property
        public string Photographer
        {
            get { return _photographer; }
            set 
            {
                if (_photographer != value)
                {
                    _photographer = value;
                    HasChanged = true;
                }
            }
        }

        // A DateTaken property
        public DateTime DateTaken
        {
            get { return _dateTaken; }
            set
            {
                if (_dateTaken != value)
                {
                    _dateTaken = value;
                    HasChanged = true;
                }
            }
        }

        // A Notes property
        public string Notes
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    HasChanged = true;
                }
            }
        }        

        // Override the Equals method (compares filenames)
        public override bool Equals(object obj)
        {
            if (obj is Photograph)
            {
                Photograph p = (Photograph)obj;
                return (FileName.Equals(p.FileName, 
                    StringComparison.InvariantCultureIgnoreCase));
            }
            return false;
        }

        // Override the HashCode method
        public override int GetHashCode()
        {
            return FileName.ToLowerInvariant().GetHashCode();
        }

        // Override the ToString method
        public override string ToString()
        {
            return FileName;
        }

        public void Dispose()
        {
            ReleaseImage();
        }

        private void ReleaseImage()
        {
            if (_bitmap != null)
            {
                _bitmap.Dispose();
                _bitmap = null;
            }
        }
    }
}
