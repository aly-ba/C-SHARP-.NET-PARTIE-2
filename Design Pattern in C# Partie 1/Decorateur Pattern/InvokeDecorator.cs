using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Decorateur
{
    public class InvokeDecorator
    {

        public static void main(string[] args)
        {
            private Album _album;
            _album = new  Album(_graphics);
            _album.Draw();

            //In the runtime, when user wants a Christmas Tree, an instance of
            //ChristmasTreeDecorator is created.

            _album = new ChristmasTreeDecoratorcs (_album);
            _album.Draw();
        }
    }
}
