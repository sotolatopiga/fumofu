using System;

namespace VCSBasics
{
    class Program
    {

        static int gcd(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            return a;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("First commit is here!");
            Console.WriteLine("Now, I kinda have a new stuff here");
            Console.WriteLine(gcd(15, 175));
        }
        
    }
}