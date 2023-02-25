int PrintRec(int a, int b)
{
	Console.Write(a + " ");
	if (a == b)
	{
		return a;
	}

	if (a < b)
	{
		return PrintRec(++a, b);
	}
	else
	{
		return PrintRec(--a, b);
	}
}

PrintRec(1, 10);
Console.WriteLine();
PrintRec(10, 1);