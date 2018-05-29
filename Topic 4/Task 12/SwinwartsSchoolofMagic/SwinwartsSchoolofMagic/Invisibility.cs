using System;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Invisibility class for spells.
	/// </summary>
	public class Invisibility : Spell
	{
		/// <summary>
		/// checking to see if previosuly casted
		/// </summary>
		private bool _wasCast;

		/// <summary>
		/// Initializes a new instance of the Invisibility class. (constructor)
		/// </summary>
		public Invisibility ()
		{
			_wasCast = false;
			Name = "Default Invisibility";
			Kind = SpellKind.Invisibility;
		}

		/// <summary>
		/// Initializes a new instance of the Invisibility class with a name. (constructor)
		/// </summary>
		public Invisibility (string txt)
		{
			_wasCast = false;
			Name = txt;
			Kind = SpellKind.Invisibility;
		}

		/// <summary>
		/// Gets a value indicating whether this Invisibility was cast.
		/// </summary>
		/// <value><c>true</c> if was cast; otherwise, <c>false</c>.</value>
		public bool WasCast
		{
			get
			{
				return _wasCast;
			}
		}

		/// <summary>
		/// Method for casting spells to display text depending on what spell is cast.
		/// </summary>
		/// <param name="s">S.</param>
		public override void Cast (Spell s)
		{
			if (!_wasCast) 
			{
				Result = "Player casts Invisibility";
				Console.WriteLine (Result);

				_wasCast = true;
			}
			else 
			{
				Result = "pzzzzit";
				Console.WriteLine (Result);
			}
		}

	}
}

