
using static System.Console;

//OOP stands for Object-Oriented Programming.
//<class name> <object name>=new <class name()>
using c_sharp_oop;

public class Program
{
    public static void Main(string[] args)
    {
      student std1 = new student();
        std1.name = "omran";
        std1.age = 27;
        std1.id = "d14125555";

        WriteLine("student name is "+ std1.name);
        WriteLine("student age is " + std1.age);
        WriteLine("student id is " + std1.id);

        std1.attendance();



    }
}