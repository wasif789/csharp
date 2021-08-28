using System;

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter second number");
            double b = Convert.ToDouble(Console.ReadLine());
            double sum = (a + b);
            Console.WriteLine("sum is :" + sum);

        }
    }
}
