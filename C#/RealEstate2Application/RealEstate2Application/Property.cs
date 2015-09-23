using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstate2Application
{
	public enum PropertyCondition
	{
		Unknown,
		Excellent,
		Good,
		NeedsRepair,
		BadShape
	}

	public class Property
	{

		private string propNbr;
		private PropertyCondition cond;
		private int beds;
		private float baths;
		private int yr;
		private decimal val;

		public Property()
		{
		}

		public string PropertyNumber
		{
			get { return propNbr; }
			set
			{
				if (propNbr == "")
					propNbr = "N/A";
				else
					propNbr = value;
			}
		}

		public PropertyCondition Condition
		{
			get { return cond; }
			set { cond = value; }
		}

		public int Bedrooms
		{
			get
			{
				if (beds <= 1)
					return 1;
				else
					return beds;
			}
			set { beds = value; }
		}

		public float Bathrooms
		{
			get { return baths; }
			set { baths = value; }
		}

		public int YearBuilt
		{
			get { return yr; }
			set { yr = value; }
		}

		public decimal Value
		{
			get { return val; }
			set { val = value; }
		}
	}
}