using System;
using System.Collections.Generic;
using System.Text;
using GameStoreForAllOfUs.Abstract;

namespace GameStoreForAllOfUs.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
            //Maalesef Mernisi bağlayamadım .
        }
    }
}
