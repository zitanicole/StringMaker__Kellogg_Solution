using System.Runtime.InteropServices;

namespace StringMaker__Kellogg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			StringManager sm = new StringManager("input");
			string reversed = sm.Reverse("Sunbeam Tiger");
			Console.WriteLine("Reversed String: " + reversed);
			
		}
	}
}