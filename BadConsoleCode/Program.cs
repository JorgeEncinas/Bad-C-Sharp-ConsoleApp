using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BadConsoleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //Variables that won't ever be used
            int y = 2;
            Console.WriteLine("Hello World!");
            Console.WriteLine("Fool, you have fallen into my infinite loop trap!");
            Console.WriteLine("We'll be here forever and ever...");
            for (int i = 0; i < i+1; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("And ever...");
            }
        }
    }
}
