using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        public abstract class Employee
        {
            String Id, Name, Designation, Experience, AnnualSalary, JoiningDate;
            public abstract void salary();
        }

        public class HR : Employee
        {
            public override void salary()
            {
                int basic = 8000;
                String exp = Console.ReadLine();
                int exper = Convert.ToInt16(exp);
                
                int total = (basic + (exper * 1000));
                Console.WriteLine("Salary of HR is" + total);
                Console.WriteLine(" ");
            }
        }


        public class Developer : Employee
        {
            public override void salary()
            {
                int basic = 8000;
                String exp = Console.ReadLine();
                int exper = Convert.ToInt16(exp);
               
                int total = (basic + (exper * 2000));
                Console.WriteLine("Salary of Developer is" + total);
                
            }
        }

        static void Main(string[] args)
        {
            Employee e;

            e = new HR();
            Console.WriteLine("Enter experiece year of HR");
            e.salary();


            e = new Developer();
            Console.WriteLine("Enter experiece year of Developer");
            e.salary();
        }
    }
}
