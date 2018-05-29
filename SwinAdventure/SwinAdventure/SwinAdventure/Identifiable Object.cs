using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	public class Identifiable_Object
	{
		private List<String> _identifiers;

		/// <summary>
		/// Initializes a new instance of the Identifiable_Object class.
		/// Constructor
		/// </summary>
		public Identifiable_Object (string[] idents)
		{
			_identifiers = new List<String>();

			foreach(string i in idents)
			{
				AddIdentifier (i);
			}

		}

		/// <summary>
		/// checks if the passed in identifier is in the _identifiers
		/// </summary>
		public bool AreYou(string id)
		{
			foreach(string i in _identifiers)
			{
				if(i.ToLower() == id.ToLower())
				{
					return true;
				}

			}
			return false;
		}

		/// <summary>
		/// returns the first identifier from _identifier (or empty string)
		/// </summary>
		/// <returns>The identifier.</returns>
		public string FirstId()
		{
			if (_identifiers.Count >= 1) 
			{
				return _identifiers[0];
			} 
			else 
			{
				return "";
			}
		}

		/// <summary>
		/// converts the identifier to lower case and stores it in _identifiers
		/// </summary>
		/// <param name="id">Identifier.</param>
		public void AddIdentifier(string id)
		{
			_identifiers.Add (id.ToLower());
		}


	}
}

