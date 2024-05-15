using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomSymbol
{
	public class RandomSymbolClass
	{
		public void RandomSymbol(char[] Alphabet, ConsoleKeyInfo userInput)
		{
			
			Random random = new Random();
			int randomNumber = random.Next(0, Alphabet.Length);
			//вывод
			//RandomColor();
			
			if(userInput.Key == ConsoleKey.Enter)
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

		
		
	}
}
