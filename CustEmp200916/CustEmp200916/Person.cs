﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustEmp200916
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customer : Person
    {

    }

    public class Employee : Person
    {

    }

    public class Supplier : Person
    {

    }
}