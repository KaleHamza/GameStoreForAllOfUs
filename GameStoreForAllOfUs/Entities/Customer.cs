using System;
using System.Collections.Generic;
using System.Text;
using GameStoreForAllOfUs.Abstract;
using GameStoreForAllOfUs.Entities;

namespace GameStoreForAllOfUs
{
    public class Customer:FirstPerson
    {         
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
