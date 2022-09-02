// Задача №3

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}
for (int i = 0; i < array.GetLength(0); i++)
{
    int srAr = 0;
    for (int t = 0; t < array.GetLength(0); t++)
    {
        srAr += array[t, i];
    }
    int size = array.GetLength(0);
    Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr /size}");
}