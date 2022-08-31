// Задача №3

double [] array = new double[10];

for (int i = 0; i < array.Length; i++)
   {
        array[i] = new Random().NextDouble();
        Console.Write(array[i] + "; ");
    }

Console.WriteLine();

double min = array[0];
double max = array[0];
foreach (int i in array)  
{
    if (min > array[i]) min = array[i];
    if (max < array[i]) max = array[i];
}
double diff = max - min;

Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: " + diff);