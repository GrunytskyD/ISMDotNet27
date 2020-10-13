using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int count = int.Parse(Console.ReadLine ());
            double result = 0;
            for (int i = 1; i<count; i++)
            {
                result = result = 1D / i;
            }
            Console.WriteLine($"r={result}");
        }
    }
}
