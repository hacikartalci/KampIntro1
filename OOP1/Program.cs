using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35};

            //PascalCase - kelimelerin ilk harfleri büyük olur (Class Case)
            //camelCase - ilk kelime küçük sonraki kelimeler büyük olur 
            //case sensitive - küçük büyük harf duyarlılığı

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product1);

            //int, double, bool (sayısal veriler) değer tip - referans görmez
            //dizi, class, abstract class, interface referans tip - referans görür

        }
    }
}
