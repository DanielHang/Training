using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WeatherJSONApplication
{
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
				client.BaseAddress = new Uri("");
				client.DefaultRequestHeaders.Accept.Clear();
			}
		}
	}
}
