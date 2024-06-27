using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSymbol
{
	public class RandomClass
	{
		public void RandomSymbol(char[] Alphabet, ConsoleKeyInfo userInput)
		{
			
			Random random = new Random();
			int randomNumber = random.Next(0, Alphabet.Length);
			//int randomNumber = random.Next(0, 2);
			//вывод
			//RandomColor();

			if (userInput.Key == ConsoleKey.Enter)
			{
			Console.WriteLine(Alphabet[randomNumber]);
			}
			if(userInput.Key == ConsoleKey.Spacebar)
			{
			Console.Write(Alphabet[randomNumber] + " ");
			}
			else
			{
				return;
			}
			
			using (StreamWriter sw = new StreamWriter(@"C:\Users\kenot\source\repos\RandomSymbol\RandomSymbol\bin\Debug\GameLog.txt",true))
			{				
				sw.Write(Alphabet[randomNumber] + " ");
				
				//foreach (char symbol in Alphabet)
				//{
				//	sw.WriteLine(symbol);
				//}
			}
			


		}
		public void RandomColor()
		{
			string[] Colors = { "Red", "Green", "Blue", "Yellow", "Cyan", "Magenta" };
			Random randomColor = new Random();
			int randomIndex = randomColor.Next(0, Colors.Length);
			ConsoleColor color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Colors[randomIndex]);
			Console.ForegroundColor = color;
		}
		public void RandomNumber(int[] numbers)
		{
			Random random = new Random();
			int randomNumber = random.Next(0, numbers.Length);
			Console.WriteLine(randomNumber);
			//if (randomNumber == 37)
			//{
			//	Console.WriteLine("Vertasium");
			//}
			
		}

		public void RandomWord(string[] words)
		{
			Random random = new Random();
			int randomNumber = random.Next(0, words.Length);
			Console.WriteLine(words[randomNumber]);
		}
		public int wordIndex = 0;
		public void RandomWordWithDeleting(string[] words)
		{
			Random random = new Random();
			
			List<string> listOfWords = words.ToList();
			int randomNumber = random.Next(0, listOfWords.Count);
			if(listOfWords[randomNumber] != null)
			{
				wordIndex++;
				Console.WriteLine(wordIndex + " " + listOfWords[randomNumber]);
				listOfWords.RemoveAt(randomNumber);
			}

			
			
		}
		
		
	}
}
