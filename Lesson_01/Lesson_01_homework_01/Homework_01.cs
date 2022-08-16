//Задача №1
Console.WriteLine("Введите первое число:");
 int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
 int secondNumber = Convert.ToInt32(Console.ReadLine());

 int MaxValue = 0;

    if ( firstNumber >= secondNumber )
    {
    MaxValue = firstNumber;
    Console.WriteLine("Максимальное число: " + MaxValue);
    }
    else
    {
    MaxValue = secondNumber;
    Console.WriteLine("Максимальное число: " + MaxValue);
    }
//-------------------------------------------------------