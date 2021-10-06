using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staff_Salary_Report
{
    public class Employee
    {
        //public int NumOfStaff { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public void PrintEmployee()
        {
            Console.WriteLine($"Name {Name}, Salary {Salary}.");
        }

        
    }
}
