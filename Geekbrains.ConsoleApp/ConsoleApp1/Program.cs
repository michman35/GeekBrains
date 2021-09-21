using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine(Properties.Settings.Default.hi);
			Console.WriteLine(Properties.Settings.Default["name"]);
			Console.WriteLine(Properties.Settings.Default["age"]); 
			Console.WriteLine(Properties.Settings.Default["work"]);
			Console.Write("введите имя");
			string name = Console.ReadLine();
			Properties.Settings.Default["name"] = name;
			Console.Write("введите возраст");
			string age = Console.ReadLine();
			Properties.Settings.Default["age"] = age;
			Console.Write("работу");
			string work = Console.ReadLine();
			Properties.Settings.Default["work"] = work;

			Properties.Settings.Default.Save();
			Properties.Settings.Default.Reload();
			
			Console.ReadKey();
		}
	}
}
