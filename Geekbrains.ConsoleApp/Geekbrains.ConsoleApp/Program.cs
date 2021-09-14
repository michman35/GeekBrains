using System;
using System.IO;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Geekbrains.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// задание 1

			//Console.WriteLine("введите текст");

			//string text = Console.ReadLine();
			//File.WriteAllText("text.txt", text);

			using(var stream = File.Open("startup.txt", FileMode.Append))
			using(var stramWriter = new StreamWriter(stream))
			{
				
				stramWriter.WriteLine(DateTime.Now.TimeOfDay);
			}

			Console.WriteLine("числа");

			string text = Console.ReadLine();
			//var bytes = text.Split(" ").Select(x => byte.Parse(x)).ToArray();
			//File.WriteAllBytes("text.dll", bytes);

		    File.WriteAllText("text.dll", text);

		}

	}
}

