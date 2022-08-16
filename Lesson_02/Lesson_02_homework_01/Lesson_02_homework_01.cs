//Задача №1
int mainNumber = new Random().Next(100, 1000);
int number = mainNumber / 10;
int second = number % 10;
Console.WriteLine($"Вторая цифра из числа {mainNumber} равна: {second} " );
// Уверен можно сделать по другому, ещё меньне, на строку