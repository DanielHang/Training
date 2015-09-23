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
			var availableSearchableMovies = CreateSearchableMovieList(MovieTitle6);
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
			expectedDvdItemList.Add(new DvdItem { DvdItemId = 1, MovieId = 1, Price = 1500 });

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
			expectedDvdItemList.Add(new DvdItem { DvdItemId = 2, MovieId = 2, Price = 1500 });
			expectedDvdItemList.Add(new DvdItem { DvdItemId = 4, MovieId = 2, Price = 1500 });
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
			expectedDvdItemList.Add(new DvdItem { DvdItemId = 7, MovieId = 6, Price = 1500 });
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
		public void GetRantalFeeReturnsSetFeeforNotSetItemPrice()
		{
			//arrange
			const int testDvdItemId = 2;
			const int testFee = 250;
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
			var expectedRental = new Rental { RentalId = 11, DvdItemId = testDvdItemId, ClientId = testClientId, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ExpectedReturnDate = new DateTime(2015, 09, 17, 11, 00, 00) };
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
			RentalRepository.Verify(x => x.Add(It.Is<Rental>(r => r.ClientId ==1 && r.DvdItemId == 1)));
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
			const int testSerial = 72376;
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
			const int testSerial = 45636;
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
			const int testSerial = 64356;
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
			RentalRepository.Verify(x => x.Modify(It.Is<Rental>(r => r.ClientId == 5)));
		}

		private List<Rental> CreateRentalListForIsMovieAvailable()
		{
			var rentals = new List<Rental>();

			rentals.Add(new Rental { RentalId = 1, DvdItemId = 1, ClientId = 1, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { RentalId = 2, DvdItemId = 1, ClientId = 2, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { RentalId = 3, DvdItemId = 2, ClientId = 3, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			rentals.Add(new Rental { RentalId = 4, DvdItemId = 3, ClientId = 4, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00)});
			rentals.Add(new Rental { RentalId = 5, DvdItemId = 4, ClientId = 5, RentalDate = new DateTime(2015, 09, 16, 14, 00, 00), ReturnDate = new DateTime(2015, 09, 18, 11, 00, 00) });
			return rentals;
		}

		private List<DvdItem> CreateDvdListForIsMovieAvailable()
		{
			var dvdItem = new List<DvdItem>();

			dvdItem.Add(new DvdItem { DvdItemId = 1, MovieId = 1, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 2, MovieId = 2, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 3, MovieId = 2, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 4, MovieId = 2, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 5, MovieId = 4, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 6, MovieId = 5, Price = 1500 });
			dvdItem.Add(new DvdItem { DvdItemId = 7, MovieId = 6, Price = 1500 });

			return dvdItem;
		}

		private List<Rental> CreateRentalList()
		{
			var rentals = new List<Rental>();
			rentals.Add(new Rental { RentalId = 1, DvdItemId = 53, ClientId = 1,  RentalDate = new DateTime(2015,09,16,14,00,00), ExpectedReturnDate = new DateTime(2015,09,23,11,00,00)} );
			rentals.Add(new Rental { RentalId = 2, DvdItemId = 23, ClientId = 3,  RentalDate = new DateTime(2015,09,15,10,00,00), ExpectedReturnDate = new DateTime(2015,09,22,11,00,00)} );
			rentals.Add(new Rental { RentalId = 3, DvdItemId = 6,  ClientId = 42, RentalDate = new DateTime(2015,09,4,13,00,00), ExpectedReturnDate = new DateTime(2015,09,21,11,00,00)} );
			rentals.Add(new Rental { RentalId = 4, DvdItemId = 83, ClientId = 4,  RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId = 5, DvdItemId = 9,  ClientId = 24, RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId = 6, DvdItemId = 72, ClientId = 4,  RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId = 7, DvdItemId = 34, ClientId = 25, RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId = 8, DvdItemId = 2,  ClientId = 5,  RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId = 9, DvdItemId = 21, ClientId = 2,  RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00)} );
			rentals.Add(new Rental { RentalId =10, DvdItemId = 10, ClientId = 4,  RentalDate = new DateTime(2015,09,4,14,00,00), ExpectedReturnDate = new DateTime(2015,09,5,11,00,00), ReturnDate = new DateTime(2015,09,5,11,00,00)} );
			return rentals;
		}

		private static List<DvdItem> CreateDvdList()
		{
			var dvdItem = new List<DvdItem>();
			dvdItem.Add(new DvdItem { DvdItemId = 1, MovieId = 1, Serial = 45636, Price = 100 });
			dvdItem.Add(new DvdItem { DvdItemId = 2, MovieId = 2, Serial = 64356});
																
			dvdItem.Add(new DvdItem { DvdItemId = 3, MovieId = 3, Serial = 34572, Price = 1 });
			dvdItem.Add(new DvdItem { DvdItemId = 4, MovieId = 3, Serial = 83676, Price = 99999999 });
			dvdItem.Add(new DvdItem { DvdItemId = 5, MovieId = 4, Serial = 52653, Price = 14551 });
			dvdItem.Add(new DvdItem { DvdItemId = 6, MovieId = 4, Serial = 74724, Price = 550 });
			dvdItem.Add(new DvdItem { DvdItemId = 7, MovieId = 5, Serial = 13592, Price = 2121 });
			dvdItem.Add(new DvdItem { DvdItemId = 8, MovieId = 5, Serial = 74842, Price = 500 });
			dvdItem.Add(new DvdItem { DvdItemId = 9, MovieId = 6, Serial = 58925, Price = 0 });
			dvdItem.Add(new DvdItem { DvdItemId =10, MovieId = 6, Serial = 72376, Price = 500 });

			return dvdItem;
		}

		private static List<Movie> CreateMovieList(int numberOfMovies = 10)
		{
			var movies = new List<Movie>();
			for (var cnt = 0; cnt < numberOfMovies; cnt++)
			{
				movies.Add(new Movie { MovieId = cnt });
			}
			return movies;
		}

		private static List<Movie> CreateSearchableMovieList(params string[] names)
		{
			var movies = new List<Movie>();
			foreach (string title in names) {
				movies.Add(new Movie { Title = title });
			}
			return movies;
		}

		private static List<DvdItem> CreateDvdItemList(int numberOfDvdItem = 10)
		{
			var dvdItem = new List<DvdItem>();
			for (var cnt = 0; cnt < numberOfDvdItem; cnt++)
			{
				dvdItem.Add(new DvdItem { DvdItemId = cnt });
			}
			return dvdItem;
		}
	}
}
