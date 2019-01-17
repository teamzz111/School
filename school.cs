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

        public SchoolTypes schoolTypes { get; set; }


     
        public school(string name, int year) => (Name, foundationYear) = (name, year);
     
        public override string ToString()
        {
            return $"Nombre: {name}, Tipo: {schoolTypes}\n Pa�s: {country}, Ciudad: {city}";
        }

    }

}