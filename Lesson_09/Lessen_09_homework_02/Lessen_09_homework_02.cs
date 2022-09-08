//Задание №2

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

int SummRoutine(int M, int N)
{
    int FirstElement = M;
    int LastElement = N;
    if (M > N)
    {
        FirstElement = N;
        LastElement = M;
    }
    return (LastElement + FirstElement) * (LastElement - FirstElement + 1) / 2; // по формуле суммы членов арифметической прогрессии
}

Console.WriteLine(SummRoutine(M, N));

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}