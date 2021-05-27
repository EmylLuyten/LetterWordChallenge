using System;
using System.Collections.Generic;
using LetterWordChallenge.Models;

namespace LetterWordChallenge.Output
{
	public class OutputClass
	{
		public void printWordList(List<WordClass> list)
		{
			foreach (var item in list)
			{
				Console.WriteLine($"{item.first} + {item.second} = {item.word}");

			}

		}
	}
}
