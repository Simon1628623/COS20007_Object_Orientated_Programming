using System;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Teleport class part of a spell.
	/// </summary>
	public class Teleport : Spell
	{
		/// <summary>
		/// The random value to be generated.
		/// </summary>
		private static Random _random = new Random();
		/// <summary>
		/// The random value to be used in testing to make sure value is right.
		/// </summary>
		private double Rnd;

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinwartsSchoolofMagic.Teleport"/> class.
		/// </summary>
		public Teleport ()
		{
			Name = "Default teleport";
			Kind = SpellKind.Teleport;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SwinwartsSchoolofMagic.Teleport"/> class with a chosen name.
		/// </summary>
		/// <param name="txt">Text.</param>
		public Teleport (string txt)
		{
			Name = txt;
			Kind = SpellKind.Teleport;
		}

		/// <summary>
		/// Gets the random value for testing.
		/// </summary>
		/// <value>The random.</value>
		public double Random
		{
			get
			{
				return Rnd;
			}
		}

		/// <summary>
		/// Method for casting spells to display text depending on what spell is cast.
		/// depending on random value it can cast 2 possible results.
		/// </summary>
		/// <param name="s">S.</param>
		public override void Cast (Spell s)
		{
			Rnd = _random.NextDouble ();

			if(Rnd == 1)
			{
				Result = "Poof... you apear somewhere else";
				Console.WriteLine (Result);

			}

			if(Rnd == 0)
			{
				Result = "arrr... I'm too tired to move";
				Console.WriteLine (Result);

			}

		}
	}
}

