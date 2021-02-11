using System;
using System.Collections.Generic;
using System.Text;
using GameStoreForAllOfUs.Abstract;

namespace GameStoreForAllOfUs.Concrate
{
    public class GameCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public GameCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public GameCustomerManager()
        {
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a vaild Person.");
            }
        }

        public  void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "is a deleted." );
        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + "is a updated.");
        }

        public override void CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}







