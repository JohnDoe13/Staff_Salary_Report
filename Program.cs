using System;
using System.Text;
using System.IO;

namespace Staff_Salary_Report
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            var emp = new Employee();

            
            Console.WriteLine("How many employees?");
            num = int.Parse(Console.ReadLine());
           // Console.WriteLine(num);

            string[] sname = new string[num];
            int [] isalary=new int [num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Name of employee?");
                            emp.Name = Console.ReadLine();
                sname[i] = emp.Name;
                            
                Console.WriteLine("Salary?");
                            emp.Salary = int.Parse(Console.ReadLine());
                isalary[i] = emp.Salary;
                

                //Console.WriteLine(myname);
                
                
               
            }

            for (int j = 0; j < num; j++)
            {
                //Console.WriteLine($"Name {emp.Name}, Salary {emp.Salary}");
                Console.WriteLine($"Name {sname[j]}, Salary {isalary[j]}.");
               

            }

            //string fname = Console.WriteLine("Enter your name:");







        }
    }
}
