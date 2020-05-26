using System;

namespace Lab07
{

    class Student
    {
         string name;
         int age;

        public Student()
        {

        }
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
         void getName()
        {
            Console.WriteLine("Enter your Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
        }

        void Display()
        {
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Age is " + age);
        }

        /* static void Main(string[] args)
        {
            Student student1 = new Student("Jame", 17);
            student1.Display();
            Student student = new Student();
            student.getName();
            student.Display();
        }
        */
    }
}
