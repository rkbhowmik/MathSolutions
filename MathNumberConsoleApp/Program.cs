using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathNumberConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			Console.WriteLine("***** This program will take an input to set a range.\nThen it will display all the numbers which are divisible by 3 and their summation ******");
			Console.Write("\n\nInput a numbers to set the range: ");
			var input = int.Parse(Console.ReadLine());
			for (int i = 1; i <= input; i++)
			{
				if (i % 3 == 0)
				{
					Console.Write("{0}  ", i);
					sum += i;
				}
			}

			Console.Write("\n\nThe sum : {0} \n", sum);
			Console.ReadLine();
		}
	}
}
