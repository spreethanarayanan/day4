using System;
using System.Collections.Generic;
using System.Text;

namespace day4
{
    class Person
    {
        int Age;
        public void Greet()
        {
            Console .WriteLine("hello!")
        }
        public void SetAge()
        {
            Console.WriteLine("enter the age")
            Age = Convert.ToInt32(Console.ReadLine());

        }

    }
    class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void showage()
        {
            Console.WriteLine("My age is: "+ age+ "years");
        }
    }
    class Professor:Person
    {
        
        public Explain()
        {
            Console.WriteLine("I am explaining");
        }
    }
    class StudentProfessorTest
    {
        
        public  static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.showage();
            Professor professor = new Professor();
            professor.SetAge();
            professor.Greet();
            professor.Explain();
            Console.ReadLine();
        }
    }
   


}
