using System;

class Program
{
	static void Main(string[] args)
	{
		for (int i = 1; i <= 20; i++)
		{
			int potega = i * i * i;
			Console.WriteLine($"{i} do potęgi 3 = {potega}");
		}
	}
}