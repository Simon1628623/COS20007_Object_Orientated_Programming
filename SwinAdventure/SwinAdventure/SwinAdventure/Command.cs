using System;

namespace SwinAdventure
{
	/// <summary>
	/// each command will need to be identifiable
	/// </summary>
	public abstract class Command: Identifiable_Object
	{
		public Command (string[] ids): base(ids)
		{
		}

		/// <summary>
		/// when data is entered by the user each command object will be asked AreYou and the first work of the command
		/// eg AreYou(look) locates command process to the text so the Look command can be identified
		/// </summary>
		/// <param name="p">P.</param>
		/// <param name="text">Text.</param>
		public abstract string Execute(Player p, string[] text)
		{
			
		}
	}
}

