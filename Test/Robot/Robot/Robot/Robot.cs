using System;
using System.Collections.Generic;

namespace Robot
{
	public class Robot
	{
		private List<Gadget> _devices;

		public Robot ()
		{
			_devices = new List<Gadget> ();
		}

		public void Attach(Gadget gadget)
		{
			_devices.Add (gadget);
		}

		public void Deploy(string name, bool flag)
		{
			if(flag)
			{
				foreach (Gadget d in _devices) 
				{
					if (name == d.Name) 
					{
						d.Deployed = true;
					}
					else 
					{
						Console.WriteLine ("NO gadget deployed");
					}
				}
			}
			else 
			{
				Console.WriteLine ("NO gadget deployed");
			}
		}

		public void Operate()
		{
			foreach(Gadget d in _devices)
			{
				if(d.Deployed)
				{
					d.Operate ();
				}
				else
				{
					Console.WriteLine("I'm afraid I can't do that");
				}
			}


		}
	}
}

