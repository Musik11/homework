// Задача №2

Console.WriteLine("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 2);
y = Math.Round(y, 2);

Console.WriteLine($"Точка пересечения линий : ({x};{y})");