using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Product
    {
            int productId { get; set; }
            string productName { get; set; }
            int productQuantity { get; set; }
            double productPrice { get; set; }
    
       
        public Product()
            {
            Console.WriteLine(" enter product ID");
            productId = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" enter product NAME");
            productName = Console.ReadLine();
            
            Console.WriteLine(" enter product QUANTITY");
            productQuantity = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(" enter product PRICE");
            productPrice = Convert.ToInt32(Console.ReadLine());
            

            }
            

            public void details()
            {
                Console.WriteLine("product id :" + productId);
                Console.WriteLine("product name :" + productName);
                Console.WriteLine("product quantity :" + productQuantity);
                Console.WriteLine("product price :" + productPrice);
                Console.WriteLine("total:" + (productQuantity + productPrice));
            }
             public void Main()
            {
                Product pro = new Product();
                pro.details();
            Console.ReadLine();
            }
        }
    }


