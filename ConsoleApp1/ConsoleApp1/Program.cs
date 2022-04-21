using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = RandomToApply();
            Console.WriteLine("Hello World!");
        }
        public static float GetApplyChance(int level)
        {
            return level;
        }
        public static bool RandomToApply()
        {
            return 0 <= GetApplyChance(10);
        }
    }
}
