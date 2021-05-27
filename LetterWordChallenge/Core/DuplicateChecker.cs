using System.Collections.Generic;
using System.Linq;
using LetterWordChallenge.Models;

namespace LetterWordChallenge.Core
{
	public class DuplicateChecker
	{
		public List<WordClass> checkForDuplicates(List<WordClass> wordList)
		{
			var FilteredList = wordList.GroupBy(x => new { x.first, x.second, x.word }).Select(y => new WordClass()
			{
				first = y.Key.first,
				second = y.Key.second,
				word = y.Key.word
			}).ToList();

			return FilteredList;
		}
	}
}
