using System;
namespace StaticVarApplication
{
	class StaticVar
	{
		public static int num;
		
		private int getNum()
		{
			return num;
		}

		private static int getNums()
		{
			return num;
		}

		private void count()
		{
			num++;
		}

		static void Main(string[] args)
		{
			StaticVar s1 = new StaticVar();
			StaticVar s2 = new StaticVar();
			s1.count();
			s1.count();
			s1.count();
			s2.count();
			s2.count();
			s2.count();
			Console.WriteLine("Variable num for s1: {0}", s1.getNum());
			Console.WriteLine("Variable num for s2: {0}", s2.getNum());
			Console.WriteLine("Variable num: {0}", StaticVar.getNums());
			Console.ReadKey();
		}
	}
}
