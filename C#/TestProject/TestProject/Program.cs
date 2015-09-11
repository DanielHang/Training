using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			//Variable data size in BYTES
			Console.WriteLine("Size of int: {0}", sizeof(int));
			
			// Object 
			object obj;
			obj = 100; // this is boxing
			Console.WriteLine("Object: {0}", obj);

			// Dynamic Variable
			dynamic d = 20;
			Console.WriteLine("Dynamic Variable: {0}", d);

			// String Variables
			String str = "string variable";
			Console.WriteLine("This is a : {0}", str);

			// String Variables
			String str2 = @"string variable";
			Console.WriteLine("This is another : {0}", str2);

			//Pointer Type
			//char* cptr;
			//int* iptr;

			//Explicit Conversion
			double dub = 5673.74;
			int inty;
			// Cast double to int
			inty = (int)dub;
			Console.WriteLine("Double {0} cast to int: {1}", dub, inty);

			//To string conversion
			int intie = 75;
			float effie = 53.005f;
			double dee = 2345.7652;
			bool bee = true;

			Console.WriteLine("int to String: {0}",intie.ToString());
			Console.WriteLine("float to String: {0}", effie.ToString());
			Console.WriteLine("double to String: {0}", dee.ToString());
			Console.WriteLine("boolean to String: {0}", bee.ToString());

			Console.WriteLine("Integral types: sbyte, byte, short, ushort, int, uint, long, ulong, and char");
			Console.WriteLine("Floating point types: float and double");
			Console.WriteLine("Decimal types: decimal");
			Console.WriteLine("Boolean types: true or false values, as assigned");
			Console.WriteLine("Nullable types: Nullable data types");

			//Variable Definitions
			int var1, var2, var3;
			char var4, var5;
			float var6, var7;
			double var8;

			//Variable Instantiation at time of definition
			int sametime = 123;
			byte biteme = 22;
			double pi = 3.14159;
			char upup = 'u', downdown = 'd';

			// Read in a string to int32
			Console.Write("Enter a number: ");
			int inputNum;
			inputNum = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You entered: {0}", inputNum);


			//Integers
			Console.WriteLine("Legal Integers: 212, 215u, 0xFeeL");
			Console.WriteLine("Illegal Integers: 032UU");
			Console.WriteLine("Decimal: 58");
			Console.WriteLine("Octal: 02311");
			Console.WriteLine("Hexadecimal: 0x4b");
			Console.WriteLine("Int: 30");
			Console.WriteLine("Unsigned int: 30u");
			Console.WriteLine("Long: 30l");
			Console.WriteLine("Unsigned long: 30ul");

			//Floats
			Console.WriteLine("Legal Floating Point: 3.14159");
			Console.WriteLine("Legal Floating Point: 314159E-5L");
			Console.WriteLine("Illegal Floating Point: 510E");
			Console.WriteLine("Illegal Floating Point: 210f");
			Console.WriteLine("Illegal Floating Point: .e55");


			//Escape char
			Console.WriteLine("Hello\tWorld\n\n");
			Console.WriteLine("hello, dear");
			Console.Write("hello, ");
			Console.WriteLine("dear");
			Console.WriteLine("hello, "+ "d"+ "ear");
			Console.WriteLine(@"hello, dear");

			//Constant Declaration
			const double pie = 3.14159;
			Console.WriteLine("Pie is: {0}", pie);

			//Arithmetic Operators
			Console.WriteLine("Arithmetic Operators: + , - , * , / , % , ++ , --");

			//Relational Operators
			Console.WriteLine("Relational Operators: == , != , > , < , >= , <=");
			

			//Logical Operators
			Console.WriteLine("Logical Operators: && , ||, !");

			//Bitwise Operators
			Console.WriteLine("Bitwise Operators: & , | , ^ , ~ , << , >>");
			
			//Assignment Operators
			Console.WriteLine("Assignment Operators: = , += , -= , /= , %= , <<= , >>= , &= , ^= , !=");

			//Miscillaneous Operators
			Console.WriteLine("Misc Operators: sizeof() : Returns size of data type");
			Console.WriteLine("Misc Operators: typeof() : Returns type of class");
			Console.WriteLine("Misc Operators: & : Returns the address of a variable");
			Console.WriteLine("Misc Operators: * : Points to a variable");
			Console.WriteLine("Misc Operators: ?: Conditional Expression");
			Console.WriteLine("Misc Operators: is : Determines whether an object is of a certain type");
			Console.WriteLine("Misc Operators: as : Cast without raising an exception if the cast fails");

			//If Statements
			if (true)
			{
				Console.WriteLine("It's true");
				if (true)
				{
					Console.WriteLine("Its true inside the truth!!!");
				}
			}
			else if (false)
			{
				Console.WriteLine("Its False");
			}

			// :? Statement
			int question = 1;
			String answer = "";
			answer = (question == 1) ? "YES" : "NO";
			Console.WriteLine("Answer is {0}", answer);


			//Case Statements
			int whatsyourcase = 0;
			Console.Write("State your CASE: [1/2/3] ");
			whatsyourcase = Convert.ToInt32(Console.ReadLine());
			switch(whatsyourcase)
			{
				case 1:
					Console.WriteLine("Case Number ONE");
					break;

				case 2:
					Console.WriteLine("Case Number TWO");
					break;
				case 3:
					Console.WriteLine("Case Number THREE");
					break;
				default:
					Console.WriteLine("You don't have a CASE");
					break;
			}

			//While Loops
			Console.WriteLine("While greater than 0");
			int counter = 10;
			while (counter > 0)
			{
				Console.Write("{0} ", counter);
				counter--;
			}
			Console.WriteLine();

			//For Loops
			Console.WriteLine("For 15 to 25 Loops");
			for (int i = 15; i <= 25; i++)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();

			Console.WriteLine("Do.........while less than 10");
			do {
				counter++;
				Console.Write("{0} ", counter);
			}while(counter < 10);
			Console.WriteLine();

			Console.WriteLine("Nested For Loops");
			for (int i=0; i < 10; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write("{0}{1} ", i, j);
				}
				Console.WriteLine();
			}

			// Hold console window open until ENTER KEY PRESS
			Console.WriteLine("******END OF TEST******");
			Console.WriteLine("**Press Enter to EXIT**");
			Console.ReadLine();
		}
	}
}
