using System;

namespace test
{
    internal class Program
    {
        public const int Branch = 1;
        
        public static void Main(string[] args)
        {
            Console.Out.WriteLine($"Is this branch {Branch}?");
            if (Branch == 1)
            {
                Console.Out.WriteLine("Yes, it's brach 1.");
            }

            Console.Out.WriteLine("Br1 updated.");
        }
    }
}