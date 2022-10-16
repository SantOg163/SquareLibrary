namespace SquareLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        
        public Circle(double radius) 
        {
            if(radius <= 0)
                throw new ArgumentException($"Радиус должен быть больше 0\nТекущее значение: {radius}");
            Radius = radius; 
        }
        public override double GetSquare() => Math.PI * Math.Pow(Radius,2);
    }
}