using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Exercise 4: Creating a Employee Class
Create an Employee class with the following properties:

Name(string)
Position(string)
Salary(double)
Implement the default constructor and a parameterized constructor that takes values for all the properties. 
*/
namespace c_sharp_oop
{
    public class Employee
    {
        public string Name;
        public string position;
        public double Salary;

        public Employee() { }
        public Employee(string Name, string position, double Salary) 
        { 
            this.Name = Name;
            this.position = position;
            this.Salary = Salary;
            printInfo();
        }

        public void printInfo()
        {
            Console.WriteLine("Employee name is " + this.Name);
            Console.WriteLine("Employee position is " + this.position);
            Console.WriteLine("Employee Salary is " + this.Salary);
        }



    }
}
