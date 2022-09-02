// Задача №1

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] a = new double[m, n];
Random random = new Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
