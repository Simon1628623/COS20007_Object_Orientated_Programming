using System;


namespace SwinAdventure
{
	/// <summary>
	/// Bag class which is a type of item a player will carry
	/// </summary>
	public class Bag : Item
	{
		/// <summary>
		/// The inventory(items list) inside a bag.
		/// </summary>
		private Inventory _inventory;

		/// <summary>
		/// Initializes a new instance of the Bag class.
		/// 
		/// </summary>
		/// <param name="ids">Identifiers for the bag</param>
		/// <param name="name">Name of the bag</param>
		/// <param name="desc">Description of the bag</param>
		public Bag (string[] ids, string name, string desc) :base(ids, name, desc)
		{
			_inventory = new Inventory (new string[] { "bag", "container" }, "Bag", "holds stuff");
		}

		/// <summary>
		/// Locate the gameObject with a specified id which includes either the bag itself or any object inside the bag
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
		/// Gets the full description of the contents inside the bag including bag name, and the item list.
		/// </summary>
		/// <value>The full description.</value>
		public override string FullDescription
		{
			get
			{
				return "In the " + _inventory.Name + " you can see: "+ _inventory.ItemList;
			}
		}


		/// <summary>
		/// Gets the inventory which is all the objects bag contains.
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

