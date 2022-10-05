using SquareLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class CircleTest
    {
        private static Circle circle = new Circle(2);
        [Fact]
        public static  Circle AddCircle() => new Circle(2);
        [Fact]
        public static Circle ZeroOrNegativeRadius() => new Circle(0);
        [Fact]
        public static double GetSquare() => circle.GetSquare();
    }
}
