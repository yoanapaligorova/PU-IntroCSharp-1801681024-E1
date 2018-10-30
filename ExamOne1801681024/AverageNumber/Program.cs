using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
			List<int>evenNumbers=new List<int>();
			
			Console.WriteLine("Enter number between 0 and 255");
			bool isZero = false;
			while (!isZero)
			{
				Console.WriteLine("Enter number:");
				int currenNumber = int.Parse(Console.ReadLine());
				if (currenNumber == 0) break;
				if (currenNumber % 2 == 0) evenNumbers.Add(currenNumber);
				
			}
			if (evenNumbers.Count > 0)
			{
				Console.WriteLine( $"Toatal even numbers{evenNumbers.Count}=> Avarage sum{evenNumbers.Average()}");
			}
			else
			{
				Console.WriteLine($"Press any key to continue");

			}

		}
    }
}
