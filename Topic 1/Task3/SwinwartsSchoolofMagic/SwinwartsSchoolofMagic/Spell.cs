using System;

namespace SwinwartsSchoolofMagic
{
	public class Spell
	{
		private string name;
		private SpellKind kind;

		public Spell (string txt, SpellKind Skind)
		{
			name = txt;
			kind = Skind;
		}

		public string Name
		{
			get 
			{
				return name;
			}
			set 
			{
				name = value;
			}
		}

		public SpellKind Kind
		{
			get 
			{
				return kind;
			}

		}

		public void Cast(Spell s)
		{
			if (s.kind == SpellKind.Teleport) 
			{
				Console.WriteLine ("Player casts Teleport");
			}

			else if (s.kind == SpellKind.Invisibility) 
			{
				Console.WriteLine ("Player casts Invisibility");
			}

			else if (s.kind == SpellKind.Heal) 
			{
				Console.WriteLine ("Player casts Heal");
			}
		}
	}
}

