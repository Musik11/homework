// Задача №1

int[] array = new int[5];
int mainNumber = 0;
Random randomNumber = new Random();

Console.WriteLine("Исходный массив");
for (int i = 0; i < 5; i++)
{
    array[i] = randomNumber.Next(100, 1000);
    Console.Write("{0} ", array[i]);
}
Console.WriteLine();

foreach (int temp in array)
{
    Console.Write("{0} ", temp);
    if (temp % 2 == 0)
    {
        mainNumber++;
    }
}
Console.WriteLine("\nКоличество четных элементов {0}", mainNumber);