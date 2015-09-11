using System;
namespace StringApplication
{
	class Program
	{
		static void Main(string[] args)
		{
			//from string literal and string concatenation
			string fname, lname;
			fname = "Rowan";
			lname = "Atkinson";

			string fullname = fname + lname;
			Console.WriteLine("Full Name: {0}", fullname);

			//by using string constructor
			char[] letters = { 'H', 'e', 'l', 'l', 'o' };
			string greetings = new string(letters);
			Console.WriteLine("Greetings: {0}", greetings);

			//methods returning string
			string[] sarray = { "Hello", "From", "Tutorials", "Point" };
			string message = String.Join(" ", sarray);
			Console.WriteLine("Message: {0}", message);

			//formatting method to convert a value
			DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
			string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
			Console.WriteLine("Message: {0}", chat);

			string str1 = "This is test";
			string str2 = "This is text";

			if (String.Compare(str1, str2) == 0)
			{
				Console.WriteLine(str1 + " and " + str2 + " are equal.");
			}
			else
			{
				Console.WriteLine(str1 + " and " + str2 + " are not equal.");
			}
			
			string str = "This is test";
			if (str.Contains("test"))
			{
				Console.WriteLine("The sequence 'test' was found.");
			}

			str = "Last night I dreamt of San Pedro";
			Console.WriteLine(str);
			string substr = str.Substring(23);
			Console.WriteLine(substr);

			string[] starray = new string[]{"Down the way nights are dark",
				"And the sun shines daily on the mountain top",
				 "I took a trip on a sailing ship",
				 "And whenI reached Jamaica",
				 "I made a stop"};
			str = String.Join(". ",starray);
			Console.WriteLine(str);
			str = String.Join("\n", starray);
			Console.WriteLine(str);

			Console.ReadKey();
		}
	}
}
