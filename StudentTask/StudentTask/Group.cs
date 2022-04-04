using System;
using System.Collections.Generic;
using System.Text;

namespace StudentTask
{
    class Group
    {
        public string No;
        public Student[] students;
        public int StudentLimits;

        public int Count { get => students.Length; }
        public Group()
        {
            students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public static bool CheckNo(string No)
        {
            int count = 0;
            foreach(char lett in No)
            {
                if (char.IsDigit(lett))
                {
                    count++;
                    if(count == 3)
                    {
                        return true;
                    }
                }
                if (char.IsUpper(No[0]) && char.IsUpper(No[1]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}


