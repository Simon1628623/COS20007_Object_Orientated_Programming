using System;

namespace SwinwartsSchoolofMagic
{
	class MainClass
	{

		public static void CastAll(Spell[] spells)
		{
			for (int i = 0; i < spells.Length; i++) 
			{	
				Console.WriteLine (spells[i].Name);
				spells [i].Cast (spells[i]);
			}
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			Spell[] spells = new Spell[5];
			spells [0] = new Teleport ("Mitch's mighty mover");
			spells [1] = new Heal ("Paul's potent poultice");
			spells [2] = new Invisibility ("David's dashing disappearance");
			spells [3] = new Teleport ("Stan's stunning shifter");
			spells [4] = new Heal ("Lachlan's lavish longevity");

			CastAll (spells);
		}
	}
}
