
// Задача — проверить, является ли это число палиндромом.

var x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsPalindrome(x));


bool IsPalindrome(int digit)
{
	if (digit == 1)
	{
		return true;
	}
	else
	{
		digit = digit ^ ReverseDigit(digit);
		if (digit == 0)
		{
			return true;
		}
	}

	return false;
}

int ReverseDigit(int Digit)
{
	var result = "";
	var digit = Digit.ToString().Length;

	for (int i = 0; i < digit; i++)
	{
		result += Digit % 10;
		Digit = Digit / 10;
	}

	return int.Parse(result);
}