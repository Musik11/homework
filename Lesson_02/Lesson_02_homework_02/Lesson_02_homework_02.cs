//Задача №2
int mainNumber = new Random().Next(10, 100000);
Console.WriteLine(mainNumber);
Console.WriteLine(mainNumber>99 ? mainNumber.ToString()[2] : '-');