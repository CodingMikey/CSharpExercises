using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new list using the Student class and its properties
            var students = new List<Student>();

            //Setting the default value to true 
            var adding = true;

            while (adding)
            {
                //Instantiating a new student object to access and assign its properties
                var newStudent = new Student
                {
                    Name = Util.Console.Ask("Student Name: "),
                    Grade = int.Parse(Util.Console.Ask("Student Grade: ")),
                    Birthday = Util.Console.Ask("Student Birthday: "),
                    Address = Util.Console.Ask("Student Address: "),
                    Phone = int.Parse(Util.Console.Ask("Student Phone: "))
                };

                //Adding students to the newStudent object
                students.Add(newStudent);

                //Accessing the count property created in the student class to keep track of student count
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y")
                    adding = false;
            }
            //This foreach loop prints the newStudents properties for each new student created
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
        }

        static void Import()
        {
           
        }
    }
}
