using System.Runtime.InteropServices;

namespace StringMaker__Kellogg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StringManager sm = new StringManager("input");

			// test 1
			string reversed = sm.Reverse("Sunbeam Tiger");
			Console.WriteLine("Reversed String: " + reversed);

			// test 2
			string ascii = sm.ToString();
			Console.WriteLine("Ascii Table Values Summed and Spelled Out: " + ascii);

			// test 3
			string rev = sm.Reverse("Sumbeam Tiger", true);
			Console.WriteLine("Reversed String with Preserved Casing: " + rev); 

			// test 4
			sm.Equals("Sunbeam Tiger");

			// test 5, 6, 7 
			bool ABBA = sm.Symmetric("ABBA");
			Console.WriteLine(ABBA);
			bool ABA = sm.Symmetric("ABA");
			Console.WriteLine(ABA);
			bool ABba = sm.Symmetric("ABba");
			Console.WriteLine(ABba);



		}
	}
}