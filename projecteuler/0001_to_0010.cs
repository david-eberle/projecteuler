using System;
using System.Collections.Generic;
using System.Linq;
public partial class Program
{
	public static void Exercise0001()
	{
		int acum = 0;
		for (int i = 0; i < 1000; i++)
			if (((i % 3) == 0) || ((i % 5) == 0))
				acum += i;
		Console.WriteLine(acum);
	}
	public static void Exercise0002()
	{
		int n1 = 1, n2 = 2, temp = 1, acum = 0;
		while (n2 < 4000000)
		{
			if (((n2 % 2) == 0))
				acum += n2;
			temp = n1;
			n1 = n2;
			n2 = temp + n1;
		}
		Console.WriteLine(acum);
	}
	public static void Exercise0003()
	{
		List<long> primes = new() { };
		long value = 600851475143;
		int divisor = 2;
		while (value > 1)
		{
			while ((value % divisor) == 0)
			{
				primes.Add(divisor);
				value = value / divisor;
				divisor++;
			}
			divisor++;
		}
		Console.WriteLine("LPF found:" + primes.LastOrDefault().ToString());
	}
	public static void Exercise0004()
	{
		int value = 0;
		int temp;
		for (int i = 999; i > 1; i--)
		{
			for (int j = i; j > 1; j--)
			{
				temp = i * j;
				if (temp == Convert.ToInt32(Reverse(temp.ToString())))
				{
					if (value == 0)
					{
						value = temp;
					}
					else
					{
						if (temp > value)
						{
							value = temp;
						}
					}
				}
			}
		}
		Console.WriteLine("Value found:" + value.ToString());
	}
	public static void Exercise0005()
	{
		bool found = false;
		long value = 21;
		while (!found)
		{
			for (int i = 1; i <= 20; i++)
			{
				if ((value % i) != 0)
					break;
				found = true;
			}
			if (!found)
				value++;
		}
		Console.WriteLine("Value found:" + Convert.ToString(value));
	}
	public static void Exercise0006()
	{
		int sumOfSquares = 0;
		int sumOfNaturals = 0;
		for (int i = 1; i < 101; i++)
		{
			sumOfSquares += (i * i);
			sumOfNaturals += i;
		}
		Console.WriteLine("Value found:" + Convert.ToString((sumOfNaturals * sumOfNaturals) - sumOfSquares));
	}
	public static void Exercise0007()
	{
		int position = 1;
		int value = 2;
		while (position <= 10001)
		{
			value++;
			if (isPrime(value))
			{
				//Console.WriteLine("Position:" + Convert.ToString(position) + ", value: " + value.ToString());
				position++;
			}
		}
		Console.WriteLine("Value found:" + Convert.ToString(value));
	}
	public static void Exercise0008()
	{
		string digits = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
		int numbersOfDigits = 13;
		long max = 0;
		for (int i = 0; i <= digits.Length - numbersOfDigits; i++)
		{
			long temp = 1;
			for (int j = 0; j < numbersOfDigits; j++)
			{
				temp = temp * Convert.ToInt32(digits.Substring(i + j, 1));
			}
			if (temp > max)
			{
				//Console.WriteLine("New max found: " + temp.ToString() + ", values: " + digits.Substring(i, numbersOfDigits));
				max = temp;
			}
		}
		Console.WriteLine("Value found:" + Convert.ToString(max));
	}
	public static void Exercise0009()
	{
		long product = 0;
		for (int a = 1; a < 500; a++)
		{
			for (int b = a + 1; b < 500; b++)
			{
				for (int c = b + 1; c < 500; c++)
				{
					if ((a * a) + (b * b) == (c * c))
					{
						if (a + b + c == 1000)
						{
							product = a * b * c;
							a = 500;
							b = 500;
							c = 500;
						}
					}

				}
			}
		}
		Console.WriteLine("Value found:" + Convert.ToString(product));
	}
	public static void Exercise0010()
	{
		long sum = 2;
		int value = 2;
		while (value < 2000000)
		{
			Console.WriteLine("analizing: " + value.ToString());
			value++;
			if (isPrime(value))
			{
				sum += value;
				//Console.WriteLine("New prime added ("+value.ToString()+"): " + sum.ToString());
			}
		}
		Console.WriteLine("Value found:" + Convert.ToString(sum));
	}

}