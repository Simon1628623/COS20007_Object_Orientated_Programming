using System;

namespace Robot
{
	public class Sonar: Gadget	
	{
		public Sonar (string name):base(name)
		{
			
		}

		public override void Operate ()
		{
			Console.WriteLine ("Ping");
		}
	}
}

