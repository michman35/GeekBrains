using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.ConsoleApp
{
	class Lesson3
	{
		public void LogArray()
		{
			const int rows = 5;
			const int columns = 2;


			var array = new string[rows, columns];

			array[0, 0] = "popov";
			array[0, 1] = "8921111111";

			array[1, 0] = "repin";
			array[1, 1] = "8925651111";

			array[2, 0] = "muka";
			array[2, 1] = "892111361";

			array[3, 0] = "Name1";
			array[3, 1] = "893431111";

			array[4, 0] = "Name2";
			array[4, 1] = "892116411";

			for(int i = 0; i < rows; i++)
			{
				Console.WriteLine($"{array[i, 0]} {array[i, 1]}");

			}

		}
		public void LogArrayReverse()
		{
			Console.WriteLine("введите строку");
			var word = Console.ReadLine();
			for(int i = word.Length - 1; i >= 0; i--)
			{
				Console.Write(word[i]);
			}
		}

		public void GoodArray()
		{
			int x = 0;
			int[,] a = new int[3, 3];
			var s = a.Length;
			for(int i = 0; i < 3; i++)
			{
				for(int j = 0; j < 3; j++)
				{
					a[i, j] = x + 1;

					Console.WriteLine($"{x} {a[i, j]}");
					x++;
				}
			}

		}
	}
}

