using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RandomSymbol
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = "note1.txt";
			using(StreamReader reader = new StreamReader(path))
			{
				Console.WriteLine(reader.ReadToEnd());
			};
			char[] Alphabet =
				{
				'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я'
				};
			bool isWorking = true;
			
			var RandomSymbolObj = new RandomSymbolClass();
			Console.WriteLine("Данная программа выводит случайный символ русского алфавита по нажатии любой кнопки!");
			Console.ReadKey();
			//Вызвать случайный символ
			while (isWorking)
			{
				ConsoleKeyInfo userInput = Console.ReadKey();
				RandomSymbolObj.RandomColor();
				RandomSymbolObj.RandomSymbol(Alphabet, userInput);

				


			}
			
			
		}
		
	}
}
