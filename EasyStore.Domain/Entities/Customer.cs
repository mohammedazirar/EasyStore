﻿using System.Collections.Generic;
using EasyStore.Domain.ValueObjects;

namespace EasyStore.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}