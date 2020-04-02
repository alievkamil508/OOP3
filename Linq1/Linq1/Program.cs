using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    class Teachers
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }
    class Students : Teachers
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Teachers> teachers = new List<Teachers>()
            {
                new Teachers{Surname = "Суворов", Name = "Антон", Age = 52, Gender = "муж"},
                new Teachers{Surname = "Каргинов", Name = "Артур", Age = 30, Gender = "муж"},
                new Teachers{Surname = "Алиева", Name = "Роза", Age = 32, Gender = "жен"},
                new Teachers{Surname = "Лавров", Name = "Тимур", Age = 29, Gender = "муж"},
                new Teachers{Surname = "Аскарбекова", Name = "Диана", Age = 41, Gender = "жен"}

            };
            List<Students> students = new List<Students>()
            {
                new Students{Surname = "Егоров", Name = "Антон", Age = 18, Gender = "муж"},
                new Students{Surname = "Каргинова", Name = "Роза", Age = 18, Gender = "жен"},
                new Students{Surname = "Тектимуратова", Name = "Енилик", Age = 18, Gender = "жен"},
                new Students{Surname = "Бектемиров", Name = "Арслан", Age = 18, Gender = "муж"},
                new Students{Surname = "Таскынов", Name = "Тимур", Age = 19, Gender = "муж"},
                new Students{Surname = "Жанболатова", Name = "Роза", Age = 18, Gender = "жен"},
                new Students{Surname = "Дарханов", Name = "Артур", Age = 19, Gender = "муж"},
                new Students{Surname = "Калдан", Name = "Бакытжан", Age = 19, Gender = "муж"},
                new Students{Surname = "Жумагазиев", Name = "Ерлан", Age = 19, Gender = "муж"},
                new Students{Surname = "Сержанбекова", Name = "Роза", Age = 18, Gender = "жен"},
                new Students{Surname = "Малыбаев", Name = "Аслан", Age = 19, Gender = "муж"},
                new Students{Surname = "Дарханов", Name = "Алмабек", Age = 20, Gender = "муж"}
            };
  

            var result = teachers.GroupJoin(
                        students, 
                        t => t.Name, 
                        s => s.Name, 
                        (teacher, student) => new  
                        {

                            Teacher_Name = teacher.Name,
                            Teacher_Surname = teacher.Surname,
                            Student_Surname = student.Select(s => s.Surname),
                            Student_Name = student.Select(s => s.Name),
                            Count_Student_Name = student.Select(s => s.Name).Count()

                        });


            foreach (var item in result)
            {
                if (item.Count_Student_Name != 0)
                {
                    Console.WriteLine("Фамилия: {0} \t Имя: {1}", item.Teacher_Surname, item.Teacher_Name);

                    foreach (var st in item.Student_Surname)
                    {
                        Console.WriteLine("Фамилия: " + st);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
