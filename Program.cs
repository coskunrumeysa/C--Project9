//Beni Yaratan Elbet Yolumu Gösterir .Şuara-78
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            string department;
            string lecture;
            int ex1;
            int ex2;
            int ex3;
            int average;

            //Assignment Values String Variable 

            name = "Rümeysa";
            surname = "Coşkun";
            department = "Computer Engineering And Software Engineering";
            lecture = "Object Oriented Programming";

            //Assignment Values Int Variable

            ex1 = 60;
            ex2 = 70;
            ex3 = 80;
            average = (ex1+ex2+ex3) / 3;

            //Print Screen

            Console.WriteLine("Student Information");
            Console.WriteLine();
            Console.WriteLine("Student Name :" + " " + name);
            Console.WriteLine();
            Console.WriteLine("Student Surname:" + " " + surname);
            Console.WriteLine();
            Console.WriteLine("Student Department :"+" "+department);
            Console.WriteLine();
            Console.WriteLine("Student Lecture :"+" "+lecture);
            Console.WriteLine();
            Console.WriteLine("Exam 1 Grade:" + " " + ex1);
            Console.WriteLine();
            Console.WriteLine("Exam 2 Grade:" + " " + ex2);
            Console.WriteLine();
            Console.WriteLine("Exam 3 Grade:" + " " + ex3);
            Console.WriteLine();
            Console.WriteLine("Avearge  Grade:" + " " + average);
            Console.WriteLine();
            Console.Read();
        }


    }
}
