//---------------------------------------------------------------------------
/*

 Console.WriteLine("Введите число:");

 int number = Convert.ToInt32(Console.ReadLine());

 int square = number * number * number;

 double square = Math.Pow(number, 3);

Console.WriteLine("Результат: " + square);

*/

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------

/*

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
}
else
{
    Console.WriteLine(firstNumber + " Не является квадратом от " + secondNumber);
}

*/

//--------------------------------------------------------------------------
//--------------------------------------------------------------------------

/*
 
Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"
*/

int number = Convert.ToInt32(Console.ReadLine());
int negativeNumber = number * ( -1 );

    while ( negativeNumber <= number )
    {
        Console.WriteLine(negativeNumber);
        negativeNumber++;

    }
