using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest
{
    internal class TriangleTest
    {
        public static Triangle _triangle = new Triangle(3, 4, 5);
        public static Triangle ZeroOrNegativeSide() => new Triangle(-1, 1, 1);
        public static double GetSquare() => _triangle.GetSquare();
        public static bool IsRight() => _triangle.IsRight();
    }
}
