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
            Queue<Student> students = new Queue<Student>();
            students.Enqueue(new Student { Name = "Sam", Surname = "Robin", Dispatch = true });
            students.Enqueue(new Student { Name = "Tom", Surname = "Koshkin", Dispatch = false });
            students.Enqueue(new Student { Name = "Olga", Surname = "Kudrina", Dispatch = false });
            students.Enqueue(new Student { Name = "Masha", Surname = "Trelina", Dispatch = true });

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
