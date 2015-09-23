using GalacticDvdRentals.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticDvdRentals.Data
{
	public interface IRentalRepository
	{
		IEnumerable<Rental> Find();

		void Add(Rental rental);

		void Modify(Rental rental);
	}
}
