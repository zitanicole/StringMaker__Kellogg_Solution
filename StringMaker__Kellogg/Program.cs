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
			Console.WriteLine("Ascii Table Values: " + ascii);

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