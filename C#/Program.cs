/*
	The Facade Design Pattern creates a single entry point, which does all of the "heavy lifting."
	In other words, if a task requires a series of method calls to accomplish, the Facade will
		allow the consumer to make a single method call, which executes all of the corresponding code.
 */

using Facade.Facade;
using System;

namespace Facade
{
	class Program
	{
		static void Main(string[] args)
		{
			var building = new BuildingFacade();

			Console.WriteLine(building.InspectBuilding());

			Console.ReadLine();
		}
	}
}
