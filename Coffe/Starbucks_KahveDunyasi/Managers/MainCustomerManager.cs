using System;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Interfaces;

namespace Starbucks_KahveDunyasi.Managers
{
    public abstract class MainCustomerManager: ICustomerService

    {
        public virtual void Save(Customers customers)
        {
            Console.WriteLine("Saved to DataBase" + customers.NationalityId);
        }
    }
}