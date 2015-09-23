using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageManipulatorApplication
{
	class ImageMain
	{
		static void Main(string[] args)
		{
			/*declare variables*/
			int input = 0;
			int [,] imageData;
			String fileName = "d:\\dev\\Sandboxes\\Training\\C#\\FileReadTextApplication\\FileReadTextApplication\\bin\\Debug\\jamaica.txt";

			/*Image Read*/
			Console.WriteLine("Reading Image...");
			FileIO FileHandler = new FileIO();
			imageData = FileIO.ReadFile(fileName);
			Console.WriteLine(imageData);



			/*User interaction*/
			Console.WriteLine("Which image manipulation do you want to perform?");
			Console.WriteLine("1: Mirror");
			Console.WriteLine("2: Flip");
			Console.WriteLine("3: Blur");
			while (input <= 0 || input > 3)
			{
				input = Convert.ToInt32(Console.ReadLine());
			}
			switch(input) {
				case 1:
					Console.WriteLine("Mirror Processing");
					break;
				case 2:
					Console.WriteLine("Flip Processing");
					break;
				case 3:
					Console.WriteLine("Blur Processing");
					break;
				default:
					Console.WriteLine("If you are readng this there is a problem");
					break;
			}
			Console.ReadKey();
		}
	}
}
