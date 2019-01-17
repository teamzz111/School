using System;
using School.Courses;
using School.Entities;

namespace Etp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new school("Platzi Academy", 1998);
            escuela.city = "Bogotá D.C";
            escuela.country = "Colombia";
            escuela.schoolTypes = SchoolTypes.Primaria;
            Console.WriteLine(escuela);

            Curso[] courses = NewMethod();

            courses[0] = new Curso()
            {
                name = "101"
            };

            courses[1] = new Curso()
            {
                name = "202"
            };

            courses[2] = new Curso()
            {
                name = "301"
            };

            System.Console.WriteLine("=================");

            for (int i = 0; i < courses.Length; i++)
            {
                System.Console.WriteLine(courses[i].name + " " + courses[i].uniqueId);
            }

        }

        private static Curso[] NewMethod()
        {
            return new Curso[3];
        }
    }
}
