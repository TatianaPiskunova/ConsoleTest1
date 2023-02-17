using ClassLibraryTest1;


Console.WriteLine("Введите тип фигуры: треугольник или круг");
var type = Console.ReadLine();
Figure? figure = null;
switch (type.ToLower())
{
    case "треугольник": figure = new Triangle("Triangle", 3, 7, 5); break;
    case "круг": figure = new Circle("Circle", 34); break;
}
if (figure != null) figure.Area();
else Console.WriteLine("Неверный тип фигуры");

