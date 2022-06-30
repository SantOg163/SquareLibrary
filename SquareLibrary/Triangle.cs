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
            //Я сделал валидацию через StringBuilder для более подробного списка ошибок
            StringBuilder errors = new StringBuilder();
            if (a <= 0)
                errors.AppendLine($"\nЗначение A дожно быть больше 0. \nТекущее значение: {a}");
            if (b <= 0)
                errors.AppendLine($"\nЗначение B дожно быть больше 0. \nТекущее значение: {b}");
            if (c <= 0)
                errors.AppendLine($"\nЗначение C дожно быть больше 0. \n Текущее значение: {c}");
            if (a >= b + c)
                errors.AppendLine($"\nЗначение A дожно быть больше B+C. \nТекущие значение: A = {a}; B+C = {b+c}");
            if (b >= a + c)
                errors.AppendLine($"\nЗначение B дожно быть больше A+C. \nТекущие значение: B = {b}; A+C = {a+c}");
            if (c >= a + b)
                errors.AppendLine($"\nЗначение C дожно быть больше A+B. \nТекущие значение: C = {c}; A+B = {a+b}");
            if(errors.Length > 0)
                throw new ArgumentException(errors.ToString());
            B = b;
            A = a;
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
