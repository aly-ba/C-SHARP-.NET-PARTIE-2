using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Strategy_Pattern
{
  public   class Gamer
    {
      private Label _bulletsLabel;

      public Gamer(Label bulletsLabel)
      {
          _bulletsLabel = bulletsLabel;
      }

      private IGun _gun;

      private IGun Gun {

          set { return _gun; }
          set { _gun = value; RefreshGunInfo();}

      }

    private void RefreshGunInfo()
    {
        _gun.Draw();
        ShowBulletsInfo();
    }

    private void ShowBulletsInfo()
    {
        _bulletsLabel.Text ="Bullets :" + _gun.Bullets.ToString();
    }

    public void Fire()
    {
        _gun.Fire();

        ShowBulletsInfo();
    }

    }
}
