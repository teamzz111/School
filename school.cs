using System;

namespace School.Entities
{
	class school
    {
        string name;
		public string Name
        {
			get { return name; }
			set { name = value;  }
        }

		public int foundationYear { get; set; }
		
		public string country { get; set; }

		public string city { get; set; }

        private int Myvar;

        public school(string name, int year) => (Name, foundationYear) = (name, year);
    }
}