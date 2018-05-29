using System;

namespace SwinAdventure
{
	/// <summary>
	/// anything that the player can interact with
	/// </summary>
	public abstract class GameObject :Identifiable_Object
	{
		/// <summary>
		/// The long description of the game object.
		/// </summary>
		private string _description;

		/// <summary>
		/// The name. a short description of the game object.
		/// </summary>
		private string _name;

		/// <summary>
		/// Initializes a new instance of a gameObject class.
		/// </summary>
		/// <param name="ids">Identifiers.</param>
		/// <param name="name">Name.</param>
		/// <param name="desc">Desc.</param>
		public GameObject (string[] ids, string name, string desc) :base(ids)
		{
			_description = desc;
			_name = name;
		}

		/// <summary>
		/// Gets the name.
		/// </summary>
		/// <value>The name.</value>
		public string Name
		{
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// Gets the short description made up from the name and the first id of the gameobject.
		/// This is used when referring to an object, rather than derectly examinign the object.
		/// </summary>
		/// <value>The short description.</value>
		public string ShortDescription
		{
			get
			{
				return _name;
			}
		}

		/// <summary>
		/// Gets the full description and can be changed by child classes.
		/// </summary>
		/// <value>The full description.</value>
		public virtual string FullDescription
		{
			get
			{
				return _description;
			}
		}
	}
}

