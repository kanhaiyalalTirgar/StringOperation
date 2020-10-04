using System;

namespace StringOperation
{
    class Program
    {
		static void Main(string[] args)
		{
			string input;

			Console.WriteLine("Input the string : ");
			input = Console.ReadLine().ToLower();
			int max = 0;
			string character = "";

			while (input.Length > 0)
			{
				int count = 0;
				string tempcharacter = "";
				for (int j = 0; j < input.Length; j++)
				{
					if (input[0] == input[j])
					{
						count++;
						tempcharacter = input[j].ToString();
					}
				}

				input = input.Replace(input[0].ToString(), string.Empty);

				if (count > max)
				{
					character = tempcharacter;
					max = count;
				}
			}

			if (character != " ")
			{
				Console.Write(" Max Frequently character : " + character + " : " + max);
			}
			else
			{
				Console.Write("Max Frequently Space : " + max);
			}

			Console.ReadLine();

		}
	}
}
