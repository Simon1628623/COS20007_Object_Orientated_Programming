using System;

namespace Robot
{
	public abstract class Gadget
	{
		protected string _name;
		private bool _deployed;

		public Gadget (string name)
		{
			_name = name;
			_deployed = false;
		}

		public abstract void Operate();

		public string Name
		{
			get 
			{
				return _name;
			}
		}

		public bool Deployed
		{
			get
			{
				return _deployed;
			}
			set
			{
				_deployed = value;
			}
		}
	}
}

