Console.Write("Введите число : ");
int mainNumber = Convert.ToInt32(Console.ReadLine());
    
    int number;
    for (number = 1; number <= mainNumber; number++)
        Console.Write(number * number * number + " ");