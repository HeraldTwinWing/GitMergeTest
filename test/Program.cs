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
                Console.Out.WriteLine("Yes, it's branch 1.");
            }
            else
            {
                Console.Out.WriteLine("No, it isn't branch 1.");
            }

            Console.Out.WriteLine("Br1 updated.");
        }

        public int func()
        {
            return 0;
        }
    }
}