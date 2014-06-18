using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Adapter_Pattern
{
    public class Calculator
    {
        public int GetArea(Rectangle rectangle)
        {
            int area = rectangle.Width * rectangle.Height;
            return area;
        }
    }
}
