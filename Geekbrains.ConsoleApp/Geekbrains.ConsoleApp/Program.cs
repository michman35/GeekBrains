using System;

namespace Geekbrains.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("введите имя ");
			var name = Console.ReadLine();		
			Console.WriteLine($"привет {name} {DateTime.Now}" );

			Console.ReadKey();
		}
	}
}
