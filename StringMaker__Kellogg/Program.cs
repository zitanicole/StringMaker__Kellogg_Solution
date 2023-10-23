using System.Runtime.InteropServices;
// Nicci Kellogg
// IT113
// NOTES: This assignment was super challenging. It took me a lot of time. I'm glad I got through it and I hope it is what is to be expected. P.S. Thank you for the extra time to complete it!
// BEHAVIORS NOT IMPLIMENTED AND WHY: Am I suppose to pass in a public instance of input from StringManager when I call an instance of StringManager (sm); and have main hold on to that current version of input throughout the program? If that is the case, then I did not do that becuase 6 of the 7 tests require new data to be passed in anyway. 
namespace StringMaker__Kellogg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StringManager sm = new StringManager("Sunbeam Tiger");

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
			bool equals = sm.Equals("Sunbeam Tiger");
			Console.WriteLine("Input is a string: " + equals);

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