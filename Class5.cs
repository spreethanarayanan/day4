using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Class5
    {
        public int a;
        public int b;

        public void InputX()
        {
            Console.WriteLine("enter number a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number b :");
            Console.WriteLine("sum :" + (a + b));
        }


        public static void Main()
        {
            Class5 obj = new Class5();
            int exitkey = 1;
            while (exitkey > 0)
            {
                Console.WriteLine("You want to exit ? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "n")
                {
                    obj.InputX();
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}



