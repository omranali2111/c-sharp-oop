using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace c_sharp_oop
{
    public class Teacher
    {
      public  string name;
      public string subject;
      public string athnicity;
      public int yearsExperiance;

        public Teacher(string name,string subject,string athnicity,int yearsExperiance) 
        { 
            this.name = name;
            this.subject = subject;
            this.athnicity = athnicity;
            this.yearsExperiance= yearsExperiance;
            printDetails();
            langus();


        }
        public void printDetails()
        {
            WriteLine("teacher name is " + this.name);
            WriteLine("he teachs " + this.subject);
            WriteLine(this.name + " is " + this.athnicity);
            WriteLine(this.name + " have " + this.yearsExperiance + "years of Experiance");
        }

        public void langus()
        {
            WriteLine(name + " teachs 3 languages");
        }
    }

    
}
