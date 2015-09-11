using System;
namespace StructureApplication
{
	struct Books
	{
		public string title;
		public string author;
		public string subject;
		public int book_id;

		public void setValues(string p1, string p2, string p3, int p4)
		{
			title = p1;
			author = p2;
			subject = p3;
			book_id = p4;
		}

		public void display()
		{
			Console.WriteLine("Title: {0}", title);
			Console.WriteLine("Auther: {0}", author);
			Console.WriteLine("Subject: {0}", subject);
			Console.WriteLine("Book_id: {0}", book_id);
		}
	};

	class Program
	{
		static void Main(string[] args)
		{
			/* Declare Book1 and Boook2 of type Books */
			//Books Book1, Book2;
			Books Book1 = new Books();
			Books Book2 = new Books();



			/* book1 Specs */
/*			Book1.title = "C Programming";
			Book1.author = "Nuha Ali";
			Book1.subject = "C Programming Tutorial";
			Book1.book_id = 6495407;
*/			Book1.setValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);


			/* book2 specs */
/*			Book2.title = "Telecom Billing";
			Book2.author = "Zara Ali";
			Book2.subject = "Telecom Billing Tutorial";
			Book2.book_id = 6495700;
*/			Book2.setValues("Telecom Billing", "Zara Ali", "Telecome Billing Tutorial", 6495700);



			/* print Book1 info */
/*			Console.WriteLine("Book 1 of title: {0}", Book1.title);
			Console.WriteLine("Book 1 of auther: {0}", Book1.author);
			Console.WriteLine("Book 1 of subject: {0}", Book1.subject);
			Console.WriteLine("Book 1 of book_id: {0}", Book1.book_id);
*/			Book1.display();

			/* print Book2 info */
/*			Console.WriteLine("Book 2 of title: {0}", Book2.title);
			Console.WriteLine("Book 2 of auther: {0}", Book2.author);
			Console.WriteLine("Book 2 of subject: {0}", Book2.subject);
			Console.WriteLine("Book 2 of book_id: {0}", Book2.book_id);
*/			Book2.display();

			Console.ReadKey();
		}
	}
}
