//Задача №2
Console.WriteLine("Введите первое число:");
 int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
 int secondNumber = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Введите третье число:");
 int thirdNumber = Convert.ToInt32(Console.ReadLine());

 int MaxValue = 0;

    if ( firstNumber >= secondNumber )
    {
    MaxValue = firstNumber;
    }
    else
    {
    MaxValue = secondNumber;
    }
    if ( MaxValue >= thirdNumber )
    {
    Console.WriteLine("Максимальное число: " + MaxValue);
    }
    else
    {
    MaxValue = thirdNumber;
    Console.WriteLine("Максимальное число: " + MaxValue);
    }
//--------------------------------------------------------