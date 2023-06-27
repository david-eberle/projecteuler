using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public partial class Program
{
	public static void Exercise0021()
	{
		List<int> amicables = new() { }; ;
		int total1, total2;
		for (int i = 1; i < 10000; i++) {
			List<long> divisors = getDivisors(i);
			divisors.Remove(i);
			total1 = divisors.Sum(x => Convert.ToInt32(x));

			divisors = getDivisors(total1);
			divisors.Remove(total1);
			total2 = divisors.Sum(x => Convert.ToInt32(x));
			if (total2 == i && total1!= total2)
			{
				amicables.Add(total1);
				amicables.Add(total2);
				//Console.WriteLine(total1.ToString() + " - " + total2.ToString());
			}
		}
		Console.WriteLine("value found: " + amicables.Distinct().Sum(x => Convert.ToInt32(x)).ToString());
	}
	public static void Exercise0022()
	{
		string lines = File.ReadAllText("data\\0022_names.txt");
		List<string> names = lines.Split(",").ToList();
		names.Sort();
		long sum = 0;
		int position = 1;
		foreach (string name in names)
		{
			int nameValue = 0;
			foreach (char c in name)
			{
				nameValue += c - 64;
			}
			sum += (nameValue * position);
			position++;
		}
		Console.WriteLine("value found: " + sum.ToString());
	}
	public static void Exercise0023()
	{
		List<long> divisors;
		List<long> abundants = new List<long>() { };
		List<long> result = new List<long>() { };
		long sum;
		for (int i = 1; i <= 28123; i++)
        {
			divisors = getDivisors(i);
			divisors.Remove(i);
			sum = divisors.Sum();
            if (sum > i) {
				abundants.Add(i);
			}
        }
		for(int i = 0; i < abundants.Count; i++)
        {
			for (int j = i; j < abundants.Count; j++)
			{
				if(abundants[i] + abundants[j] <= 28123)
					result.Add(abundants[i]+ abundants[j]);                
			}
		}
		result = result.Distinct().ToList();
		sum = 0;
		for (int i = 1; i <= 28123; i++)
			if (!result.Contains(i))
				sum += i;
		Console.WriteLine("value found: " + sum.ToString());
	}
	public static void Exercise0024()
	{
	}
	public static void Exercise0025()
	{
	}
	public static void Exercise0026()
	{
	}
	public static void Exercise0027()
	{
	}
	public static void Exercise0028()
	{
	}
	public static void Exercise0029()
	{
	}
	public static void Exercise0030()
	{
	}
}