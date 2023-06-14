
using static System.Console;

//OOP stands for Object-Oriented Programming.
//<class name> <object name>=new <class name()>
using c_sharp_oop;

public class Program
{
    public static void Main(string[] args)
    {
      student std1 = new student("omran",27,"d14125555");
        WriteLine("###########################################");
        Teacher teacher = new Teacher("ali", "languages", "omani", 7);
        WriteLine("###########################################");
        Book book = new Book("land of oman", "ahmed ali", 2008);
        WriteLine("###########################################");
        Circle cir = new Circle(3);
        WriteLine("###########################################");
        BankAccount Account = new("14433244", "omar", 2500);
    }
}