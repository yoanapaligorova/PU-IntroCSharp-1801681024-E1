using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
			double sum = 0;
			Console.WriteLine("Enter number1");
			double numberOne = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter number2:");
			double numbreTwo = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter operation");
			char operation = char.Parse(Console.ReadLine());
			if (operation == '+')
			{
				sum = numberOne + numbreTwo;
				sum = sum * (10/100);
				Console.WriteLine("Result :" + sum);
			}
			if (operation == '-')
			{
				if (numberOne > numbreTwo)
				{
					sum = (numberOne * numberOne) - numbreTwo;
					Console.WriteLine("Result :" + sum);
				}
				else
				{
					sum = (numbreTwo * numbreTwo) - numberOne;
					Console.WriteLine("Result :" + sum);
				}
			}
			if (operation == '*')
			{
				sum = numberOne * Math.Sqrt(numbreTwo);
				Console.WriteLine("Result :" + sum);
			}
			if (operation == '/')
			{
				if (numbreTwo == 0) break;
			
			    if(numbreTwo!=0)
				{
				sum = numberOne / numbreTwo;
					Console.WriteLine("Result :" + sum);

				}
				
			
			}
		}
    }
}
