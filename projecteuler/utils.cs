﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public partial class Program

{
	public static string Reverse(string s)
	{
		char[] charArray = s.ToCharArray();
		Array.Reverse(charArray);
		return new string(charArray);
	}

	public static bool isPrime(long value)
    {
		for (int i = 2; i < value / 2; i++)
		{
			if ((value % i) == 0)
			{
				return false;
			}
		}
		return true;
	}
	public static List<long> getDivisors(long value)
	{
		List<long> divisors= new() { };
		divisors.Add(value);
		for (int i = 1; i < (value/2)+1; i++)
		{
			if((value % i) == 0)
			{
				divisors.Add(i);
			}
		}
		return divisors;
	}

	public static int getDivisorsCount(long number)
	{
        List<int> primes = new List<int> { };
		long temp = number;
        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                primes.Add(i);
                number /= i;
            }
        }
		Dictionary<int, int> result = GroupAndCount(primes);
		int total = 1;
		foreach (var kvp in result.ToList())
		{
			total = total * (kvp.Value + 1);
		}
		return total;
    }

	public static Dictionary<int, int> GroupAndCount(List<int> numbers)
	{
		Dictionary<int, int> result = new Dictionary<int, int>();
		foreach (int number in numbers)
		{
			if (result.ContainsKey(number))
			{
				result[number]++;
			}
			else
			{
				result[number] = 1;
			}
		}
		return result;
	}

	//	public static int getDivisorsCount(long value)
	//{
	//	int quantity = 1;
	//	for (int i = 1; i < (value / 2) + 1; i++)
	//	{
	//		if ((value % i) == 0)
	//		{
	//			quantity++;
	//		}
	//	}
	//	return quantity;
	//}

	public static string ConvertNumberToWords(int number)
	{
		if (number < 0 || number > 1000)
		{
			throw new ArgumentOutOfRangeException("number", "Number must be between 0 and 1000.");
		}

		if (number < 20)
		{
			return units[number];
		}

		if (number < 100)
		{
			return tens[number / 10] + ((number % 10 != 0) ? " " + units[number % 10] : "");
		}

		if (number < 1000)
		{
			return units[number / 100] + " hundred" + ((number % 100 != 0) ? " and " + ConvertNumberToWords(number % 100) : "");
		}

		return "one thousand";
	}
	static string MultiplyStrings(string number, int multiplier)
	{
		StringBuilder sb = new StringBuilder();
		int carry = 0;

		for (int i = number.Length - 1; i >= 0; i--)
		{
			int digit = int.Parse(number[i].ToString());
			int product = digit * multiplier + carry;
			int remainder = product % 10;
			carry = product / 10;
			sb.Insert(0, remainder.ToString());
		}

		if (carry > 0)
		{
			sb.Insert(0, carry.ToString());
		}

		return sb.ToString();
	}
}