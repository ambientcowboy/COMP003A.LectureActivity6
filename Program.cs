using System;
using Console = System.Console;

namespace COMP003A.LectureActivity6
{
    class Program
    {
        static void Main(string[] args)
        {
                /*Each Student object has its own data as to create separate
                instances of Name,Age. Allowing programmer to change fields of either
                without affecting the other object
                    */
                Student student1 = new Student("Bob", 32);
                Student student2 = new Student("Jack", 20);
                student1.DisplayInfo();
                student2.DisplayInfo();
                /*The Student class manages student data
                 outside of Main code interacts with student objects through public wihout needing to manage within Main itself
                 */
        }
    }
}

namespace COMP003A.LectureActivity6
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
        /*DisplayInfo is handled in the Student class,
         therefore Main simply need to call it*/
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}