using System;

namespace ArrayApplication
{
	class MyArray
	{
		private double getAverage(int[] arr, int size)
		{
			int i;
			double ave;
			int sum = 0;
			for (i = 0; i < size; i++)
			{
				sum += arr[i];
			}
			ave = (double)sum / size;
			return ave; 
		}

		private int AddElements(params int[] arr)
		{
			int sum = 0;
			foreach (int elem in  arr)
			{
				sum += elem;
			}
			return sum;
		}

		private void ArrayMethods()
		{
			int[] list = { 34, 72, 13, 44, 25, 30, 10 };
			int[] temp = list;
			Console.Write("Original Array: ");

			foreach (int i in list)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			// reverse the array
			Array.Reverse(temp);
			Console.Write("Reversed Array: ");

			foreach (int i in temp)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();

			//sort the array
			Array.Sort(list);
			Console.Write("Sorted Array: ");

			foreach (int i in list)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			/* Declare Variables */
			MyArray app = new MyArray();
			int[] n = new int[10];
			int i,j;

			/* Initialise array elements */
			for (i = 0; i < 10; i++)
			{
				n[i] = i + 100;
			}

			/* Write out array variables with for loop */
			for (j = 0; j < 10; j++)
			{
				Console.WriteLine("Element[{0}] = {1}", j, n[j]);
			}
			Console.WriteLine();


			/* Write out array variables with foreach loop*/
			foreach (int k in n)
			{
				int m = k - 100;
				Console.WriteLine("Element[{0}] = {1}", m, k);
			}
			Console.WriteLine();

			/* String Array*/
			string[] names;


			/* 2 Dimension arrays*/
			int [,] a = new int[3,4] {
				{0, 1, 2, 3},
				{4, 5, 6, 7},
				{8, 9, 10, 11}
			};


			/* OUtput 2 Dimension Array */
			for (int r = 0; r < 3; r++){
				for (int c = 0; c < 4; c++)
				{
					Console.WriteLine("a[{0},{1}] = {2}", r, c, a[r,c]);
				}
			}
			Console.WriteLine();

			/* Jaggered Array */
			int[][] jagArr = new int[][] { new int[] { 0, 0 }, new int[] { 1, 2 }, new int[] { 2, 4 }, new int[] { 3, 6 }, new int[] { 4, 8 } };
			/* output each array element's value */
			for (int icnt = 0; icnt < 5; icnt++)
			{
				for (int jcnt = 0; jcnt < 2; jcnt++)
				{
					Console.WriteLine("a[{0}][{1}] = {2}", icnt, jcnt, jagArr[icnt][jcnt]);
				}
			}
			Console.WriteLine();

			/* Passing Arrays as funcxtion objects */
			int[] balance = new int[] { 1000, 2, 3, 17, 50 };
			double 	avg = app.getAverage(balance, 5);
			Console.WriteLine("Average value is: {0} ", avg);


			/* Param Arrays*/
			int summation = app.AddElements(512, 720, 250, 567, 889);
			Console.WriteLine("The sum is: {0}", summation);

			/* Array MEthods */
			app.ArrayMethods();

			Console.ReadKey();
		}
	}
}
