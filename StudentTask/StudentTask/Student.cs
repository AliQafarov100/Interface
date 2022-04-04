using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTask
{
    class Student
    {
        public string FullName;
        public string GroupNo;
        public double AvgPoint;

        public Student(string fullname)
        {
            FullName = fullname;
        }

        public void AllInfo()
        {
            Console.WriteLine($"Fullname: {FullName} | Group no: {GroupNo} | Avg point: {AvgPoint}");
        }
    }
}
