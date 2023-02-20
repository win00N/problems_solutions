

//Вывести на экран все простые числа из промежутка от 0 до N.

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"N = {n}");

for (int i = 2; i <= n; i++)
{
	if (IsSimpleDigit(i))
	{
		Console.Write(i + " ");
	}
}

bool IsSimpleDigit(int digit)
{
	if (digit == 2 
		|| digit == 3
		|| digit == 5
		|| digit == 7)
	{
		return true;
	}

	if (digit % 2 == 0 
		|| digit % 3 == 0 
		|| digit % 5 == 0
		|| digit % 7 == 0)
	{
		return false;
	}
	return true;
}