
// Задача — проверить, является ли это число палиндромом.

var x = Console.ReadLine();
var y = int.Parse(Console.ReadLine());

Console.WriteLine(IsPalindromeForString(x));
Console.WriteLine(IsPalindromeForInt(y));

/// <summary>
/// Реализовано два метода для поиска палиндрома:
/// 1.Для строки
/// 2.Для Цифр
/// </summary>

bool IsPalindromeForString(string str)
{
	str = str.ToLower();

	if (str[0] == str[^1]) 
		return true;

	return false;
}

bool IsPalindromeForInt(int digit)
{
	if (digit <= 9)
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