using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Console.Read()->
read method is used to read single char from console
and returns the integer unicode of that

Console.ReadLine()->
readline method is used to read multi char from console
and returns the value as string

Console.ReadKey() ->
*/

namespace ConsoleDemoApp.Day2
{	
	internal class ConsoleInput
	{

		static void Main()
		{
			/*
			int CharUnicode;
			Console.WriteLine("Enter any char:");
			CharUnicode=Console.Read();
			//Console.WriteLine($"Charcode:{CharUnicode}");//C#6.0
			Console.WriteLine($"Charcode:{CharUnicode}");//C#6.0
			*/
			int id;
			string name;
			float salary;
			char grade;

			//for parsing
			//Int32.Parse(string)

			Console.WriteLine("Enter Id value:");
			id = Int32.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter name value:");
			name = Console.ReadLine();

			Console.WriteLine("Enter Salary value:");
			salary = Single.Parse(Console.ReadLine());

			Console.WriteLine("Enter grade value:");
			grade = Char.Parse(Console.ReadLine());

			//String Interpolation

			Console.WriteLine($"ID:{id}\tName:{name}\tSalary:{salary}\tGrade:{grade}");
		}
	}
}