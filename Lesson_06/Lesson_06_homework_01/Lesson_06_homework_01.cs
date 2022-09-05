// Задача №1

Console.Write("Введите число : "); 
int[] user_arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);  

int count = 0;                                           

for (int i = 0; i < user_arr.Length; i++)
{
    if (user_arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел : " + count);