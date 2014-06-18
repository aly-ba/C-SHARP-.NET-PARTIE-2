using DesignPatterninCsharp.Decorateur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp
{
    class AlbumDeCorator : Album
    {
        protected Album _album;


        public AlbumDeCorator(Album album)
        {
            _album = album;
        }


        public override void Draw()
        {
            _album.Draw();
        }
    }
}
