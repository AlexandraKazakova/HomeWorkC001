//Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Введите первое число -> ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число -> ");
int B = int.Parse(Console.ReadLine());
if(A > B)
{
	Console.WriteLine (A + " > " + B);
}
else
{
	Console.WriteLine(B + " > " + A);
}
