
using static System.Console;

//OOP stands for Object-Oriented Programming.
//<class name> <object name>=new <class name()>
using c_sharp_oop;

public class Program
{
    public static void Main(string[] args)
    {
      student std1 = new student("omran",27,"d14125555");
      
       WriteLine("student name is "+ std1.name);
        WriteLine("student age is " + std1.age);
        WriteLine("student id is " + std1.id);

        std1.attendance();

        Teacher teacher = new Teacher("ali", "languages", "omani", 7);
       
        WriteLine("teacher name is " + teacher.name);
        WriteLine("he teachs " + teacher.subject);
        WriteLine(teacher.name + " is " + teacher.athnicity);
        WriteLine(teacher.name + " have " + teacher.yearsExperiance + "years of Experiance");

        teacher.langus();
    }
}