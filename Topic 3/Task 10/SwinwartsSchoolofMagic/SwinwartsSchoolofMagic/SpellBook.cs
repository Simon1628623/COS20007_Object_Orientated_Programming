using System;
using System.Collections.Generic;

namespace SwinwartsSchoolofMagic
{
	/// <summary>
	/// Spell book class to be used in swinwarts game.
	/// currently has book list, count of books and add or remove spell.
	/// </summary>
	public class SpellBook
	{
		private List<Spell> myBook = new List<Spell>();

		/// <summary>
		/// Indexer that is a special kind of property that allows the caller to access the object using an index liek an array
		/// </summary>
		/// <param name="i">The index.</param>
		public Spell this[int i]
		{
			get
			{
				return myBook[i];
			}
		}



		public SpellBook ()
		{
			
		}

		/// <summary>
		/// COunts how many Spells in the spellBook
		/// </summary>
		/// <value>The spell count.</value>
		public int SpellCount 
		{
			get
			{
				return myBook.Count;
			}
		}

		/// <summary>
		/// Making you able to add new spells to the spellBook
		/// </summary>
		/// <param name="spell">Spell.</param>
		public void AddSpell (Spell spell)
		{
			myBook.Add (spell);
		}

		/// <summary>
		/// Having the ability to remove spells from spell book
		/// </summary>
		/// <param name="spell">Spell.</param>
		public void RemoveSpell (Spell spell)
		{
			myBook.Remove (spell);
		}


	}
}

