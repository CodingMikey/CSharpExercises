﻿using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        //Creating a new list using the Student class and its properties
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            

            //Setting the default value to true 
            var adding = true;

            while (adding)
            {
                try
                {
                    //Instantiating a new student object to access and assign its properties
                    var newStudent = new Student
                    {
                        Name = Util.Console.Ask("Student Name: "),
                        Grade = Util.Console.AskInt("Student Grade: "),
                        School = Util.Console.AskInt("School name (type corresponding number): \n 0: Reed College \n 1: PSU \n 2: OSU \n"),
                        Birthday = Util.Console.Ask("Student Birthday: "),
                        Address = Util.Console.Ask("Student Address: "),
                        Phone = Util.Console.AskInt("Student Phone: ")
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

                //Using a custom exception from the utility class
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {

                    Console.WriteLine("Error adding student, please try again. ");
                }
            }
            //This foreach loop prints the newStudents properties for each new student created
            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 503);
            Console.WriteLine(importedStudent.Name);

        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case 0:
                        Console.WriteLine("Exporting to Reed College");
                            break;
                    case 1:
                        Console.WriteLine("Exporting to PSU");
                            break;
                    case 2:
                        Console.WriteLine("Exporting OSU");
                            break;
                            
                }
            }
        }
    }
}
