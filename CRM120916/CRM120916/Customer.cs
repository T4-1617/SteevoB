using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM120916
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int ID { get; set; }

        public bool Active { get; set; }

        public string FullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
