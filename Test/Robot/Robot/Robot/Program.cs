using System;

namespace Robot
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Testing creating Robot
			Robot r = new Robot ();
			//testing creating Laser
			Laser l = new Laser ("Lazor Beam");
			//testing attaching gadget
			r.Attach (l);
			Console.WriteLine("//checking deploying nothing");
			r.Deploy ("", true);
			//checking deploying Lazor
			r.Deploy ("Lazor Beam", true);
			Console.WriteLine ("//testing operating lazor");
			r.Operate ();



			Console.WriteLine("//testing operating non existing sonar");
			r.Deploy ("Sonar", true);
			r.Operate ();

			//testing creating Sonar
			Sonar s = new Sonar ("Sonar Beam");
			Console.WriteLine ("Testing un deployed Sonar");
			r.Attach (s);
			//testing sonar operating

			r.Operate();

			r.Deploy ("Sonar Beam", true);
			Console.WriteLine("//operating sonar and running out of Lazor ammo");
			r.Operate ();

			Console.WriteLine ("//un Deploying Lazor");
			r.Deploy("Lazor Beam", false);
		}
	}
}
