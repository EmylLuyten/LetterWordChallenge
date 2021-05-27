using System.Collections.Generic;
using LetterWordChallenge.Models;

namespace LetterWordChallenge.Core
{
	public class SpellChecker
	{
		public List<WordClass> CheckSpelling(List<string> input)
		{


			NHunspell.Hunspell hunspell = new NHunspell.Hunspell(@"dict\en_US.aff", @"dict\en_us.dic");
			List<WordClass> wordList = new List<WordClass>();
			for (int firstI = 0; firstI < input.Count - 1; firstI++)
			{
				string first = input[firstI];

				for (int secondI = 0; secondI < input.Count - 1; secondI++)
				{
					string second = input[secondI];
					string word = first + second;
					if (word.Length == 6 && hunspell.Spell(word))
					{
						WordClass wordClass = new WordClass() { first = first, second = second, word = word };
						wordList.Add(wordClass);
					}
				}
			}

			return wordList;
		}
	}
}
