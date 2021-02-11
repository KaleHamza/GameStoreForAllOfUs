using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreForAllOfUs.Abstract
{
    interface CompaignManager
    {
        public void Add(Customer customer);

        public void Delete(Customer customer);

        public void Update(Customer customer);
    }
}
