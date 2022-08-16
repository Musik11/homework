//Задача №1
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((number == 0) || (reverse(number, 0) == number));
Console.ReadKey(true);
int reverse(int number, int rebmun)
{
    while (number > 0) { rebmun = rebmun * 10 + number % 10; number /= 10; }
    return rebmun;
}