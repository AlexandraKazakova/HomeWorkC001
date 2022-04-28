// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.Write("Введите первое число -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число -> ");
int c = int.Parse(Console.ReadLine());
if(a >= b && a >= c)
{
	Console.WriteLine("Максимальное из этих чисел ->" + a);
}
else if(b >= a && b >= c)
{
	Console.WriteLine("Максимальное из этих чисел ->" + b);
}
else
{
	Console.WriteLine("Максимальное из этих чисел ->" + c);
}
