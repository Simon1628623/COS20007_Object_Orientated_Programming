using System;
using System.Collections.Generic;

namespace SwinAdventure
{
	/// <summary>
	/// a managed list of items
	/// </summary>
	public class Inventory :GameObject
	{

		private List<Item> _items; 
		private string itemlist;

		public Inventory (string[] ids, string name, string desc) :base(ids, name, desc)
		{
			_items = new List<Item>();
			itemlist = "";
		}

		/// <summary>
		/// Determines whether the inventory has the item using its specified id.
		/// </summary>
		/// <returns><c>true</c> if this instance has item the specified id; otherwise, <c>false</c>.</returns>
		/// <param name="id">Identifier.</param>
		public bool HasItem(string id)
		{
			foreach (Item i  in _items)
			{
				if(i.AreYou(id))
				{
					return true;
				}
			}
			
			return false;
		}

		/// <summary>
		/// Put the specified item in the inventory.
		/// </summary>
		/// <param name="itm">Itm.</param>
		public void Put(Item itm)
		{
			_items.Add (itm);
		}

		/// <summary>
		/// Take the specified item from the inventory.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public Item Take (string id)
		{
			foreach(Item i in _items)
			{
				if(AreYou(id))
				{
					_items.Remove (i);

					return i; 
				}
			}
			return null;

		}

		/// <summary>
		/// Fetch the specified id by AreYou and returns it.
		/// </summary>
		/// <param name="id">Identifier.</param>
		public Item Fetch(string id)
		{
			foreach (Item i in _items) 
			{
				if (i.AreYou(id)) 
				{
					return i;
				}
			}
			return null;

		}


		/// <summary>
		/// Gets the item list.
		/// </summary>
		/// <value>The item list.</value>
		public string ItemList
		{
			get
			{
				foreach (Item i in _items)
				{
					itemlist += i.FullDescription + " (" + i.ShortDescription + ")" + Environment.NewLine; 
				}
				return itemlist;
			}
		}
	}
}

