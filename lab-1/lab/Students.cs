using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    public class Students
    {
        List<Student> studs = new List<Student>();

        public List<Student> Studs { get => studs; set => studs = value; }

        public void AddStudent(Student student)
        {
            Studs.Add(student);
        }

        public void ChangeStudent(string prenume, string specializare, string universitate )
        {
            foreach (var student in Studs)
            {
                if(student.Prenume == prenume)
                {
                    student.Date.Specializare = specializare;
                    student.Date.Universitate = universitate;
                }
            }
        }
    }
}
