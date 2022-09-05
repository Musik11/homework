// Задача №3

Console.WriteLine("Введите число(не больше 10): ");
int x = int.Parse(Console.ReadLine());

string bin = Convert.ToString(x, 2);

Console.WriteLine("Your number in 2 system is: " + bin); 