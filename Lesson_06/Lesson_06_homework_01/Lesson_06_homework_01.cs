// Задача №1

Console.Write("Insert your numbers (use space, pls): "); 
int[] user_arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);  

int count = 0;                                           

for (int i = 0; i < user_arr.Length; i++)
{
    if (user_arr[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Number of positive values: " + count);