using System;
namespace Milestone3
{
		class Item
		{

			//INSTANCE VARIABLES
			string itemName;
			double itemPrice;
			int itemQuantity;

		//CONSTRUCTOR
		public Item(string name, double price, int quantity)
			{
			ItemName = name;
			ItemPrice = price;
			Quantity = quantity;
			}

			//GETTER AND SETTER
			public string ItemName { get => itemName; set => itemName = value; }
			public double ItemPrice { get => itemPrice; set => itemPrice = value; }
			public int Quantity { get => itemQuantity; set => itemQuantity = value; }
		}
}

