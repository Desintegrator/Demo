using System;

namespace MyProgram
{
	class Program
	{
     	void Main (string[] args)
     	{
     		Console.WriteLine("This C# Console Project\ncan count till 10");
     		for (int i = 0; i < 10; i++)
     		{
     			Console.WriteLine(i);
     		}
     		Console.WriteLine("Done!");
     		Console.ReadLine();
     	}
	}
}