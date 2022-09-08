//Задание №3

Console.WriteLine($"\nВведите размер массивов 1 и 2: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int m = InputNumbers("Введите m 'число строк первого массива': ");
int n = InputNumbers("Введите n 'число столбцов первого массива': ");
int p = InputNumbers("Введите p 'число столбцов второго массива': ");

int[,] ArrayFirst = new int[m, n];
int[,] ArraySecond = new int[n, p];
void FillArray(int[,] ArrayFirst)
{
    for (int rows = 0; rows < ArrayFirst.GetLength(0); rows++)
    {
        for (int columns = 0; columns < ArrayFirst.GetLength(1); columns++)
        {
            ArrayFirst[rows, columns] = new Random().Next(1, 10);
        }
    }
}
void WriteArray(int[,] ArrayFirst)
{
    for (int i = 0; i < ArrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayFirst.GetLength(1); j++)
        {
            Console.Write(ArrayFirst[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void MultiplyMatrix(int[,] ArrayFirst, int[,] ArraySecond, int[,] MultiplyResult)
{
    for (int i = 0; i < MultiplyResult.GetLength(0); i++)
    {
        for (int j = 0; j < MultiplyResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < ArrayFirst.GetLength(1); k++)
            {
                sum += ArrayFirst[i, k] * ArraySecond[k, j];
            }
            MultiplyResult[i, j] = sum;
        }
    }
}

Console.WriteLine($"\nПервый массив: ");
FillArray(ArrayFirst);
WriteArray(ArrayFirst);
Console.WriteLine($"\nВторой массив: ");
FillArray(ArraySecond);
WriteArray(ArraySecond);

int[,] MultiplyResult = new int[m, p];

MultiplyMatrix(ArrayFirst, ArraySecond, MultiplyResult);
Console.WriteLine($"\nПроизведение матриц: ");
WriteArray(MultiplyResult);