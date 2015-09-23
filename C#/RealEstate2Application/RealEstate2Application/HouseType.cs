using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstate2Application
{
	public class HouseType : Property
	{
		private int nbrOfStories;
		private bool basement;
		private bool garage;

		public int Stories
		{
			get { return nbrOfStories; }
			set { nbrOfStories = value; }
		}

		public bool FinishedBasement
		{
			get { return basement; }
			set { basement = value; }
		}

		public bool IndoorGarage
		{
			get { return garage; }
			set { garage = value; }
		}
	}
}