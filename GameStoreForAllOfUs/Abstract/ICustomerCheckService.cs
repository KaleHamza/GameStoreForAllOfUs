﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreForAllOfUs.Abstract
{
    public interface ICustomerCheckService
    {
        void CheckIfRealPerson(Customer customer);
    }
}
