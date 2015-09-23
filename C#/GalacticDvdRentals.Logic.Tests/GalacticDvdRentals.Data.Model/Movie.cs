using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticDvdRentals.Data.Model
{
    public class Movie
    {
		public int MovieId { get; set; }
		public string Title { get; set; }

		public override bool Equals(object obj)
		{
			if (obj == null)
				return false;

			if (!(obj is Movie))
				return false;

			var eq = (Movie)obj;
			return MovieId.Equals(eq.MovieId);
		}

		public override int GetHashCode()
		{
			return MovieId.GetHashCode();
		}

	}
}
