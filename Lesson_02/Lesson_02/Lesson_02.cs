﻿/*
------------------------------------------------------------------------------------------------------------
Задание №1
Напишите программу, 
которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8
12-> 2
85 -> 8

---------------------------------------------------------------------------------------------------------------

int number = new Random().Next(10, 100);
int firstNumber = number / 10;
int secondNumber = number % 10;
int maximum = firstNumber;
if (secondNumber > maximum ) maximum = secondNumber;
{
    System.Console.WriteLine($" Максимальное цифра в числе {number} - это {maximum} " );
}

--------------------------------------------------------------------------------------------------------------
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
--------------------------------------------------------------------------------------------------------------

Задание №2
Напишите программу, 
которая выводит случайное трёхзначное число и 
удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

--------------------------------------------------------------------------------------------------------------

int number = new Random().Next(100, 1000);
int firstNumber = number / 100;
int secondNumber = number % 10;
string firstSum = Convert.ToString(firstNumber);
string secondSum = Convert.ToString(secondNumber);
Console.WriteLine($"Из числа '{number}' получаем число : {firstSum + secondSum}" );

--------------------------------------------------------------------------------------------------------------
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
--------------------------------------------------------------------------------------------------------------

Задание №3
Напишите программу, 
которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 16, 4 -> кратно

--------------------------------------------------------------------------------------------------------------

Console.WriteLine("Введите первое число:");
 int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
 int secondNumber = Convert.ToInt32(Console.ReadLine());

int diff = firstNumber % secondNumber;

if (diff == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно {diff} ");
}

--------------------------------------------------------------------------------------------------------------
//////////////////////////////////////////////////////////////////////////////////////////////////////////////
--------------------------------------------------------------------------------------------------------------

Задача №4
Напишите программу, 
которая принимает на вход число и проверяет, 
кратно ли оно одновременно 
7 и 23. 
14 -> нет 
46 -> нет 
161 -> да

--------------------------------------------------------------------------------------------------------------

Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());

int firstDiff = number % 7;
int secondDiff = number % 23;

if (firstDiff == 0 && secondDiff == 0) 
{        
    Console.WriteLine($"Да, число {number} кратно числу 7 и 23");    
}
else
{
    Console.WriteLine($"Нет, число {number} не кратно числу 7 и 23");
}

--------------------------------------------------------------------------------------------------------------
*/

