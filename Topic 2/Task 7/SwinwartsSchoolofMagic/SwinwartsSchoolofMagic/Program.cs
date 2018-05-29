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
			spells [0] = new Spell ("Mitch's mighty mover", SpellKind.Teleport);
			spells [1] = new Spell ("Paul's potent poultice", SpellKind.Heal);
			spells [2] = new Spell ("David's dashing disappearance", SpellKind.Invisibility);
			spells [3] = new Spell ("Stan's stunning shifter", SpellKind.Teleport);
			spells [4] = new Spell ("Lachlan's lavish longevity", SpellKind.Heal);

			CastAll (spells);
		}
	}
}
