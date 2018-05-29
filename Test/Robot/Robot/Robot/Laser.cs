using System;

namespace Robot
{
	public class Laser: Gadget
	{
		private int _shots;


		public Laser (string name):base(name)
		{
			_shots = 3;

		}

		public override void Operate()
		{
			if (_shots > 0) {
				Console.WriteLine ("ZAP!");
				_shots -= 1;
			} else
				Console.WriteLine ("Fizzle");
		}

		public void Recharge()
		{
			_shots = 3;
		}
	}
}

