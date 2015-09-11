using System;
namespace CalculatorApplication
{
	class NumberManipulator
	{
		public int FindMax(int a, int b)
		{
			/* local variable declaration */
			int result;

			result = (a > b) ? a : b;
			return result;
		}

		public int Factorial(int num)
		{
			/* local variable declaration */
			int result;
			if (num == 1)
			{
				return 1;
			}
			else
			{
				result = Factorial(num - 1) * num;
				return result;
			}
		}

		public void getValue(out int x, out int y)
		{
			int temp = 5;
			x = temp;
			y = temp + 5;
		}

		static void Main(string[] args)
		{
			/*local variable declaration*/
			int a = 100;
			int b = 200;
			int? c = null;
			int d;
			int ret;
			NumberManipulator n = new NumberManipulator();

			//Calling the FindMax method
			ret = n.FindMax(a,b);
			Console.WriteLine("Max value is: {0}", ret);
			for (int i = 1; i <= 13; i++)
			{
				Console.WriteLine("Factorial of {0} is: {1}",i , n.Factorial(i));
			}

			Console.WriteLine("Before method call, value of a : {0}", a);
			Console.WriteLine("Before method call, value of b : {0}", b);
			/* calling a function to get the value */
			n.getValue(out a, out b);
			Console.WriteLine("After method call, value of a : {0}", a);
			Console.WriteLine("After method call, value of b : {0}", b);

			// NUll Coalescing
			d = c ?? 5;
			Console.WriteLine(" Value of d: {0}", d);
			c = 2;
			d = c ?? 5;
			Console.WriteLine(" Value of d: {0}", d);
			Console.ReadLine();
		}
	}
}
