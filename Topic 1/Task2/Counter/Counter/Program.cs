using System;

namespace Counter
{
	
	class MainClass
	{
		

		public static void PrintCounters(Counter[] counters)
		{
			foreach(Counter c in counters)
			{
				Console.WriteLine ("{" + c.Name + "} is {" +  c.Count + "}");
			}
		}

		public static void Main (string[] args)
		{
			Counter[] myCounter = new Counter[3];

			myCounter [0] = new Counter ("Counter 1");
			myCounter [1] = new Counter ("Counter 2");
			myCounter [2] = myCounter[0];


			for (int i = 0; i < 4; i++) 
			{
				myCounter [0].Increment ();
			}

			for (int i = 0; i < 9; i++) 
			{
				myCounter [1].Increment ();
			}

			MainClass.PrintCounters (myCounter);

			myCounter [2].Reset ();

			MainClass.PrintCounters (myCounter);
		}
	}
}
