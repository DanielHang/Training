using System;
using System.Threading;

namespace threading
{

	class Program
	{
		static Semaphore obj = new Semaphore(2, 4);

		static void Main(string[] args)
		{
			for (int i = 1; i <= 5; i++)
			{
				new Thread(SempStart).Start(i);
			}

			Console.ReadKey();
		}

		static void SempStart(object id)
		{
			Console.WriteLine(id + "-->>Wants to Get Enter");
			try
			{
				obj.WaitOne();
				Console.WriteLine(" Success: " + id + " is in!");

				Thread.Sleep(2000);
				Console.WriteLine(id + "<<-- is Evacuating");
			}
			finally
			{
				obj.Release();

			}
		}
	}
}