using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Strategy_Pattern
{
   public interface  IGun
    {
       void Fire();

       void Draw();

       void Bullets { get; set;  }

       PictureBox GunBox { get; set; }
       PicutreBox BulletBox { get; set;  }
    }
}
