using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Product
    {
        int SerialNo { get; set; }
        string productName { get; set; }
        int productQuantity { get; set; }
        double productPrice { get; set; }
        public void input()
        {
            Console.WriteLine(" enter serialNo");
            SerialNo = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i< SerialNo; i++)
            {
                Console.WriteLine(" enter product NAME");
                productName = Console.ReadLine();

                Console.WriteLine(" enter product QUANTITY");
                productQuantity = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(" enter product PRICE");
                productPrice = Convert.ToDouble(Console.ReadLine());
            }
        }


        public void total()
        {
            for (int i = 0; i < SerialNo; i++)
            {
                Console.Write("total:" + (productQuantity + productPrice));
            }
        }

        public int x = 0;
        public void details()
        {
            Console.Write("product id :" + productId);
            Console.WriteLine("product name :" + productName);
            Console.WriteLine("product quantity :" + productQuantity);
            Console.WriteLine("product price :" + productPrice);
            Console.WriteLine("total:" + (productQuantity + productPrice));
        }
        public void invoice()
        {

        }
        public static void Main()
        {
            Product pro = new Product();
            pro.details();
            Console.ReadLine();
        }
    }
}

