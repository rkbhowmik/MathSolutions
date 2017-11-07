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
			Console.Write("Numbers between 1 and 50, divisible by 3 : \n");
			for (int i = 1; i <= 50; i++)
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
