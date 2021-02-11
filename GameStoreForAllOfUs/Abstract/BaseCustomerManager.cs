using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreForAllOfUs.Abstract
{
    public abstract class BaseCustomerManager:ICustomerService
    {
        public abstract void CheckIfRealPerson(Customer customer);

        public virtual void Save(Customer customer)
        { 
            Console.WriteLine("Saved to db" +customer.FirstName);
        }
    
    }

}
