using System;

namespace oop_assigment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(66, "mohamed", 4555, 'M');
            e1.Assignsecuritylevel(securityprivileges.Developer);
            e1.HiringDate = new HiringDate(12, 12, 2024);
            Console.WriteLine(e1.ToString());

            Employee[] emp = new Employee[] {
               new Employee(1, "mohamed", 6000, 'F'),
               new Employee(2, "ahmed", 4000, 'M'),
               new Employee(3, "ali", 7000, 'M'),
            };

            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine(emp[i]);
            }

        }
    }
}
