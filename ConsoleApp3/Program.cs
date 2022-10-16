// See https://aka.ms/new-console-template for more information
using SquareLibrary;

Console.WriteLine(new Triangle(3, 4, 5).GetSquare());
Console.WriteLine(Figure.GetSquare(3, 4, 5));
Console.WriteLine(new Circle(3).GetSquare());
Console.WriteLine(Figure.GetSquare(3));
