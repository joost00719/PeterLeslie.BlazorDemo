using System;
using System.Collections.Generic;

namespace App
{
    public class SimpleCustomer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class ComplexCustomer : SimpleCustomer
    {
        public Company Company { get; set; }
    }

    public class Company
    {
        public List<SimpleCustomer> Customers { get; set; }
    }
}
