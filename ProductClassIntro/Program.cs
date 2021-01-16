using System;

namespace ProductClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Silicon worm";
            product1.ProductSeller = "Jamil C.";
            product1.ProductPurchase = 30;

            Product product2 = new Product();
            product2.ProductName = "Fishing worm";
            product2.ProductSeller = "Christina A.";
            product2.ProductPurchase = 27;

            Product product3 = new Product();
            product3.ProductName = "Horse neck";
            product3.ProductSeller = "Christopher F.";
            product3.ProductPurchase = 821;

            Product product4 = new Product();
            product4.ProductName = "Brightness Light";
            product4.ProductSeller = "Nalan JJ.";
            product4.ProductPurchase = 125;

            Product product5 = new Product();
            product5.ProductName = "Air wash cleaner";
            product5.ProductSeller = "Frankie S.";
            product5.ProductPurchase = 44;




            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            Console.WriteLine("FOREACH DONGUSU BASLIYOR...");

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.ProductSeller + " $" + product.ProductPurchase);
            }


            Console.WriteLine("FOREACH DONGUSU BITTI.");

            Console.WriteLine("FOR DONGUSU BASLIYOR...");

            Product[] productt = new Product[] { product1, product2, product3, product4, product5 };

          //for (int i = 0; i < products.Length; i++)
          //{
          //    Product product = products[i];
          //    Console.WriteLine(product.ProductName + " " + product.ProductSeller + " $" + product.ProductPurchase);
          //}

            Console.WriteLine("FOR DONGUSU BITTI.");

            Console.WriteLine("WHILE DONGUSU BASLIYOR...");

            int i = 0;
            while (i < products.Length)
            {
                Product product = products[i];
                Console.WriteLine(product.ProductName + " " + product.ProductSeller + " $" + product.ProductPurchase);
                i++;
            }

            Console.WriteLine("WHILE DONGUSU BITTI.");

           
        }

        class Product
        {
            public string ProductName { get; set; }
            public string ProductSeller { get; set; }
            public int ProductPurchase { get; set; }
        }
    }
}
