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
    public class Photograph
    {
        private string _fileName;
        private Bitmap _bitmap;

        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = null;
        }

        public string FileName
        {
            get { return _fileName; }
        }

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
    }
}
