using System;
using System.Threading;

namespace MyProgram
{
	class Program
	{
     	void Main (string[] args)
     	{
     		while(true)
     		{
     			Console.WriteLine("This is an endless program");
     			Thread.Sleep(500);
     		}
     		Console.ReadLine();
     	}
	}
}