
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
	string ReverseStr(string str2)
	{
		var result = "";

		for (int i = 0; i < str.Length; i++)
		{
			result = str2[i] + result;
			
		}
		return result;
	}

	str = str.ToLower();

	if (str.Equals(ReverseStr(str)))
		return true;

	return false;
}

bool IsPalindromeForInt(int digit)
{
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
