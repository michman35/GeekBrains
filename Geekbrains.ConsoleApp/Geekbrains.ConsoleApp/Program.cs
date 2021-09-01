using System;

namespace Geekbrains.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// Первое задание

			/* Console.Write("введите max температуру");

			int maxt = Convert.ToInt32(Console.ReadLine());

			Console.Write("введите min температуру");

			int mint = Convert.ToInt32(Console.ReadLine());

			int sredt = (maxt + mint) / 2;

			Console.WriteLine($"средняя температура " + sredt ) ;

			Console.ReadKey();

			*/

			// Второе задание

			/*

			Console.Write("Введите номер текущего месяца");

			int nuberOfmonth = Convert.ToInt32(Console.ReadLine());

			string month = "";

			switch (nuberOfmonth)

			{

			case 1:

			month = "январь";

			break;

			case 2:

			month = "февраль";

			break;

			case 3:

			month = "март";

			break;

			case 4:

			month = "апрель";

			break;

			case 5:

			month = "май";

			break;

			case 6:

			month = "июнь";

			break;

			case 7:

			month = "июль";

			break;

			case 8:

			month = "август";

			break;

			case 9:

			month = "сентябрь";

			break;

			case 10:

			month = "октябрь";

			break;

			case 11:

			month = "ноябрь";

			break;

			case 12:

			month = "декабрь";

			break;

			}

			Console.WriteLine(month);

			*/

			// Задание 3

			/*

			Console.Write("введите число");

			int a = Convert.ToInt32(Console.ReadLine()); ;

			if ( a %2 == 0 )

			{

			Console.WriteLine("число четное");

			}

			else

			{

			Console.WriteLine("число не четное ");

			}

			*/

			// Задание 4

			Console.WriteLine("Азбука вкуса ");

			string a = "молоко";

			int price1 = 50;

			Console.WriteLine(a + price1);

			string b = "хлеб";

			int price2 = 22;

			Console.WriteLine(b + price2);

			string c = "вода";

			int price3 = 25;

			Console.WriteLine(c + price3);

			int suma = price1 + +price2 + price3;

			double nds = suma * 0.18;

			Console.WriteLine("сумма " + suma);

			Console.WriteLine("НДС" + nds);

			Console.WriteLine(DateTime.Now);
		}
	}

}
