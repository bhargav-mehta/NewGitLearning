using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGitApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This is my first git code. Modified.");
			Console.WriteLine("Second line added in git code");
			Console.WriteLine("Third line added in git code. Modified in my original machine");
			Print("MyMessage");
            Print("New Message.");
            Print("Again New Message.");
        }

		static void Print(string message)
		{
			Console.WriteLine($"Print {message}");
		}
	}
}
