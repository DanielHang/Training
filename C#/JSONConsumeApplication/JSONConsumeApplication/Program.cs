using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace JSONConsumeApplication
{
	class MovieInfo
	{
		public string Title { get; set; }
		public string Year { get; set; }
		public string Rated { get; set; }
		public string Released { get; set; }
		public string Runtime { get; set; }
		public string Genre { get; set; }
		public string Director { get; set; }
		public string Writer { get; set; }
		public string Actors { get; set; }
		public string Plot { get; set; }
		public string Language { get; set; }
		public string Country { get; set; }
		public string Awards { get; set; }
		public string Poster { get; set; }
		public string Metascore { get; set; }
		public string imdbRating { get; set; }
		public string imdbVotes { get; set; }
		public string imdbID { get; set; }
		public string Type { get; set; }
		public string Response { get; set; }
	}

	class MovieGrabber
	{
		public List<String> moviesToGet = new List<string>();

		static void Main(string[] args)
		{
			MovieGrabber mg = new MovieGrabber();
			mg.moviesToGet.Add("tt0119654");
			mg.moviesToGet.Add("tt0936501");
			mg.moviesToGet.Add("tt3832914");
			mg.moviesToGet.Add("tt4046784");
			mg.moviesToGet.Add("tt2403021");
			mg.moviesToGet.Add("tt2510894");
			mg.moviesToGet.Add("tt2361509");
			mg.moviesToGet.Add("tt3018070");
			mg.moviesToGet.Add("ttqqqqqqq");
			
			Console.WriteLine("Starting movie Info Retrieval");
			Console.WriteLine();
			List<MovieInfo> MovieInfoList = mg.CreateMultipleTasksAsync().Result;
			Console.WriteLine("Finished Movie Retrieval");
			Console.WriteLine(".....Printing Results.....");
			Console.WriteLine();
			Console.WriteLine();
			foreach (var movie in MovieInfoList)
			{
				Console.WriteLine(movie.Title);
				Console.WriteLine(movie.Year);
				Console.WriteLine(movie.Rated);
				Console.WriteLine(movie.Released);
				Console.WriteLine(movie.Runtime);
				Console.WriteLine(movie.Genre);
				Console.WriteLine(movie.Director);
				Console.WriteLine(movie.Writer);
				Console.WriteLine(movie.Actors);
				Console.WriteLine(movie.Plot);
				Console.WriteLine(movie.Language);
				Console.WriteLine(movie.Country);
				Console.WriteLine(movie.Awards);
				Console.WriteLine(movie.Poster);
				Console.WriteLine(movie.Metascore);
				Console.WriteLine(movie.imdbRating);
				Console.WriteLine(movie.imdbVotes);
				Console.WriteLine(movie.imdbID);
				Console.WriteLine(movie.Type);
				Console.WriteLine(movie.Response);
				Console.WriteLine();
			}
			Console.ReadKey();

		}

		private async Task<List<MovieInfo>> CreateMultipleTasksAsync()
		{
			HttpClient client = new HttpClient();
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			List<Task<MovieInfo>> workLoad = new List<Task<MovieInfo>>();
			foreach (var movies in moviesToGet)
			{
				workLoad.Add(ProcessMovieAsync("http://www.omdbapi.com/?i=" + movies, client));
			}

			List<MovieInfo> mi = new List<MovieInfo>();
			foreach (var workTask in workLoad)
			{
				MovieInfo movie = await workTask; 
				if (movie.Response == "True")
					mi.Add(movie);
			}
			return mi;
		}

		async Task<MovieInfo> ProcessMovieAsync(string url, HttpClient client)
		{
			HttpResponseMessage response = await client.GetAsync(url);
			response.EnsureSuccessStatusCode();
			MovieInfo movie = await response.Content.ReadAsAsync<MovieInfo>();
			return movie;
		}
	}
}
