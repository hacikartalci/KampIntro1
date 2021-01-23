using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Hacı", "Halil", "Yusuf", "Mert"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Samet";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //stack - referans, değer, eşitliğin solu 
            //heap  - referans, eşitliğin sağı
            //Ctrl + K Ctrl + C seçtiğin kısmı comment yapar, Ctrl + K Ctrl + U seçtiğin kısmı commentten çıkarır.

            List<string> isimler2 = new List<string> { "Hacı", "Halil", "Yusuf", "Mert" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Samet");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
