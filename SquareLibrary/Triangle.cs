using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary
{
    public class Triangle : Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException($"Значение A дожно быть больше 0 \n Текущее значение: {a}");
            A = a;
            if (b <= 0)
                throw new ArgumentException($"Значение B дожно быть больше 0 \n Текущее значение: {b}");
            B = b;
            if (c <= 0)
                throw new ArgumentException($"Значение C дожно быть больше 0 \n Текущее значение: {c}");
            C = c;

        }
        public override double GetSquare()
        {
            double P=(A+B+C)/2;
            return Math.Sqrt(P*(P-A)*(P-B)*(P-C));
        }
        public bool IsRight()
        {
            if(Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2) || Math.Pow(A, 2) == Math.Pow(C, 2) + Math.Pow(B, 2) || Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2))
                return true;
            return false;
        }
    }
}
