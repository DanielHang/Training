using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ProductStoreClient
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

	class Program
	{
		static void Main()
		{
			RunAsync().Wait();
		}

		static async Task RunAsync()
		{
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri("http://www.omdbapi.com/");
				client.DefaultRequestHeaders.Accept.Clear();
				client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				client.Timeout = TimeSpan.FromMilliseconds(1000);
				String param_builder = "?" + "i" + "=" +"tt0936501";
				
				// HTTP GET
				try
				{
					HttpResponseMessage response = await client.GetAsync(param_builder);
					response.EnsureSuccessStatusCode();
					MovieInfo movie = await response.Content.ReadAsAsync<MovieInfo>();
					Console.WriteLine(movie.Title);
					Console.WriteLine(movie.Genre);
					Console.WriteLine(movie.Plot);
					Console.WriteLine(movie.Actors);
					Console.WriteLine(movie.imdbRating);
				}
				catch (HttpRequestException e)
				{
					Console.WriteLine("HTTP Exception caught: {0}", e);
				}
				Console.ReadKey();
			}
		}
	}
}