// Задача №2

int[] array = new int[5];
int mainNumber = 0; 
int sum = 0;
Random randomNumber = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 5; i++)
{
    array[i] = randomNumber.Next(-10, 10);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();

foreach (int temp in array)
{
    Console.Write("{0} ", temp);
    if (temp % 2 != 0)
    {
        mainNumber++;
        sum += temp;
    }
}
Console.WriteLine("\nКоличество нечетных элементов: " + mainNumber);
Console.WriteLine("\nСумма нечетных элементов: " + sum);