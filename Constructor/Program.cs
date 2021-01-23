﻿using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Hacı", LastName="Kartalcı", City="İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mustafa";
            customer3.LastName = "Kartalcı";
            customer3.City = "Tekirdağ";

            Customer customer2 = new Customer(2,"Burak", "Kartalcı", "Sivas");

            Console.WriteLine(customer2.FirstName);

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        //Default Constructor
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
