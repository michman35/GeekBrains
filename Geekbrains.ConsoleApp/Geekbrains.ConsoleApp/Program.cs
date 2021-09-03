using System;

namespace Geekbrains.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var lesson4 = new lesson4();
			Console.WriteLine(lesson4.GetFullName("a", "b", "c"));
			Console.WriteLine(lesson4.Sum("1 2 3 4"));
			var yeartype = lesson4.GetYearType(9);
			YearTypeToString(yeartype);
			 
			Console.ReadKey();
		}
		static void YearTypeToString(YearType yearType)
		{
			switch (yearType)
			{
				case YearType.Winter:
					Console.WriteLine("Зима");
					break;
				case YearType.Spring:
					Console.WriteLine("Весна");
					break;
				case YearType.Summer:
					Console.WriteLine("Лето");
					break;
				case YearType.Autumn:
					Console.WriteLine("Осень");
					break;
				default:
				Console.WriteLine("Ошибка: введите число от 1 до 12");
					break;

			}
		}

	}

}
