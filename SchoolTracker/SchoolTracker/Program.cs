using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    //School list in enum
    enum School
    {
        ReedCollege,
        PSU,
        OSU 

    }

    class Program
    {
        //Creating a new list using the Student class and its properties. Placing outside of main to be avialble anywhere in app
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            PayRoll payroll = new PayRoll();
            payroll.PayAll();

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
                        School = (School) Util.Console.AskInt("School name (type corresponding number): \n 0: Reed College \n 1: PSU \n 2: OSU \n"),
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
            //Calling the export method to display what schools will get records
            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "birthday", "address", 503);
            Console.WriteLine(importedStudent.Name);

        }

        //Whatever school the user selects the switch statement below will highlight what school gets the records
        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case School.ReedCollege:
                        Console.WriteLine("Exporting to Reed College");
                            break;
                    case School.PSU:
                        Console.WriteLine("Exporting to PSU");
                            break;
                    case School.OSU:
                        Console.WriteLine("Exporting OSU");
                            break;
                            
                }
            }
        }
    }
}
