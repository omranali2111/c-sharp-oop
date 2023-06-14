using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace c_sharp_oop
{
    public class student
    {
        public string name;
        public int age;
        public string id;
        public student() { }
        public student(string name,int age,string id) 
        { 
            this.name=name;
            this.age=age;
            this.id=id;
            printDetails();
            attendance();
        }
        
       public void attendance() 
        
        {
            int attende = 20;
            int absence = 3;


            WriteLine("stdent attends {0} class and {1} did not attends", attende, absence);
        
        }
        public void printDetails()
        {
            WriteLine("student detailes is:");
            WriteLine("student name is " + this.name);
            WriteLine("student age is " + this.age);
            WriteLine("student id is " + this.id);
        }
        
    }
}
