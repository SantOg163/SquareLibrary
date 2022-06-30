using SquareTest;

TriangleTest.ZeroOrNegativeSide();
TriangleTest.IsValid();
Console.WriteLine("Треугольник:");
Console.WriteLine("Площадь - "+ TriangleTest.GetSquare());
Console.WriteLine("Прямоугольный? - "+TriangleTest.IsRight());
Console.WriteLine("Круг:");
Console.WriteLine("Площадь - " + CircleTest.GetSquare());
CircleTest.ZeroOrNegativeRadius();