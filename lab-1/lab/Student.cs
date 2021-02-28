using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    public class Student
    {
        string nume;
        string prenume;
        string adresa;
        int an_nastere;
        Date_univ date;

        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int An_nastere { get => an_nastere; set => an_nastere = value; }
        public Date_univ Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $@"Nume: {Nume},
Prenume: {Prenume},
An nastere: {An_nastere},
Adresa: {Adresa},
{Date}";
        }
    }
}
