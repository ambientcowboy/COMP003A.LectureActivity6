using System;

namespace COMP003A.LectureActivity6
{
    class Program
    {
        public class Student
        {
            public string Name;
            public int Age;

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        static void Main(string[] args)
        {
            Student student1 = new Student("Bob", 32);
            Student student2 = new Student("Jack", 20);
            student1.DisplayInfo();
            student2.DisplayInfo();
        }
    }
}