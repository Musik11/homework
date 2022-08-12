//Задача №2 
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int mainNumber = new Random().Next(10, 100000);
int number[2] = mainNumber;
System.Console.WriteLine(number[2]);
