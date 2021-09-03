using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geekbrains.ConsoleApp
{
	enum YearType 
	{
		None,
		Winter,
		Spring,
		Summer,
		Autumn,
	}

	class lesson4
	{
		public string GetFullName(string firstName, string lastName, string patronymic)
		{
			return $"{firstName}{lastName}{patronymic}";
			
		}

		public int Sum(string array)
		{
			
			var result = 0;
			var data = array.Split(" ");
			foreach(var item in data)
			{
				var number = int.Parse(item);
				result += number;

			}
			return result;

		}
		public YearType GetYearType(int mouth )
		{
			if(mouth >= 12 && mouth <= 2)
			{
				return YearType.Winter;
			}
			else if(mouth >= 3 && mouth <= 5)
			{
				return YearType.Spring;
			}
			else if(mouth >= 6 && mouth <= 8)
			{
				return YearType.Summer;
			}
			else if(mouth >= 8 && mouth <= 11)
			{
				return YearType.Autumn;
			}

			return YearType.None;
		}
	}
}
