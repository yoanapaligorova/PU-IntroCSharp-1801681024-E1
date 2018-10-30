using System;

namespace RectagleArea
{
    class Program
    {
        static void Main(string[] args)
        {
			double area = 0;
            Console.WriteLine("Find a Rectangle area");
			Console.WriteLine("Enter a:");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter b:");
			double b = double.Parse(Console.ReadLine());
			area = a * b;
			Console.WriteLine("Rectangle area is " + area);
		}
	}
}
