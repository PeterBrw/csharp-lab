using System;
using System.Collections.Generic;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Date_univ uni = new Date_univ();
            var students = new Students();

            uni.An_studiu = 2019;
            uni.Specializare = "Calculatoare";
            uni.Universitate = "Universitatea din Oradea";

            

            var student1 = new Student();
            var student2= new Student();
            var student3 = new Student();
            var student4 = new Student();
            var student5 = new Student();
            var student6 = new Student();

            student1.Nume = "Iliescu";
            student1.Prenume = "Ion";
            student1.An_nastere = 1930;
            student1.Adresa = "Oltenita";
            student1.Date = uni;

            students.AddStudent(student1);

            student2.Nume = "Constantinescu";
            student2.Prenume = "Emil";
            student2.An_nastere = 1939;
            student2.Adresa = "Tighina";
            student2.Date = uni;

            students.AddStudent(student2);

            student3.Nume = "Basescu";
            student3.Prenume = "Traian";
            student3.An_nastere = 1951;
            student3.Adresa = "Basarabi";
            student3.Date = uni;

            students.AddStudent(student3);

            student4.Nume = "Iohannis Werner";
            student4.Prenume = "Klaus";
            student4.An_nastere = 1959;
            student4.Adresa = "Sibiu";
            student4.Date = uni;

            students.AddStudent(student4);

            student5.Nume = "Ponta";
            student5.Prenume = "Victor";
            student5.An_nastere = 1972;
            student5.Adresa = "Bucuresti";
            student5.Date = uni;

            students.AddStudent(student5);

            student6.Nume = "Sosoaca Iovanovici";
            student6.Prenume = "Diana";
            student6.An_nastere = 1975;
            student6.Adresa = "Bucuresti";
            student6.Date = uni;

            students.AddStudent(student6);

            Console.WriteLine("Before: \n");
            foreach (var student in students.Studs)
            {
                Console.WriteLine(student.ToString() + "\n");
            }

            students.ChangeStudent("Diana", "Drept", "Universitatea Bucuresti");
            students.ChangeStudent("Traian", "Navigatie", "Academia Fortelor Navale");

            Console.WriteLine("After: \n");
            foreach (var student in students.Studs)
            {
                Console.WriteLine(student.ToString() + "\n");
            }
        }
    }
}
