using System;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Spell class to be able to use Spells in Swinwarts game.
	/// Currently has a name and a kind fields which are used in casting a spell method.
	/// </summary>
	public class Spell
	{
		/// <summary>
		/// The name of the spell which can be displayed when casting.
		/// </summary>
		private string name;

		/// <summary>
		/// The kind of spell which includes Invisibility, Heal and Teleport.
		/// </summary>
		private SpellKind kind;

		/// <summary>
		/// Constructor to initialize the spell's name and spell type/kind
		/// </summary>
		/// <param name="txt">Text.</param>
		/// <param name="Skind">Skind.</param>
		public Spell (string txt, SpellKind Skind)
		{
			name = txt;
			kind = Skind;
		}


		/// <summary>
		/// Used to access private name outside of the class 
		/// </summary>
		/// <value>The name.</value>
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

		/// <summary>
		/// Gets or sets the kind outside of the class.
		/// </summary>
		/// <value>The kind.</value>
		public SpellKind Kind
		{
			get 
			{
				return kind;
			}
			set 
			{
				kind = value;
			}
		}

		/// <summary>
		/// Method for casting spells to display text depending on what spell is cast.
		/// </summary>
		/// <param name="s">S.</param>
		public void Cast(Spell s)
		{
			if (s.kind == SpellKind.Teleport) 
			{
				Console.WriteLine ("Player casts Teleport");
			}

			if (s.kind == SpellKind.Invisibility) 
			{
				Console.WriteLine ("Player casts Invisibility");
			}

			if (s.kind == SpellKind.Heal) 
			{
				Console.WriteLine ("Player casts Heal");
			}
		}
	}
}

