using System;
using System.Collections.Generic;

namespace HW_8
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Dispatch { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            var results = ran.Next(0, 2);
            bool x = true;
            for (int i=0;i<2;i++)
            {
                if(results==0)
                {
                    x = false;
                }
                else
                {
                    x = true;
                }
            }    
            Queue<Student> students = new Queue<Student>();
            students.Enqueue(new Student { Name = "Sam", Surname = "Robin", Dispatch = x });
            students.Enqueue(new Student { Name = "Tom", Surname = "Koshkin", Dispatch = x });
            students.Enqueue(new Student { Name = "Olga", Surname = "Kudrina", Dispatch = x });
            students.Enqueue(new Student { Name = "Masha", Surname = "Trelina", Dispatch = x });

            foreach (var std in students)
            {
                if (std.Dispatch == true)
                {
                    Console.WriteLine($"Student  {std.Name} {std.Surname}  sent homework and get coffee");
                }
                else
                {
                    Console.WriteLine($"Student {std.Name} {std.Surname}  didn’t submit homework and didn’t get coffee");
                }
                Console.WriteLine();
            }

        }
    }
}
