using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstate2Application
{
	public enum PropertyType
	{
		Unknown,
		SingleFamily,
		Townhouse,
		Condominium
	}

	class PropertyListing
	{
		private Property prop;
		private HouseType hse;
		private Condominium cond;
		private PropertyType tp;

		public Property ListProperty
		{
			get { return prop; }
			set { prop = value; }
		}

		public HouseType House
		{
			get { return hse; }
			set { hse = value; }
		}

		public Condominium Condo
		{
			get { return cond; }
			set { cond = value; }
		}

		public PropertyType Type
		{
			get { return tp; }
			set { tp = value; }
		}

		public PropertyListing()
		{
			prop = new Property();
			hse = new HouseType();
			cond = new Condominium();
		}

		public void CreateListing()
		{
			char answer;

			Console.WriteLine(" =//= Altair Realty =//=");
			Console.WriteLine("-=- Property Creation -=-");
			Console.WriteLine("\nTypes of Properties");
			Console.WriteLine("1. Single Family");
			Console.WriteLine("2. Townhouse");
			Console.WriteLine("3. Condonium");
			Console.WriteLine("4. Don't Know");
			Console.Write("Enter Type of Property: ");
			int propType = int.Parse(Console.ReadLine());

			Console.Write("\nEnter Property #: ");
			ListProperty.PropertyNumber = Console.ReadLine();
			Console.WriteLine("\nProperties Conditions");
			Console.WriteLine("1. Excellent");
			Console.WriteLine("2. Good (may need minor repair)");
			Console.WriteLine("3. Needs Repair");
			Console.Write("4. In Bad Shape (property needs ");
			Console.WriteLine("major repair or rebuild)");
			Console.Write("Enter Property Condition: ");
			int condition = int.Parse(Console.ReadLine());
			if (condition == 1)
				ListProperty.Condition = PropertyCondition.Excellent;
			else if (condition == 2)
				ListProperty.Condition = PropertyCondition.Good;
			else if (condition == 3)
				ListProperty.Condition = PropertyCondition.NeedsRepair;
			else if (condition == 4)
				ListProperty.Condition = PropertyCondition.BadShape;
			else
				ListProperty.Condition = PropertyCondition.Unknown;

			switch ((PropertyType)propType)
			{
				case PropertyType.SingleFamily:
					Type = PropertyType.SingleFamily;
					Console.Write("\nHow many stories (levels)? ");
					House.Stories = int.Parse(Console.ReadLine());
					Console.Write("Does it have an indoor car garage (y/n): ");
					answer = char.Parse(Console.ReadLine());
					if ((answer == 'y') || (answer == 'Y'))
						House.IndoorGarage = true;
					else
						House.IndoorGarage = false;
					Console.Write("Is the basement finished(y/n): ");
					answer = char.Parse(Console.ReadLine());
					if ((answer == 'y') || (answer == 'Y'))
						House.FinishedBasement = true;
					else
						House.FinishedBasement = false;
					break;

				case PropertyType.Townhouse:
					Type = PropertyType.Townhouse;
					Console.Write("\nHow many stories (levels)? ");
					House.Stories = int.Parse(Console.ReadLine());
					Console.Write("Does it have an indoor car garage (y/n): ");
					answer = char.Parse(Console.ReadLine());
					if ((answer == 'y') || (answer == 'Y'))
						House.IndoorGarage = true;
					else
						House.IndoorGarage = false;
					Console.Write("Is the basement finished(y/n): ");
					answer = char.Parse(Console.ReadLine());
					if ((answer == 'y') || (answer == 'Y'))
						House.FinishedBasement = true;
					else
						House.FinishedBasement = false;
					break;

				case PropertyType.Condominium:
					Type = PropertyType.Condominium;
					Console.Write("\nIs the building accessible to handicapped (y/n): ");
					answer = char.Parse(Console.ReadLine());
					if ((answer == 'y') || (answer == 'Y'))
						Condo.HandicapAccessible = true;
					else
						Condo.HandicapAccessible = false;
					break;

				default:
					Type = PropertyType.Unknown;
					break;
			}

			Console.Write("\nHow many bedrooms?  ");
			ListProperty.Bedrooms = int.Parse(Console.ReadLine());
			Console.Write("How many bathrooms? ");
			ListProperty.Bathrooms = float.Parse(Console.ReadLine());
			Console.Write("Year built:         ");
			ListProperty.YearBuilt = int.Parse(Console.ReadLine());
			Console.Write("Property Value:     ");
			ListProperty.Value = decimal.Parse(Console.ReadLine());
		}

		public void ShowProperty()
		{
			Console.WriteLine("==================================");
			Console.WriteLine(" =//=//= Altair Realty =//=//=");
			Console.WriteLine("-=-=-=- Properties Listing -=-=-=-");
			Console.WriteLine("----------------------------------");
			Console.WriteLine("Property #:            {0}",
				ListProperty.PropertyNumber);
			Console.WriteLine("Property Type:         {0}", Type);

			switch (Type)
			{
				case PropertyType.SingleFamily:
				case PropertyType.Townhouse:
					Type = PropertyType.SingleFamily;
					Console.WriteLine("Stories:               {0}",
						House.Stories);
					Console.WriteLine("Has Indoor Car Garage: {0}",
						House.IndoorGarage);
					Console.WriteLine("Finished Basement:     {0}",
						House.FinishedBasement);
					break;

				case PropertyType.Condominium:
					Console.WriteLine("Handicapped Accessible Building: {0}",
						Condo.HandicapAccessible);
					break;
			}

			Console.WriteLine("Condition:             {0}", ListProperty.Condition);
			Console.WriteLine("Bedrooms:              {0}", ListProperty.Bedrooms);
			Console.WriteLine("Bathrooms:             {0}", ListProperty.Bathrooms);
			Console.WriteLine("Year Built:            {0}", ListProperty.YearBuilt);
			Console.WriteLine("Market Value:          {0:C}", ListProperty.Value);
		}
	}
}