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
					.Where(movies => movies.Title.ToLower().Contains(testSeachString.ToLower()))
					.ToList();
			}
		}
		
		public bool IsDvdItemAvailable(int testDvdItemId)
		{
			if (!DvdItemExists(testDvdItemId))
				return false;
			
			if ( _rentalRepository.Find()
				.Where(r => r.DvdItemId == testDvdItemId && r.ReturnDate == null).Any() )
				return false;
			
			return true;
		}

		public int GetRentalFee(int testDvdItemId)
		{
			if (!DvdItemExists(testDvdItemId))
				return 0;
			return _dvdItemRepository.Find()
				.Where(dvd => dvd.DvdItemId == testDvdItemId)
				.Select(dvd => dvd.Price).First();
		}

		public int GetPenaltyFee(int RentalId)
		{
			// R25 / day penalty 
			DateTime RightNow = DateTime.Now;
			var queryPentalyFee = _rentalRepository.Find()
				.Where(rental => rental.RentalId == RentalId)
				.Select(rental => rental.ExpectedReturnDate).First();
				if (queryPentalyFee < RightNow)
					return 2500 * ((RightNow - queryPentalyFee).Days + 1);
			
			return 0;
		}

		public bool CheckoutRental(int testClientId, int testDvdItemId)
		{
			if (!IsDvdItemAvailable(testDvdItemId))
				return false;
			_rentalRepository.Add(new Rental { DvdItemId = testDvdItemId, ClientId = testClientId, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ExpectedReturnDate = new DateTime(2015, 09, 17, 11, 00, 00) });
			
			return true;
		}

		public List<DvdItem> IsMovieAvailable(int testMovieId)
		{
			var existingDvdItem = GetDvdsExist(testMovieId);

			var availableDvdItemList = new List<DvdItem>();
			foreach (var dvd in existingDvdItem)
				if (IsDvdItemAvailable(dvd.DvdItemId))
					availableDvdItemList.Add(dvd);
			
			return availableDvdItemList;
		}

		public bool ReturnRental(int testSerial)
		{
			int dvdItemId = GetDvdItemIdFromSerial(testSerial);
			if (dvdItemId == -1)
				return false;
			
			if (IsDvdItemAvailable(dvdItemId))
				return false;
			
			var rental = _rentalRepository.Find()
				.Where(o => o.DvdItemId == dvdItemId && o.ReturnDate == null).Last();
			if (rental != null)
			{
				rental.ReturnDate = DateTime.Now;
				_rentalRepository.Modify(rental);
				return true;
			}
			return false;
		}

		private int GetDvdItemIdFromSerial(int testSerial)
		{
			if (_dvdItemRepository.Find()
				.Where(o => o.Serial == testSerial).Any())
				return _dvdItemRepository.Find()
					.Where(o => o.Serial == testSerial)
					.Select(o => o.DvdItemId).Single();
			else
				return -1;
		}

		private List<DvdItem> GetDvdsExist(int testMovieId)
		{
			return _dvdItemRepository.Find()
				.Where(m => m.MovieId == testMovieId).ToList();
		}

		private bool DvdItemExists(int testDvdItemId)
		{
			return _dvdItemRepository.Find()
				.Where(d => d.DvdItemId == testDvdItemId).Any();
		}
	}
}
