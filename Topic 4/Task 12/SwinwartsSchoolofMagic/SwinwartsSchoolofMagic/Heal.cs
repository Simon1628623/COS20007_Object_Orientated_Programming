using System;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Heal class type of spell.
	/// </summary>
	public class Heal : Spell
	{
		/// <summary>
		/// Initializes a new instance of the Heal class.
		/// </summary>
		public Heal ()
		{
			Name = "Default heal";
			Kind = SpellKind.Heal;
		}

		/// <summary>
		/// Initializes a new instance of the Heal class with chosen name.
		/// </summary>
		/// <param name="txt">Text.</param>
		public Heal (string txt)
		{
			Name = txt;
			Kind = SpellKind.Heal;
		}

		/// <summary>
		/// Method for casting spells to display text depending on what spell is cast.
		/// </summary>
		/// <param name="s">S.</param>
		public override void Cast (Spell s)
		{
			Result = "Ahhh... you feel better";
			Console.WriteLine (Result);

		}
	}
}

