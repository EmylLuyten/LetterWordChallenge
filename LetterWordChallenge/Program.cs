using System;
using System.Collections.Generic;
using LetterWordChallenge.Core;
using LetterWordChallenge.Models;
using LetterWordChallenge.Output;

namespace LetterWordChallenge
{
	class Program
	{
		static void Main(string[] args)
		{

			GetTheInputs inputs = new GetTheInputs();
			List<string> input = inputs.ReadTextFile();

			SpellChecker spellChecker = new SpellChecker();
			List<WordClass> wordList = spellChecker.CheckSpelling(input);

			DuplicateChecker duplicateChecker = new DuplicateChecker();
			List<WordClass> filteredList = duplicateChecker.checkForDuplicates(wordList);

			OutputClass output = new OutputClass();
			output.printWordList(filteredList);

			Console.Read();
		}
	}


}