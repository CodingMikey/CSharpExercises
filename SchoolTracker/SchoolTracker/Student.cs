﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    class Student : Member
    {
        //Used to keep track of how many students are added to the tracker
        static public int Count = 0;

        //Student properties for the school tracker
        public int Grade;
        public string Birthday;
        
        public Student()
        {

        }

        //Creating a student constructor
        public Student(string name, int grade, string birthday, string address, int Phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }
    }
}
