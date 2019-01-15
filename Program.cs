using System;
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
        }
    }
}
