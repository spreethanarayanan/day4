using System;
using Assembly;

namespace day4
{
    class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            Console.WriteLine(class1.sum(1, 2));
            Console.WriteLine(class1.sub(1, 2));
            Console.WriteLine(class1.mul(1, 2));
            Console.WriteLine(class1.div(1, 2));
            Console.ReadLine();

        }
    }
}
