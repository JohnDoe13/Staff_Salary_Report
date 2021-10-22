using System;
using System.Text;
using System.IO;

namespace Staff_Salary_Report
{
    /*
    The objective of this program is to show salary for each employee.
    It takes two input (employee and salary) and then displays it.
    */
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of variable and object.
            int num;
            

            var emp = new Employee();
            
                Console.WriteLine("How many employees?");
                            num = int.Parse(Console.ReadLine());
            try
            {
                if (num <= 0)
                                {
                                    Console.WriteLine("Something went wrong.");
                                    //throw new Exception ("Number must be greater than 0 'zero'");
                                }
                string[] sname = new string[num];
                int[] isalary = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Name of employee?");
                    emp.Name = Console.ReadLine();
                    sname[i] = emp.Name;

                    Console.WriteLine("Salary?");
                    emp.Salary = int.Parse(Console.ReadLine());
                    isalary[i] = emp.Salary;


                    //Console.WriteLine(myname);

                    int sum = 0;
                    for (int j = 0; j < num; j++)
                    {
                        //Console.WriteLine($"Name {emp.Name}, Salary {emp.Salary}");
                        Console.WriteLine($"Name: {sname[j]}, Salary: {isalary[j]}.");
                        sum += isalary[j];


                    }

                    Console.WriteLine($"Sum of salary {sum}.");

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Number must be greater than 0 'zero'");
                //throw new Exception ("Something went wrong");
                //Här vill jag fortsätta programmet med någonslags Resume/Continue.

            }
            finally
            {
                Console.WriteLine("Want to resume program execution here.");
            }

            //Input

            //Variable 'num' is used to size the array.

            //Output of employee(s) and salary.

            //string fname = Console.WriteLine("Enter your name:");







        }
    }
}
