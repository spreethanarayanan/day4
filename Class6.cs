using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Class6
    {
        public static void Main()
        {
            Console.WriteLine("enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            int y;
            try
            {
                y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("some error have occured ");
            }
            Console.ReadLine();
        }
    }
}
