using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatticePathsApplication
{
	class LatticePathsApplication
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***LatticePaths***");
			int latticeSize = 20;
			long totalPaths = 0;
			totalPaths = getPath(latticeSize);
			Console.WriteLine();
			Console.WriteLine("There are {0} Lattice Paths for a Lattice of {1} by {1}.", totalPaths, latticeSize);
			Console.ReadKey();
		}
		
		private static long getPath(int latticeSize)
		{

			long [,] grid = new long[latticeSize+1,latticeSize+1];


			//Boundry weights
			for (int i = 0; i < latticeSize; i++)
			{
				grid[i,latticeSize] = 1;
				grid[latticeSize,i] = 1;
			}

			//inside weights

			for (int i = latticeSize - 1; i >= 0; i--)
			{
				for (int j = latticeSize - 1; j >= 0; j--)
				{
					grid[i,j] = grid[i+1,j] + grid[i,j+1];
				}

			}
				return grid[0,0];
		}


	}
}
