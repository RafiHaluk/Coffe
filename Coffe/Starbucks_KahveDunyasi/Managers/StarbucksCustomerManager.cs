using System;
using Starbucks_KahveDunyasi.Individuals;
using Starbucks_KahveDunyasi.Interfaces;

namespace Starbucks_KahveDunyasi.Managers
{
    public class StarbucksCustomerManager : MainCustomerManager
    {
        private IMernisCheck _mernisCheck;

        public StarbucksCustomerManager(IMernisCheck mernisCheck)
        {
            _mernisCheck = mernisCheck;
        }
        

        public override void Save(Customers customers)
        {
            if (_mernisCheck.CheckIfActualPerson(customers))
            {
                base.Save(customers);
            }
            else
            {
                throw new Exception("Not Valid Person");
            }
            
        }

        
    }
}