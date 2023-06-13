using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
/*
Exercise 1: Creating a Book Class
Create a Book class with the following properties:
Title(string)
Author(string)
Year(int)
Implement the default constructor and a parameterized constructor that takes values for all the properties.

*/
namespace c_sharp_oop
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Years;

        public Book(string Title, string Author, int Years) 
        {
            WriteLine("book name is " + this.Title);
            WriteLine("book name is " + this.Author);
            WriteLine(this.Title + " is published in " + this.Years);
        }
    }
}
