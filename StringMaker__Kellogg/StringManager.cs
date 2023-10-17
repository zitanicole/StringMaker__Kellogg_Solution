using System;
using System.Collections.Generic;
using System.Linq;
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

	}
}
