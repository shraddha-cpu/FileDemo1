using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDemo1
{
    // [] called attribute in c#
    [Serializable] // this info is to CLR to understand that emp object needs to be serialized
    public class Employee
    {
        
        public int Id { get; set;}
        public string Name { get; set;}
        public int Salary { get; set; }
    }
}
