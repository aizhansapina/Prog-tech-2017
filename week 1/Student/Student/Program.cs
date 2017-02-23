using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        class Student
        {

            private string firstName, lastName;
            private double gpa;

           
            public Student(string firstName, string lastName, double gpa)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gpa = gpa;
            }

            public override string ToString()
            {
                return "First name : " + firstName + "\n" + "Last name : " + lastName + "\n" + "GPA : " + gpa;
            }
        }

        class Sample
        {
            static void Main(string[] args)
            {
                Student student = new Student("Liza", "Koshy", 3.8);

                Console.WriteLine(student);
                Console.ReadKey();
            }
        }
    }
}
