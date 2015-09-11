﻿using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
	class Program
	{
		private static void showMatch(string text, string expr)
		{
			Console.WriteLine("The Expression: " + expr);
			MatchCollection mc = Regex.Matches(text, expr);
			foreach (Match m in mc)
			{
				Console.WriteLine(m);
			}
		}

		static void Main(string[] args)
		{
			string str = "A Thousand Splendid Suns";
			Console.WriteLine("Matching words that start with 'S': ");
			showMatch(str, @"\bS\S*");
			Console.WriteLine();

			str = "make maze and manage to measure it";
			Console.WriteLine("Matching words start with 'm' and ends with 'e':");
			showMatch(str, @"\bm\S*e\b");
			Console.WriteLine();

			string input = "Hello   World   ";
			string pattern = "\\s+";
			string replacement = " ";
			Regex rgx = new Regex(pattern);
			string result = rgx.Replace(input, replacement);
			Console.WriteLine("Original String: {0}", input);
			Console.WriteLine("Replacement String: {0}", result);
			Console.WriteLine();

			Console.ReadKey();
		}
	}
}