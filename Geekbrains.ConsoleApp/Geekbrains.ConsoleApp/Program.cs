using System;
using System.Diagnostics;
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
			var process = Process.GetProcesses();
			for(int i = 0; i < process.Length; i++)
			{
				var p = process[i];
				Console.WriteLine($"{p.Id} {p.ProcessName}");
			}

			Console.WriteLine("введите id ");
			var id = int.Parse(Console.ReadLine());
			var kill = Process.GetProcessById(id);
			kill.Kill();

			Console.WriteLine("введите имя процесса ");
			var name = Console.ReadLine();

			for(int i = 0; i < process.Length; i++)
			{
				var p = process[i];

				if( name == p.ProcessName)
				{
					p.Kill();
					
				}
              
			}


		}
	}
}


