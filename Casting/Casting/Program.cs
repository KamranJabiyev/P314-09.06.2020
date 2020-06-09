using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Upcasting,boxing,implicit - security way
            //object eagle = new Eagle();
            //Animal shark = new Shark();
            //Eagle eagle = new Eagle();
            //Fish shark = new Shark();
            //Animal eagle1 = new Eagle();
            ////Console.WriteLine(eagle1.GetType());
            //int a = 5;
            //string word = "Kamran";
            //object[] arr = { a, word, eagle1, eagle, shark };
            #endregion

            #region Downcasting,unboxing,explicit - insecurity!!!
            //insecurity way!!!
            //Shark newShark = (Shark)eagle;

            //security way - 1
            //if(eagle is Shark)
            //{
            //    Shark newShark = (Shark)eagle;
            //    Console.WriteLine("This animal is Shark");
            //}
            //else
            //{
            //    Console.WriteLine("This animal is not Shark!!!");
            //}

            //security way - 2
            //Shark newShark = shark as Shark;
            //if (newShark != null)
            //{
            //    Console.WriteLine("This animal is Shark");
            //}
            //else
            //{
            //    Console.WriteLine("This animal is not Shark!!!");
            //}

            //Task
            //Animal eagle = new Eagle();
            //Animal shark = new Shark();
            //Animal eagle1 = new Eagle();
            //int a = 5;
            //string word = "Kamran";
            //object[] arr = { a, word, eagle1, eagle, shark };
            //foreach (var item in arr)
            //{
            //    if (item is Eagle)
            //    {
            //        Eagle newEagle = (Eagle)eagle;
            //        Console.WriteLine("This animal is Eagle");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This animal is not Eagle!!!");
            //    }
            //}
            #endregion

            #region custom explicit&implicit
            //Manat manat = new Manat(340);
            ////Dollar dollar = manat;-implicit
            //Dollar dollar = (Dollar)manat; //- explicit
            //Console.WriteLine(dollar.Usd);
            #endregion

            #region Operators in Custom type
            //int a = 6;
            //int b = 5;
            //Console.WriteLine(a-b);
            Student s1 = new Student("Osman", 26);
            Student s2 = new Student("Eli", 20);
            //Console.WriteLine(s1+s2);
            //Console.WriteLine(s1-s2);
            Console.WriteLine(s1>s2);
            #endregion
        }
    }
    #region Operators in Custom type
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public static int operator -(Student stu1,Student stu2)
        {
            return stu1.Name.Length - stu2.Name.Length;
        }

        public static string operator +(Student stu1, Student stu2)
        {
            return stu1.Name + stu2.Name;
        }

        public static bool operator >(Student stu1, Student stu2)
        {
            return stu1.Age > stu2.Age;
        }

        public static bool operator <(Student stu1, Student stu2)
        {
            return stu1.Age < stu2.Age;
        }

        public static bool operator >=(Student stu1, Student stu2)
        {
            return stu1.Age >= stu2.Age;
        }

        public static bool operator <=(Student stu1, Student stu2)
        {
            return stu1.Age <= stu2.Age;
        }
    }
    #endregion

    #region custom explicit&implicit
    class Manat
    {
        public double Azn;
        public Manat(double azn)
        {
            Azn = azn;
        }

        //public static implicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.Azn / 1.7);
        //}

        public static explicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.Azn / 1.7);
        }
    }
    class Dollar
    {
        public double Usd;
        public Dollar(double usd)
        {
            Usd = usd;
        }

        
    }
    #endregion

    #region Upcasting,downcasting
    abstract class Animal
    {
        public abstract void Eat();
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    abstract class Bird : Animal
    {
        public abstract void Fly();
    }

    class Shark : Fish
    {
        public int SharkTeeth { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }
    }

    class Eagle : Bird
    {
        public string EagleType { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }
    #endregion

}
