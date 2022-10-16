using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class TriangleTest
    {
        private static Triangle _triangle = new Triangle(3, 4, 5);
        [Fact]
        public static Triangle AddTriangle() => new Triangle(3, 4, 5);
        [Fact]
        public static Triangle ZeroOrNegativeSide() => new Triangle(-1, 1, 1);
        [Fact]
        public static double GetSquare() => _triangle.GetSquare();
        [Fact]
        public static bool IsRight() => _triangle.IsRight();
        [Fact]
        public static void UnknownSquare()=>Figure.GetSquare(3,4,5);
        
    }
}
