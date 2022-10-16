using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public abstract class Figure
    {
        //Вычисление площади фигуры без знания типа фигуры в compile-time ?
        public abstract double GetSquare();
        public static double GetSquare(double Radius) => Math.PI * Math.Pow(Radius, 2);
        public static double GetSquare(double A, double B, double C)
        {
            double P = (A + B + C) / 2;
            return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
        }
    }

}
