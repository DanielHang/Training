using GalacticDvdRentals.Data;
using GalacticDvdRentals.Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticDvdRentals.Logic.Tests
{
	[TestClass]
	public class RentalsEngineTests
	{
		private const string MovieTitle1 = "qwaljknbefec";
		private const string MovieTitle2 = "qwaljknbefec";
		private const string MovieTitle3 = "qwfdsKIUJBe";
		private const string MovieTitle4 = "QqSyXabcDGFJYwe";
		private const string MovieTitle5 = "qwXHFSWaerce";
		private const string MovieTitle6 = "hkjgABcertabc";
		private const string MovieTitle7 = "qrtcq2we";
		private const string MovieTitle8 = "a B c";
		private const string MovieTitle9 = "qwdfbede";
		private const string MovieTitle10 = "aw4mn";
		
		[TestMethod]
		public void ListMoviesReturnsAllMovies()
		{
			//arrange
			var availableMovies = CreateMovieList();
			var actualMovies = CreateMovieList();

			var movieRepository = new Mock<IMovieRepository>();
			movieRepository.Setup(o => o.Find()).Returns(actualMovies);
			var rentalsEngine = new RentalsEngine(movieRepository.Object, null, null);

			//act
			var movies = rentalsEngine.ListMovies();

			//assert
			Assert.IsNotNull(movies, "Return movies collection is null");
			Assert.AreEqual(10, movies.Count);
			CollectionAssert.AreEquivalent(availableMovies, movies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void ListMoviesReturnsEmptyListIfTheAreNoMoviesAtAll()
		{
			//arrange
			var movieRepository = new Mock<IMovieRepository>();
			movieRepository.Setup(o => o.Find()).Returns(new List<Movie>());
			var movieEngine = new RentalsEngine(movieRepository.Object, null, null);

			//act
			var returnedMovies = movieEngine.ListMovies();

			//assert
			Assert.IsNotNull(returnedMovies, "Returned movies list is null");
			Assert.AreEqual(0, returnedMovies.Count, "Returned movies has movie items");
		}

		[TestMethod]
		public void SearchMoviesReturnsFullListIfSearchIsNull()
		{
			//arrange
			const string testSeachString = null;
			var availableSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(10, returnedSearchResultsMovies.Count);
			CollectionAssert.AreEquivalent(availableSearchableMovies, returnedSearchResultsMovies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void SearchMoviesReturnsFullListIfSearchIsEmpty()
		{
			//arrange
			const string testSeachString = "";
			var availableSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(10, returnedSearchResultsMovies.Count);
			CollectionAssert.AreEquivalent(availableSearchableMovies, returnedSearchResultsMovies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void SearchMoviesReturnsEmptyListIfQueryReturnsNoMatches()
		{
			//arrange
			const string testSeachString = "pLh";
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(0, returnedSearchResultsMovies.Count);
		}

		[TestMethod]
		public void SearchMoviesReturnsListOfOneItemtIfQueryReturnsOneMatch()
		{
			//arrange
			const string testSeachString = "Bcert";
			var availableSearchableMovies = new List<Movie>();
			availableSearchableMovies.Add(new Movie { movieId = 6, title = MovieTitle6, description = null, image = null, stars = null, ageRestriction = null, director = null });
			
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(1, returnedSearchResultsMovies.Count);
			CollectionAssert.AreEquivalent(availableSearchableMovies, returnedSearchResultsMovies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void SearchMoviesReturnsListOfTwoItemtIfQueryReturnsTwoMatches()
		{
			//arrange
			const string testSeachString = "qwaljknbefec";
			var availableSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2);
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(2, returnedSearchResultsMovies.Count);
			CollectionAssert.AreEquivalent(availableSearchableMovies, returnedSearchResultsMovies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void SearchMoviesReturnsListOfMovieWhileMatchesIsCaseInsensitive()
		{
			//arrange
			const string testSeachString = "Abc";
			var availableSearchableMovies = new List<Movie>() ;
			availableSearchableMovies.Add(new Movie { movieId = 4, title = MovieTitle4, description = null, image = null, stars = null, ageRestriction = null, director = null });
			availableSearchableMovies.Add(new Movie { movieId = 6, title = MovieTitle6, description = null, image = null, stars = null, ageRestriction = null, director = null });
			var actualSearchableMovies = CreateSearchableMovieList(MovieTitle1, MovieTitle2, MovieTitle3, MovieTitle4, MovieTitle5, MovieTitle6, MovieTitle7, MovieTitle8, MovieTitle9, MovieTitle10);

			var searchableMovieRepository = new Mock<IMovieRepository>();
			searchableMovieRepository.Setup(o => o.Find()).Returns(actualSearchableMovies);
			var movieEngine = new RentalsEngine(searchableMovieRepository.Object, null, null);

			//act
			var returnedSearchResultsMovies = movieEngine.SearchMovies(testSeachString);

			//assert
			Assert.IsNotNull(returnedSearchResultsMovies, "Returned movies list is null");
			Assert.AreEqual(2, returnedSearchResultsMovies.Count);
			CollectionAssert.AreEquivalent(availableSearchableMovies, returnedSearchResultsMovies, "Returned list of movies are not equivalent to the expected list");
		}

		[TestMethod]
		public void ListDvdItemsReturnsAllDvdItems()
		{
			//arrange
			var availableDvdItems = CreateDvdItemList();
			var actualDvdItems = CreateDvdItemList();

			var dvdItemRepository = new Mock<IDvdItemRepository>();
			dvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var rentalsEngine = new RentalsEngine(null, dvdItemRepository.Object, null);

			//act
			var dvdItems = rentalsEngine.ListDvdItem();

			//assert
			Assert.IsNotNull(dvdItems, "Return DvdItem collection is null");
			Assert.AreEqual(10, dvdItems.Count);
			CollectionAssert.AreEquivalent(availableDvdItems, dvdItems, "Returned list of DvdItem are not equivalent to the expected list");
		}

		[TestMethod]
		public void ListDvdItemsReturnsEmptyListIfTheAreDvdItemAtAll()
		{
			//arrange
			var dvdItemRepository = new Mock<IDvdItemRepository>();
			dvdItemRepository.Setup(o => o.Find()).Returns(new List<DvdItem>());
			var movieEngine = new RentalsEngine(null, dvdItemRepository.Object, null);

			//act
			var returnedDvdItems = movieEngine.ListDvdItem();

			//assert
			Assert.IsNotNull(returnedDvdItems, "Returned DvdItem list is null");
			Assert.AreEqual(0, returnedDvdItems.Count, "Returned DvdItem has DvdItem items");
		}

		[TestMethod]
		public void IsAvailableReturnsTrueIfOneDvdItemIsAvailableOutOfOne()
		{
			//arrange
			const int testMovieId = 1;
			var actualDvdItems = CreateDvdList();
			var actualRentals = CreateRentalList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentals);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsAvailableResultDvdItems = movieEngine.IsDvdItemAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsAvailableResultDvdItems, "Returned DvdItem is null");
			Assert.IsTrue(returnedIsAvailableResultDvdItems, "Returned DvdItem is not true");
		}

		[TestMethod]
		public void IsAvailableReturnsFasleIfNoDvdItemIsAvailableOutOfOneItem()
		{
			//arrange
			const int testMovieId = 2;
			var actualDvdItems = CreateDvdList();
			var actualRentals = CreateRentalList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentals);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsAvailableResultDvdItems = movieEngine.IsDvdItemAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsAvailableResultDvdItems, "Returned DvdItem is null");
			Assert.IsFalse(returnedIsAvailableResultDvdItems, "Returned DvdItem is not false");
		}

		[TestMethod]
		public void IsMovieAvailableReturnsDvdItemNoneAvailable()
		{
			//arrange
			const int testMovieId = 100;
			var actualDvdItems = CreateDvdList();
			var actualRentalList = CreateRentalList();
			var actualMovieList = CreateMovieList();

			var expectedDvdItemList = new List<DvdItem>();

			var MovieRepository = new Mock<IMovieRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();

			MovieRepository.Setup(o => o.Find()).Returns(actualMovieList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			
			var movieEngine = new RentalsEngine(MovieRepository.Object, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsMovieAvailableDvdItems = movieEngine.IsMovieAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsMovieAvailableDvdItems, "Returned DvdItemList is null");
			Assert.AreEqual(0, returnedIsMovieAvailableDvdItems.Count);
			CollectionAssert.AreEqual(expectedDvdItemList, returnedIsMovieAvailableDvdItems, "Returned DvdItem is not true");
		}

		[TestMethod]
		public void IsMovieAvailableReturnsDvdItemOneAvailable()
		{
			//arrange
			const int testMovieId = 1;
			var actualDvdItems = CreateDvdListForIsMovieAvailable();
			var actualRentalList = CreateRentalListForIsMovieAvailable();

			var actualMovieList = new List<Movie>();
			var expectedDvdItemList = new List<DvdItem>();
			expectedDvdItemList.Add(new DvdItem { dvdItemId = 1, movieId = 1, media = null, serial = "1", price = 1500 });

			var MovieRepository = new Mock<IMovieRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();

			MovieRepository.Setup(o => o.Find()).Returns(actualMovieList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);

			var movieEngine = new RentalsEngine(MovieRepository.Object, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsMovieAvailableDvdItems = movieEngine.IsMovieAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsMovieAvailableDvdItems, "Returned DvdItemList is null");
			Assert.AreEqual(1, returnedIsMovieAvailableDvdItems.Count);
			CollectionAssert.AreEquivalent(expectedDvdItemList, returnedIsMovieAvailableDvdItems, "Returned DvdItem List does not match expected");
		}

		[TestMethod]
		public void IsMovieAvailableReturnsTwoDvdItemThreeAvailableOneRented()
		{
			//arrange
			const int testMovieId = 2;
			var actualDvdItems = CreateDvdListForIsMovieAvailable();
			var actualRentalList = CreateRentalListForIsMovieAvailable();
			var actualMovieList = new List<Movie>();
			var expectedDvdItemList = new List<DvdItem>();
			expectedDvdItemList.Add(new DvdItem { dvdItemId = 2, movieId = 2, media = null, serial = "2", price = 1500 });
			expectedDvdItemList.Add(new DvdItem { dvdItemId = 4, movieId = 2, media = null, serial = "4", price = 1500 });
			var MovieRepository = new Mock<IMovieRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();

			MovieRepository.Setup(o => o.Find()).Returns(actualMovieList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);

			var movieEngine = new RentalsEngine(MovieRepository.Object, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsMovieAvailableDvdItems = movieEngine.IsMovieAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsMovieAvailableDvdItems, "Returned DvdItemList is null");
			Assert.AreEqual(2, returnedIsMovieAvailableDvdItems.Count);
			CollectionAssert.AreEquivalent(expectedDvdItemList, returnedIsMovieAvailableDvdItems, "Returned DvdItem List does not match expected");
		}

		[TestMethod]
		public void IsMovieAvailableReturnsOneDvdItemNeverRented()
		{
			//arrange
			const int testMovieId = 6;
			var actualDvdItems = CreateDvdListForIsMovieAvailable();
			var actualRentalList = CreateRentalListForIsMovieAvailable();
			var actualMovieList = new List<Movie>();
			var expectedDvdItemList = new List<DvdItem>();
			expectedDvdItemList.Add(new DvdItem { dvdItemId = 7, movieId = 6, media = null, serial = "7", price = 1500 });
			var MovieRepository = new Mock<IMovieRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			var RentalRepository = new Mock<IRentalRepository>();

			MovieRepository.Setup(o => o.Find()).Returns(actualMovieList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);

			var movieEngine = new RentalsEngine(MovieRepository.Object, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var returnedIsMovieAvailableDvdItems = movieEngine.IsMovieAvailable(testMovieId);

			//assert
			Assert.IsNotNull(returnedIsMovieAvailableDvdItems, "Returned DvdItemList is null");
			Assert.AreEqual(1, returnedIsMovieAvailableDvdItems.Count);
			CollectionAssert.AreEquivalent(expectedDvdItemList, returnedIsMovieAvailableDvdItems, "Returned DvdItem List does not match expected");
		}

		[TestMethod]
		public void ListRentalsReturnsAllRentals()
		{
			//arrange
			var availableRental = CreateRentalList();
			var actualRental = CreateRentalList();

			var rentalRepository = new Mock<IRentalRepository>();
			rentalRepository.Setup(o => o.Find()).Returns(actualRental);
			var rentalsEngine = new RentalsEngine(null, null, rentalRepository.Object);

			//act
			var rental = rentalsEngine.ListRental();

			//assert
			Assert.IsNotNull(rental, "Return Rental collection is null");
			Assert.AreEqual(10, rental.Count);
			CollectionAssert.AreEquivalent(availableRental, rental, "Returned list of Rental are not equivalent to the expected list");
		}

		[TestMethod]
		public void ListRentalsReturnsEmptyListIfTheAreRentalsAtAll()
		{
			//arrange
			var rentalRepository = new Mock<IRentalRepository>();
			rentalRepository.Setup(o => o.Find()).Returns(new List<Rental>());
			var rentalEngine = new RentalsEngine(null, null, rentalRepository.Object);

			//act
			var returnedRentals = rentalEngine.ListRental();

			//assert
			Assert.IsNotNull(returnedRentals, "Returned Rentals list is null");
			Assert.AreEqual(0, returnedRentals.Count, "Returned Rentals has Rentals items");
		}

		[TestMethod]
		public void GetRantalFeeReturnsIntFee()
		{
			//arrange
			const int testDvdItemId = 1;
			const int testFee = 100;
			var actualDvdItems = CreateDvdList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, null);

			//act
			var returnedRentalFee = movieEngine.GetRentalFee(testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalFee, "Returned Rental Fee is null");
			Assert.AreEqual(returnedRentalFee, testFee, "Returned Rental Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetRantalFeeReturnsIntFeeLarge()
		{
			//arrange
			const int testDvdItemId = 4;
			const int testFee = 99999999;
			var actualDvdItems = CreateDvdList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, null);

			//act
			var returnedRentalFee = movieEngine.GetRentalFee(testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalFee, "Returned Rental Fee is null");
			Assert.AreEqual(returnedRentalFee, testFee, "Returned Rental Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetRantalFeeReturnsZeroforZeroRated()
		{
			//arrange
			const int testDvdItemId = 9;
			const int testFee = 0;
			var actualDvdItems = CreateDvdList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, null);

			//act
			var returnedRentalFee = movieEngine.GetRentalFee(testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalFee, "Returned Rental Fee is null");
			Assert.AreEqual(returnedRentalFee, testFee, "Returned Rental Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetRantalFeeReturnsZeroforNotSetItemPrice()
		{
			//arrange
			const int testDvdItemId = 2;
			const int testFee = 0;
			var actualDvdItems = CreateDvdList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, null);

			//act
			var returnedRentalFee = movieEngine.GetRentalFee(testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalFee, "Returned Rental Fee is null");
			Assert.AreEqual(testFee, returnedRentalFee, "Returned Rental Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetRantalFeeReturnsNonExistantDvdItem()
		{
			//arrange
			const int testDvdItemId = -1;
			const int testFee = 0;
			var actualDvdItems = CreateDvdList();

			var DvdItemRepository = new Mock<IDvdItemRepository>();
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItems);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, null);

			//act
			var returnedRentalFee = movieEngine.GetRentalFee(testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalFee, "Returned Rental Fee is null");
			Assert.AreEqual(returnedRentalFee, testFee, "Returned Rental Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetPenaltyFeeReturnsFeeZeroOnTime()
		{
			//arrange
			const int testRentalId = 1;
			const int testPenaltyFee = 0;
			var actualRentalList = CreateRentalList();

			var RentalRepository = new Mock<IRentalRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			var movieEngine = new RentalsEngine(null, null, RentalRepository.Object);

			//act
			var returnedRentalPenaltyFee = movieEngine.GetPenaltyFee(testRentalId);

			//assert
			Assert.IsNotNull(returnedRentalPenaltyFee, "Returned Penalty Fee is null");
			Assert.AreEqual(testPenaltyFee, returnedRentalPenaltyFee, "Returned Penalty Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetPenaltyFeeReturnsFeeLateOneDay()
		{
			//arrange
			const int testRentalId = 2;
			const int testPenaltyFee = 2500;
			var actualRentalList = CreateRentalList();

			var RentalRepository = new Mock<IRentalRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			var movieEngine = new RentalsEngine(null, null, RentalRepository.Object);

			//act
			var returnedRentalPenaltyFee = movieEngine.GetPenaltyFee(testRentalId);

			//assert
			Assert.IsNotNull(returnedRentalPenaltyFee, "Returned Penalty Fee is null");
			Assert.AreEqual(testPenaltyFee, returnedRentalPenaltyFee, "Returned Penalty Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void GetPenaltyFeeReturnsFeeLateTwoDays()
		{
			//arrange
			const int testRentalId = 3;
			const int testPenaltyFee = 5000;
			var actualRentalList = CreateRentalList();

			var RentalRepository = new Mock<IRentalRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			var movieEngine = new RentalsEngine(null, null, RentalRepository.Object);

			//act
			var returnedRentalPenaltyFee = movieEngine.GetPenaltyFee(testRentalId);

			//assert
			Assert.IsNotNull(returnedRentalPenaltyFee, "Returned Penalty Fee is null");
			Assert.AreEqual(testPenaltyFee, returnedRentalPenaltyFee, "Returned Penalty Fee does not Equal actual Rental Fee");
		}

		[TestMethod]
		public void CheckoutMovieNotAlreadyRented()
		{
			//arrange
			const int testClientId = 1;
			const int testDvdItemId = 1;
			var actualRentalList = CreateRentalList();
			var actualDvdItemList = CreateDvdItemList();
			var expectedRental = new Rental { rentalId = 11, dvdItemId = testDvdItemId, clientId = testClientId, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 17, 11, 00, 00) };
			var actualRentalReturned = new Rental();
		
			var RentalRepository = new Mock<IRentalRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItemList);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);
		
			//act
			var returnedRentalCheckout = movieEngine.CheckoutRental(testClientId, testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalCheckout, "Returned Checkout is null");
			Assert.IsTrue(returnedRentalCheckout, "Returned Checkout is not false");
			RentalRepository.Verify(x => x.Add(It.Is<Rental>(r => r.clientId ==1 && r.dvdItemId == 1)));
		}

		[TestMethod]
		public void CheckoutMovieAlreadyRented()
		{
			//arrange
			const int testClientId = 3;
			const int testDvdItemId = 23;
			var actualRentalList = CreateRentalList();
			var actualDvdItemList = CreateDvdItemList();
			var RentalRepository = new Mock<IRentalRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItemList);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);
		
			//act
			var returnedRentalCheckout = movieEngine.CheckoutRental(testClientId, testDvdItemId);

			//assert
			Assert.IsNotNull(returnedRentalCheckout, "Returned Checkout is null");
			Assert.IsFalse(returnedRentalCheckout, "Returned Checkout is not false");
		}

		[TestMethod]
		public void ReturnRentalReturnsFalseReturnNotRented()
		{
			//arrange
			const string testSerial = "72376";
			var actualRentalList = CreateRentalList();
			var actualDvdItemsList = CreateDvdList();

			var RentalRepository = new Mock<IRentalRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItemsList);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var ReturnRentalResponse = movieEngine.ReturnRental(testSerial);

			//assert
			Assert.IsNotNull(ReturnRentalResponse, "Returned ReturnedRental is null");
			Assert.IsFalse(ReturnRentalResponse, "Returned ReturnedRental is not False");
		}

		[TestMethod]
		public void ReturnRentalReturnsFalseReturnNeverRented()
		{
			//arrange
			const string testSerial = "45636";
			var actualRentalList = CreateRentalList();
			var actualDvdItemsList = CreateDvdList();

			var RentalRepository = new Mock<IRentalRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItemsList);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var ReturnRentalResponse = movieEngine.ReturnRental(testSerial);

			//assert
			Assert.IsNotNull(ReturnRentalResponse, "Returned ReturnedRental is null");
			Assert.IsFalse(ReturnRentalResponse, "Returned ReturnedRental is not False");
		}

		[TestMethod]
		public void ReturnRentalReturnsTrue()
		{
			//arrange
			const string testSerial = "64356";
			var actualRentalList = CreateRentalList();
			var actualDvdItemsList = CreateDvdList();

			var RentalRepository = new Mock<IRentalRepository>();
			var DvdItemRepository = new Mock<IDvdItemRepository>();
			RentalRepository.Setup(o => o.Find()).Returns(actualRentalList);
			DvdItemRepository.Setup(o => o.Find()).Returns(actualDvdItemsList);
			var movieEngine = new RentalsEngine(null, DvdItemRepository.Object, RentalRepository.Object);

			//act
			var ReturnRentalResponse = movieEngine.ReturnRental(testSerial);

			//assert
			Assert.IsNotNull(ReturnRentalResponse, "Returned ReturnedRental is null");
			Assert.IsTrue(ReturnRentalResponse, "Returned ReturnedRental is not True");
			RentalRepository.Verify(x => x.Modify(It.Is<Rental>(r => r.clientId == 5)));
		}

		private List<Rental> CreateRentalListForIsMovieAvailable()
		{
			var rentals = new List<Rental>();

			rentals.Add(new Rental { rentalId = 1, dvdItemId = 1, clientId = 1, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), actualReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { rentalId = 2, dvdItemId = 1, clientId = 2, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), actualReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { rentalId = 3, dvdItemId = 2, clientId = 3, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), actualReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { rentalId = 4, dvdItemId = 3, clientId = 4, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00)});
			rentals.Add(new Rental { rentalId = 5, dvdItemId = 4, clientId = 5, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), actualReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			return rentals;
		}

		private List<DvdItem> CreateDvdListForIsMovieAvailable()
		{
			var dvdItem = new List<DvdItem>();

			dvdItem.Add(new DvdItem { dvdItemId = 1, movieId = 1, media = null, serial = "1", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 2, movieId = 2, media = null, serial = "2", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 3, movieId = 2, media = null, serial = "3", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 4, movieId = 2, media = null, serial = "4", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 5, movieId = 4, media = null, serial = "5", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 6, movieId = 5, media = null, serial = "6", price = 1500 });
			dvdItem.Add(new DvdItem { dvdItemId = 7, movieId = 6, media = null, serial = "7", price = 1500 });

			return dvdItem;
		}

		private List<Rental> CreateRentalList()
		{
			var rentals = new List<Rental>();
			rentals.Add(new Rental { rentalId = 1, dvdItemId = 53, clientId = 1, rentalDate = new DateTime(2015, 09, 16, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 26, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 2, dvdItemId = 23, clientId = 3, rentalDate = new DateTime(2015, 09, 15, 10, 00, 00), expectedReturnDate = new DateTime(2015, 09, 25, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 3, dvdItemId = 6, clientId = 42, rentalDate = new DateTime(2015, 09, 4, 13, 00, 00), expectedReturnDate = new DateTime(2015, 09, 24, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 4, dvdItemId = 83, clientId = 4, rentalDate = new DateTime(2015, 09, 4, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 5, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 5, dvdItemId = 9, clientId = 24, rentalDate = new DateTime(2015, 09, 4, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 5, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 6, dvdItemId = 72, clientId = 4, rentalDate = new DateTime(2015, 09, 4, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 5, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 7, dvdItemId = 34, clientId = 25, rentalDate = new DateTime(2015, 09, 4, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 5, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 8, dvdItemId = 2, clientId = 5, rentalDate = new DateTime(2015, 09, 4, 14, 00, 00), expectedReturnDate = new DateTime(2015, 09, 5, 11, 00, 00), actualReturnDate = null });
			rentals.Add(new Rental { rentalId = 9, dvdItemId = 21, clientId = 2,  rentalDate = new DateTime(2015,09,4,14,00,00), expectedReturnDate = new DateTime(2015,09,5,11,00,00), actualReturnDate = null} );
			rentals.Add(new Rental { rentalId =10, dvdItemId = 10, clientId = 4,  rentalDate = new DateTime(2015,09,4,14,00,00), expectedReturnDate = new DateTime(2015,09,5,11,00,00), actualReturnDate = new DateTime(2015,09,5,11,00,00)} );
			return rentals;
		}

		private static List<DvdItem> CreateDvdList()
		{
			var dvdItem = new List<DvdItem>();
			dvdItem.Add(new DvdItem { dvdItemId = 1, movieId = 1, serial = "45636", price = 100 });
			dvdItem.Add(new DvdItem { dvdItemId = 2, movieId = 2, serial = "64356"});
																  
			dvdItem.Add(new DvdItem { dvdItemId = 3, movieId = 3, serial = "34572", price = 1 });
			dvdItem.Add(new DvdItem { dvdItemId = 4, movieId = 3, serial = "83676", price = 99999999 });
			dvdItem.Add(new DvdItem { dvdItemId = 5, movieId = 4, serial = "52653", price = 14551 });
			dvdItem.Add(new DvdItem { dvdItemId = 6, movieId = 4, serial = "74724", price = 550 });
			dvdItem.Add(new DvdItem { dvdItemId = 7, movieId = 5, serial = "13592", price = 2121 });
			dvdItem.Add(new DvdItem { dvdItemId = 8, movieId = 5, serial = "74842", price = 500 });
			dvdItem.Add(new DvdItem { dvdItemId = 9, movieId = 6, serial = "58925", price = 0 });
			dvdItem.Add(new DvdItem { dvdItemId =10, movieId = 6, serial = "72376", price = 500 });

			return dvdItem;
		}

		private static List<Movie> CreateMovieList(int numberOfMovies = 10)
		{
			var movies = new List<Movie>();
			for (var cnt = 0; cnt < numberOfMovies; cnt++)
			{
				movies.Add(new Movie { movieId = cnt, title = "abc", description = null, image = null, stars = null,  ageRestriction = null,  director = null});
			}
			return movies;
		}

		private static List<Movie> CreateSearchableMovieList(params string[] names)
		{
			var movies = new List<Movie>();
			int i = 0;
			foreach (string name in names) {
				i++;
				movies.Add(new Movie { movieId = i, title = name, description = null, image = null, stars = null, ageRestriction = null, director = null });
			}
			return movies;
		}

		private static List<DvdItem> CreateDvdItemList(int numberOfDvdItem = 10)
		{
			var dvdItem = new List<DvdItem>();
			for (var cnt = 0; cnt < numberOfDvdItem; cnt++)
			{
				dvdItem.Add(new DvdItem { dvdItemId = cnt, movieId = 1, media = null, serial = "1", price = 1500});
			}
			return dvdItem;
		}
	}
}
