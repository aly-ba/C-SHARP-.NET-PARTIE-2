using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Adapter_Pattern
{
    public class CalculatorAdapter
    {
        public int GetArea(Square square)
        {
            Calculator calculator = new Calculator();

            Rectangle rectangle = new Rectangle();

            rectangle.Width = rectangle.Height =square.Size;

            int area = calculator.GetArea(rectangle);

            return area;
        }
    }
}
