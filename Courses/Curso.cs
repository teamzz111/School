using System;

namespace School.Courses
{
    public class Curso
    {


        public string name { get; set; }
        public string uniqueId {get; set; }
        
        public Curso()
        {
            uniqueId = Guid.NewGuid().ToString();
        }
    }


}