using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Human
    {
        public string Name { get; set; }
    }
    class Student : Human
    {
        public int Id_Student { get; set; }
        public Student(int id, string name)
        {
            Id_Student = id;
            Name = name;
        }
    }
    class Teacher : Human
    {

        public int Id_Teacher { get; set; }

        public Teacher(int id, string name)
        {
            Id_Teacher = id;
            Name = name;

        }

    }
    class Subject
    {
        public string Name { get; set; }
        public int Id_Subject { get; set; }

        public Subject(int id, string name)
        {
            Id_Subject = id;
            Name = name;

        }
    }


    class Database
    {

        private static Database _dbInstance;
        private Database() { }

        public List<Teacher> Teachers = new List<Teacher>();
        public List<Subject> Subjects = new List<Subject>();
        public List<Student> Students = new List<Student>();


        List<Database> database = new List<Database>();

        public void data(Student st, Subject su, Teacher te)
        {
            if (su.Id_Subject == te.Id_Teacher && st.Id_Student == su.Id_Subject)
            {
                Students.Add(st);
                Subjects.Add(su);
                Teachers.Add(te);
            }
        }



        public static Database GetInstance()
        {
            if (_dbInstance == null)
            {
                _dbInstance = new Database();

            }
            return _dbInstance;
        }


        public string Result(Student st, Subject su, Teacher te)
        {
            var result = st.Name + " " + su.Name + " " + te.Name;
            return result;
        }

    }





    class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.GetInstance();

            Student st1 = new Student(1, "Lera");
            Student st2 = new Student(2, "Alen");
            Student st3 = new Student(3, "Askar");



            Subject su1 = new Subject(1, "math");
            Subject su2 = new Subject(2, "phys");
            Subject su3 = new Subject(3, "science");



            Teacher te1 = new Teacher(1, "Kamil");
            Teacher te2 = new Teacher(2, "Nick");
            Teacher te3 = new Teacher(3, "Samat");




            db.data(st1, su1, te1);
            db.data(st2, su2, te2);
            db.data(st3, su3, te3);




            Console.WriteLine(db.Result(st1, su1, te1));
            Console.WriteLine(db.Result(st2, su2, te2));
            Console.WriteLine(db.Result(st3, su3, te3));




        }
    }
}
