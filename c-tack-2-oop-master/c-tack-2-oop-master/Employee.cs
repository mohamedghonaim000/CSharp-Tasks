using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace oop_assigment_02
{
    enum securityprivileges
    {
        guest, Developer, secretary , DBA
    }
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private securityprivileges Securitylevel { get; set; }
        public int Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        private char Gender; 
        public char _gender {
            get { return Gender;  }
            
            set {
                if (value == 'M' || value == 'F')
                    Gender = value;
                else { Console.WriteLine("enter a valid gender"); }
            } 
        }

        public Employee(int id, string name,  int salary,  char gender)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Gender = gender;
        }
        public void Assignsecuritylevel(securityprivileges input) {
            Securitylevel = input;  
        }

        public override string ToString()
        {
            return $"id : {Id}  name : {Name}  slary : {Salary} Gender : {Gender} securitylevel : {Securitylevel} ";
        }
    }
}
