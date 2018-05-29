using System;

namespace SwinAdventure
{
	public class Look_Command: Command
	{
		public Look_Command (string[] ids): base(ids)
		{
		}

		public override string Execute (Player p, string[] text)
		{
			
		}

		private string LookAtIn(Player p, string thingId, string containerId)
		{
			
		}
	}
}

