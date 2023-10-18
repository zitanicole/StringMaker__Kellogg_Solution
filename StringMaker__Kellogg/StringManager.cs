using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker__Kellogg
{
	internal class StringManager
	{
		private string _input;

		public StringManager(string input)
		{
			_input = input;	
		}

		public string Reverse(string s) 
		{
			_input = s;
			char[] chars = s.ToCharArray();
			Stack<char> stack = new Stack<char>();
			foreach (char c in chars)
			{
				stack.Push(c);
			}

			char[] reversed = new char[chars.Length];
			int i = 0;	
			while(stack.Count > 0)
			{
				reversed[i] = stack.Pop();
				i++;
			}

			return new string(reversed);
		}

		/*public string Reverse(string s, bool PreserveCaseLocation)
		{

			return new string(reversed);
		}*/

		public bool Symmetric(string s)
		{
			string reversed = Reverse(s);
			if (reversed == s)
				return true;	
			else 
				return false;	
		}

		public override string ToString()
		{
			char[] chars = _input.ToCharArray();
			int[] ascii = new int[chars.Length];
			for (int i = 0 ; i < chars.Length; i ++)
				ascii[i] = (int)chars[i];

			

			return _input.ToString();
		}

	}
}
