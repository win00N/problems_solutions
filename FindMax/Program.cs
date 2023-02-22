
var n = int.Parse(Console.ReadLine());

var array = new int[n];
var rnd = new Random(Guid.NewGuid().GetHashCode());

for (int i = 0;i < n; i++)
{
	array[i] = rnd.Next(0, 100);
	Console.Write(array[i] + " ");
}

Console.WriteLine();

var maxVal = array[0];
var index = 0;


// Time: O(n)

for (int i = 0; i < array.Length; i++)
{
	if (maxVal < array[i])
	{
		maxVal = array[i];
		index = i;
	}
}

Console.WriteLine($"\nMax value is {maxVal} in array index of [{index + 1}]");
