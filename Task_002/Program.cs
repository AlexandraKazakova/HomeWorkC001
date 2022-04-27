// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
Console.Write("Введите первое число -> ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите третье число -> ");
int C = int.Parse(Console.ReadLine());
if(A >= B & A >= C)
{
	Console.WriteLine("Максимальное из этих чисел ->" + A);
}
else if(B >= A && B >= C)
{
	Console.WriteLine("Максимальное из этих чисел ->" + B);
}
else
{
	Console.WriteLine("Максимальное из этих чисел ->" + C);
}