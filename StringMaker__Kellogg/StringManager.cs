using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

		public string Reverse(string s, bool PreserveCaseLocation)
		{
			char[] chars = s.ToCharArray();
			Stack<char> stack = new Stack<char>();
			Queue<char> queue = new Queue<char>();
			bool pcl = PreserveCaseLocation;

			foreach(char c in chars)
			{
				stack.Push(c);
				queue.Enqueue(c);	
			}

			char[] reversed = new char[chars.Length];	
			int i = 0;
			while(stack.Count > 0)
			{
				char or = queue.Dequeue();
				char rev = stack.Pop();
				if (pcl && char.IsLetter(or) && char.IsLetter(rev))
				{
					if (char.IsUpper(or))
					{
						rev = char.ToUpper(rev);
					}
					else
					{
						rev = char.ToLower(rev);
					}
				}
				reversed[i] = rev; i++;
			}

			return new string(reversed);
		}

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
			int sum = 0;
				foreach (char c in chars)
				{
					sum += (int)c;
				}
				while (sum > 0)
				{
					int digit = sum % 10;
					if (digit == 0)
						_input += "Zero ";
					if (digit == 1)
						_input += "One ";
					if (digit == 2)
						_input += "Two ";
					if (digit == 3)
						_input += "Three ";
					if (digit == 4)
						_input += "Four ";
					if (digit == 5)
						_input += "Five ";
					if (digit == 6)
						_input += "Six ";
					if (digit == 7)
						_input += "Seven ";
					if (digit == 8)
						_input += "Eight ";
					if (digit == 9)
						_input += "Nine ";
					sum /= 10;
				}
			return _input.ToString();
		}
	}
}
