using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageManipulatorApplication
{
	class FileIO
	{
		internal static int[,] ReadFile(string fileName)
		{
			try
			{
				// Create an instance of StreamReader to read from a file.
				// The using statement also closes the StreamReader.
				using (StreamReader sr = new StreamReader(fileName))
				{
					string line;

					// Read and display lines from the file until 
					// the end of the file is reached. 
					while ((line = sr.ReadLine()) != null)
					{
						input = Convert.ToInt32(Console.ReadLine());
					}
				}
			}
			catch (Exception e)
			{

				// Let the user know what went wrong.
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
		}
	}
}
