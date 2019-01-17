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

            var course = new Curso() {
                name = "101"
            };

            var course2 = new Curso() {
                name = "202"
            };

            var course3 = new Curso() {
                name = "301"
            };

            System.Console.WriteLine("=================");

            System.Console.WriteLine(course.name +  " " + course.uniqueId);

            System.Console.WriteLine(course2.name +  " " + course2.uniqueId);

            System.Console.WriteLine(course3.name +  " " + course3.uniqueId);
        }
    }
}
