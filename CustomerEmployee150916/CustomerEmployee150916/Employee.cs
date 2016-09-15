using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerEmployee150916
{
    class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }


        public string FullName
        {
            get
            {
                return string.Format("{1}, {0}", FirstName, LastName);
            }
        }
    }
}
