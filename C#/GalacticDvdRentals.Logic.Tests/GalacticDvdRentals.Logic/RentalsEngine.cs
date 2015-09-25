using GalacticDvdRentals.Data;
using GalacticDvdRentals.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GalacticDvdRentals.Logic
{
	public class RentalsEngine
	{
		private IMovieRepository _movieRepository;
		private IDvdItemRepository _dvdItemRepository;
		private IRentalRepository _rentalRepository;

		public RentalsEngine(IMovieRepository movieRepository, IDvdItemRepository dvdItemRepository, IRentalRepository rentalRepository)
		{
			_movieRepository = movieRepository;
			_dvdItemRepository = dvdItemRepository;
			_rentalRepository = rentalRepository;
		}

		~RentalsEngine()
		{
			Dispose(false);
		}
		public void Dispose()
		{
			Dispose(true);
		}
		public void Dispose(bool isManagedDispose)
		{
			//Clean up unmanaged objects
			if (isManagedDispose)
			{
				//Clean up managed objects
				IDisposable d1 = _dvdItemRepository as IDisposable;
				if (d1 != null)
					d1.Dispose();
				IDisposable d2 = _movieRepository as IDisposable;
				if (d2 != null)
					d2.Dispose();
				IDisposable d3 = _rentalRepository as IDisposable;
				if (d3 != null)
					d3.Dispose();
				GC.SuppressFinalize(this);
			}
		}

		public List<Movie> ListMovies()
		{
			return _movieRepository.Find().ToList();
		}

		public List<DvdItem> ListDvdItem()
		{
			return _dvdItemRepository.Find().ToList();
		}

		public List<Rental> ListRental()
		{
			return _rentalRepository.Find().ToList();
		}

		public List<Movie> SearchMovies(string testSeachString)
		{
			if (string.IsNullOrWhiteSpace(testSeachString))
				return ListMovies();
			else {				
				return _movieRepository.Find()
					.Where(movies => movies.title.ToLower().Contains(testSeachString.ToLower()))
					.ToList();
			}
		}
		
		public bool IsDvdItemAvailable(int testdvdItemId)
		{
			if (!DvdItemExists(testdvdItemId))
				return false;
			
			if ( _rentalRepository.Find()
				.Where(r => r.dvdItemId == testdvdItemId && r.actualReturnDate == null).Any() )
				return false;
			
			return true;
		}

		public int GetRentalFee(int testdvdItemId)
		{
			if (!DvdItemExists(testdvdItemId))
				return 0;
			return _dvdItemRepository.Find()
				.Where(dvd => dvd.dvdItemId == testdvdItemId)
				.Select(dvd => dvd.price).First();
		}

		public int GetPenaltyFee(int RentalId)
		{
			// R25 / day penalty 
			DateTime RightNow = DateTime.Now;
			var expectedReturn = _rentalRepository.Find()
				.Where(rental => rental.rentalId == RentalId)
				.Select(rental => rental.expectedReturnDate).First();
			if (expectedReturn < RightNow)
				return 2500 * ((RightNow - expectedReturn).Days + 1);
			
			return 0;
		}

		public bool CheckoutRental(int testClientId, int testdvdItemId)
		{
			if (!IsDvdItemAvailable(testdvdItemId))
				return false;
			_rentalRepository.Add(new Rental { dvdItemId = testdvdItemId, clientId = testClientId, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 17, 11, 00, 00) });
			
			return true;
		}

		public List<DvdItem> IsMovieAvailable(int testMovieId)
		{
			var existingDvdItem = GetDvdsExist(testMovieId);

			var availableDvdItemList = new List<DvdItem>();
			foreach (var dvd in existingDvdItem)
				if (IsDvdItemAvailable(dvd.dvdItemId))
					availableDvdItemList.Add(dvd);
			
			return availableDvdItemList;
		}

		public bool ReturnRental(String testSerial)
		{
			int dvdItemId = GetdvdItemIdFromSerial(testSerial);
			if (dvdItemId == -1)
				return false;
			
			if (IsDvdItemAvailable(dvdItemId))
				return false;
			
			var rental = _rentalRepository.Find()
				.Where(o => o.dvdItemId == dvdItemId && o.actualReturnDate == null).Last();
			if (rental != null)
			{
				rental.actualReturnDate = DateTime.Now;
				_rentalRepository.Modify(rental);
				return true;
			}
			return false;
		}

		private int GetdvdItemIdFromSerial(String testSerial)
		{
			if (_dvdItemRepository.Find()
				.Where(o => o.serial == testSerial).Any())
				return _dvdItemRepository.Find()
					.Where(o => o.serial == testSerial)
					.Select(o => o.dvdItemId).Single();
			else
				return -1;
		}

		private List<DvdItem> GetDvdsExist(int testMovieId)
		{
			return _dvdItemRepository.Find()
				.Where(m => m.movieId == testMovieId).ToList();
		}

		private bool DvdItemExists(int testdvdItemId)
		{
			return _dvdItemRepository.Find()
				.Where(d => d.dvdItemId == testdvdItemId).Any();
		}

	}
}
