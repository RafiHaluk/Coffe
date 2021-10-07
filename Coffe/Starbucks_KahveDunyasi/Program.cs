using System;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Managers;
using Starbucks_KahveDunyasi.MernisAdapter;
using ServiceReference;

namespace Starbucks_KahveDunyasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainCustomerManager mainCustomer = new StarbucksCustomerManager(new MernisServiceAdapter());
            mainCustomer.Save(new Customers{BirthData = new DateTime(1997,7,23),
                FirstName = "Haluk",Id = 544127,LastName = "DEDE",NationalityId = 25120035558});
            Console.ReadLine();
        }
    }
}