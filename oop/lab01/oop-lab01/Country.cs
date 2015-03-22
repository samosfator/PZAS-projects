namespace ooplab01
{
	public class Country
	{
		string Name { get; set; }

		string GovernmentForm { get; set; }

		string Square { get; set; }

		public Country ()
		{
		}

		public Country (string name, string governmentForm, string square)
		{
			this.Name = name;
			this.GovernmentForm = governmentForm;
			this.Square = square;
		}

		public Country (Country country)
		{
			this.Name = country.Name;
			this.GovernmentForm = country.GovernmentForm;
			this.Square = country.Square;
		}

		~Country ()
		{
			Name = null;
			GovernmentForm = null;
			Square = null;
			MainWindow.ShowMessageBox ("Object destructor");
		}

		public class CountryBuilder
		{
			Country country = new Country ();

			public CountryBuilder Name(string name) {
				country.Name = name;
				return this;
			}

			public CountryBuilder GovernmentForm(string form) {
				country.GovernmentForm = form;
				return this;
			}

			public CountryBuilder Square(string square) {
				country.Square = square;
				return this;
			}

			public Country Build() {
				return country;
			}
		}
	}
}
