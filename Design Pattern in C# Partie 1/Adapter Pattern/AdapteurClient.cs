using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Adapter_Pattern
{
    public class AdapteurClient
    {

        public static void main(string args[])
        {
            //create Square class and assing size from UI
            Square  square= new Square();
            square.Size = SquarePanel.Width;// vallable only on my context

            CalculatorAdapter adapter = new CalculatorAdapter();
            int area = adapter.GetArea(square);

            IAsyncResult.Text = "Area:" + area.ToString();



        }
    }
}
