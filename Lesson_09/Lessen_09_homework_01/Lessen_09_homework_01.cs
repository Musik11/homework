//Задание №1

int M = InputNumbers("Введите M: ");
int N = InputNumbers("Введите N: ");

Console.WriteLine($"N={N}, M={M}");
    if (M > N)
        for (int i = N; i <= M; i++)
            Console.Write($" {i}");
    else
        for (int i = M; i <= N; i++)
            Console.Write($" {i}");

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}