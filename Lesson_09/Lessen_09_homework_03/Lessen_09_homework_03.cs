//Задание №3

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int AkkermanFunction = Akkerman(m, n);

Console.Write($"Функция Аккермана = {AkkermanFunction} ");

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}