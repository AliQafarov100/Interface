using System;

namespace StudentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string No;
            int StudentLimit;

            do
            {
                Console.WriteLine("Enter your group: ");
                No = Console.ReadLine();
            } while (!(Group.CheckNo(No) && No.Length == 5));

            do
            {
                Console.WriteLine("Enter student limit in group: ");
                StudentLimit = int.Parse(Console.ReadLine());
                if (StudentLimit < 0 || StudentLimit > 20)
                {
                    Console.WriteLine("Student limit mustn't more than 20 and less than 0");
                    Console.WriteLine("Enter student limit in group: ");
                    StudentLimit = int.Parse(Console.ReadLine());
                }
            } while (StudentLimit < 0 || StudentLimit > 20);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

            bool returns = true;

            do
            {
                Console.WriteLine("1.Add Student \n2.To watch all student \n3.Search in student \n0.Application the end");
                Console.WriteLine("Choose one of keyboard: ");
                short choose = short.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                    case 2:
                        Console.WriteLine("Enter student Fullname: ");
                        string fullName = Console.ReadLine();
                        Student student = new Student(fullName);
                        student.FullName = fullName;
                        student.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student.AvgPoint = double.Parse(Console.ReadLine());
                            if (student.AvgPoint < 0 || student.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student.AvgPoint < 0 || student.AvgPoint > 100);
                       
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.WriteLine("Enter student Fullname: ");
                        string fullName1 = Console.ReadLine();
                        Student student1 = new Student(fullName1);
                        student1.FullName = fullName1;
                        student1.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student1.AvgPoint = double.Parse(Console.ReadLine());
                            if (student1.AvgPoint < 0 || student1.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student1.AvgPoint < 0 || student1.AvgPoint > 100);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.WriteLine("Enter student Fullname: ");
                        string fullName2 = Console.ReadLine();
                        Student student2 = new Student(fullName2);
                        student2.FullName = fullName2;
                        student2.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student2.AvgPoint = double.Parse(Console.ReadLine());
                            if (student2.AvgPoint < 0 || student2.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student2.AvgPoint < 0 || student2.AvgPoint > 100);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Group group = new Group();
                        group.AddStudent(student);
                        group.AddStudent(student1);
                        group.AddStudent(student2);

                        Console.WriteLine("Count student: " + group.Count);
                        if (group.Count < StudentLimit)
                        {
                            foreach (var item in group.students)
                            {
                                item.AllInfo();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Imposible add student because number of student more than student limit");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter student Fullname: ");
                        string fullName3 = Console.ReadLine();
                        Student student3 = new Student(fullName3);
                        student3.FullName = fullName3;
                        student3.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student3.AvgPoint = double.Parse(Console.ReadLine());
                            if (student3.AvgPoint < 0 || student3.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student3.AvgPoint < 0 || student3.AvgPoint > 100);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.WriteLine("Enter student Fullname: ");
                        string fullName4 = Console.ReadLine();
                        Student student4 = new Student(fullName4);
                        student4.FullName = fullName4;
                        student4.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student4.AvgPoint = double.Parse(Console.ReadLine());
                            if (student4.AvgPoint < 0 || student4.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student4.AvgPoint < 0 || student4.AvgPoint > 100);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Console.WriteLine("Enter student Fullname: ");
                        string fullName5 = Console.ReadLine();
                        Student student5 = new Student(fullName5);
                        student5.FullName = fullName5;
                        student5.GroupNo = No;
                        do
                        {
                            Console.WriteLine("Enter avg point of student: ");
                            student5.AvgPoint = double.Parse(Console.ReadLine());
                            if (student5.AvgPoint < 0 || student5.AvgPoint > 100)
                            {
                                Console.WriteLine("Avg point must more than zero and less or equal 100");
                            }
                        } while (student5.AvgPoint < 0 || student5.AvgPoint > 100);

                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~");

                        Group group1 = new Group();
                        group1.AddStudent(student3);
                        group1.AddStudent(student4);
                        group1.AddStudent(student5);

                        Console.WriteLine("Enter fullname student which search you: ");
                        string fullname = Console.ReadLine();
                         foreach (var item in group1.students)
                         {
                            if(item.FullName == fullname)
                            {
                                item.AllInfo();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            }

                            else
                            {
                                Console.WriteLine("Such a student there is not");
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                            }
                            break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Application the end!");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                    default:
                        Console.WriteLine("Enter number in interval 0 and 3");
                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        break;
                }

            } while (returns);
        }
    }
}
