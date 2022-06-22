using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest
{
    internal class CircleTest
    {
        public static  Circle circle = new Circle(2);
        public static Circle ZeroOrNegativeRadius() => new Circle(0);
        public static double GetSquare() => circle.GetSquare();
    }
}
