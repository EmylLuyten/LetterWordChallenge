using System.Collections.Generic;

namespace LetterWordChallenge
{
	public class GetTheInputs
	{
		
		public List<string> ReadTextFile() {
			string line;
			List<string> inputs = new List<string>();

			System.IO.StreamReader file = 
				new System.IO.StreamReader(@"Input\input.txt");
			while ((line = file.ReadLine()) != null) {
				inputs.Add(line);
			}

			return inputs;
		}
	}
}
