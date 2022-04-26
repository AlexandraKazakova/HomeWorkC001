// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число -> ");
int N = int.Parse(Console.ReadLine());
int num = 1;
while(num <= N)
{
	if(num % 2 == 0)
	{
		Console.Write(num + " ");
		num++;
	}
	else
	{
		num++;
	}
}