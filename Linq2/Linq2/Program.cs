using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Student
    {
        public string Student_Name { get; set; }
        public string Subject_Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student{Student_Name = "Ерланов Темирлан", Subject_Name = "ОБЖ"},
                new Student{Student_Name = "Танашбаева Роза", Subject_Name = "Химия"},
                new Student{Student_Name = "Серикова Алина", Subject_Name = "Психология"},
                new Student{Student_Name = "Сабыржанов Даулет", Subject_Name = "Философия"},
                new Student{Student_Name = "Каришев Самат", Subject_Name = "Химия"},
                new Student{Student_Name = "Темников Александр", Subject_Name = "Психология"},
                new Student{Student_Name = "Теззекбай Самат", Subject_Name = "Химия"},
                new Student{Student_Name = "Седовласов Юри", Subject_Name = "Психология"},
                new Student{Student_Name = "Джумабаев Алмабек", Subject_Name = "ОБЖ"},
                new Student{Student_Name = "Жумабаева Инкар", Subject_Name = "Философия"},
                new Student{Student_Name = "Казиханов Ерасыл", Subject_Name = "Химия"}

            };

            var result = from student in students          
                         group student by student.Subject_Name into g
                         orderby g.Key
                         select new { Name_of_Subject = g.Key, Count = g.Count() };

            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.Name_of_Subject, item.Count);
            }
                
        }
    }
}
