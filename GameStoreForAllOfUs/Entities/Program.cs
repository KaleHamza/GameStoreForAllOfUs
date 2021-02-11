using System;
using GameStoreForAllOfUs.Abstract;
using GameStoreForAllOfUs.Concrate;

namespace GameStoreForAllOfUs
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager customerManager = new GameCustomerManager();

            customerManager.Save(new Customer
            {
                DateOfBirth = new DateTime(2001),
                FirstName = " Hamza",
                LastName = "Kale",
                NationalityId = "12121212121"
            }) ;
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
