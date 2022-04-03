# SHREYASHEE-Solution
Solution C#

Solution 1
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Person
    {
        protected string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "I am " + Name;
        }
    }

    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            Name = name;
        }

        public void Explain()
        {
            Console.WriteLine("I am giving reason");
        }
    }

    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            Name = name;
        }

        public void Study()
        {
            Console.WriteLine("I'm Coding");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter Teacher name :");
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.Write("Enter Student name :");
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            Console.WriteLine("-.-.-.-.-.-.-");

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(persons[i].ToString());
                    ((Teacher)persons[i]).Explain();

                }
                else
                {
                    Console.WriteLine(persons[i].ToString());
                    ((Student)persons[i]).Study();
                }
            }


            Console.ReadKey();

        }
    }
}




Solution 2
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{

    public class Student
    {
        private string course;
        private int feepaid;
        private string name;
        private int rollno;
        private static double servicetax = 12.3;


        public int DueAmount
        {

            get
            {
                return TotalFee - feepaid;
            }
        }

        public int TotalFee
        {
            get
            {
                double total = course == "C#" ? 2000 : course == "ASP.NET" ? 3000 : 0;

                total = total + total * servicetax / 100;
                return (int)total;
            }
        }


        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }

        public void Payment(int amount)
        {
            feepaid += amount;
        }

        public void Print()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

    }
    class UseStudent
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "ABC", "ASP.NET");
            Student p = new Student(10, "MNO", "C#");
            s.Payment(1000);
            s.Print();
            Console.WriteLine("DueAmount of ABC is : " + s.DueAmount);
            p.Payment(1000);
            p.Print();
            Console.WriteLine("DueAmount of MNO is : " +p.DueAmount);
            Console.ReadKey();
        }
    }
}
