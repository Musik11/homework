//Задание №1

Console.WriteLine($"\nВведите размер массива: ");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int[,] InitialArray = new int[m, n];

Console.WriteLine($"\nНачальный массив: ");

FillArray(InitialArray);
WriteArray(InitialArray);

void WriteArray(int[,] arrInitialArrayay)
{
    for (int i = 0; i < InitialArray.GetLength(0); i++)
    {
        for (int j = 0; j < InitialArray.GetLength(1); j++)
        {
            Console.Write(InitialArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] InitialArray)
{
    for (int rows = 0; rows < InitialArray.GetLength(0); rows++)
    {
        for (int columns = 0; columns < InitialArray.GetLength(1); columns++)
        {
            InitialArray[rows, columns] = new Random().Next(1, 10);
        }
            }
}
void ArrayOrder(int[,] InitialArray)
{
    for (int i = 0; i < InitialArray.GetLength(0); i++)
    {
        for (int j = 0; j < InitialArray.GetLength(1); j++)
        {
            for (int k = 0; k < InitialArray.GetLength(1) - 1; k++)
            {
                if (InitialArray[i, k] < InitialArray[i, k + 1])
                {
                    int temp = InitialArray[i, k + 1];
                    InitialArray[i, k + 1] = InitialArray[i, k];
                    InitialArray[i, k] = temp;
                }
            }
        }
    }
}

Console.WriteLine($"\nОтсортированный массив: ");
ArrayOrder(InitialArray);
WriteArray(InitialArray);