using System;

namespace SwinAdventure
{
	public class Player : GameObject
	{
		/// <summary>
		/// The inventory each player has.
		/// </summary>
		private Inventory _inventory;

		/// <summary>
		/// Initializes a new instance of the Player class.
		/// </summary>
		/// <param name="name"> Player Name.</param>
		/// <param name="desc">Full Description.</param>
		public Player (string name, string desc):
		//calling the gameobject constructor and pass up identifiers for me and inventory
		base(new string[] {"me", "inventory"}, name, desc)
		{
			_inventory = new Inventory (new string[] { "me", "inventory" }, "Inventory", "Bag for player");
		}

		/// <summary>
		/// Locate the specified id.
		/// finds gameobjects somewhere around the player
		/// </summary>
		/// <param name="id">Identifier.</param>
		public GameObject Locate(string id)
		{
			if(AreYou(id))
			{
				return this;
			}

			else
			{
				return _inventory.Fetch (id);
			}
		}

		/// <summary>
		/// Gets the full description and can be changed by child classes.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription
		{
			get
			{
				return "You are carrying: " + _inventory.ItemList;
			}
		}

		/// <summary>
		/// Gets the inventory object.
		/// </summary>
		/// <value>The inventory.</value>
		public Inventory Inventory
		{
			get
			{
				return _inventory;
			}
		}

	}
}

