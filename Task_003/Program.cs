// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.Write("Введите число -> ");
int num = int.Parse(Console.ReadLine());
bool result = num % 2 == 0;
Console.WriteLine(result ? "Число чётное" : "Число не чётное");
