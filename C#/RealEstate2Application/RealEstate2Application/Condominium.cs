using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate2Application
{
	public class Condominium : Property
	{
		private bool handicap;

		public bool HandicapAccessible
		{
			get { return handicap; }
			set { handicap = value; }
		}
	}
}
