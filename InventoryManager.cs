using System;
namespace Milestone3
{
	class InventoryManager
	{
		//List collection
		List<Item> inventoryList = new List<Item>();
		public void addItemToInventory()
		{
			string itemName;
            double itemPrice;
			int quantity;


			Console.WriteLine("Enter item name ");
			itemName = Console.ReadLine();

			Console.WriteLine("Enter item price ");
			itemPrice = Convert.ToDouble(Console.ReadLine());


			Console.WriteLine("Enter item quantity ");
			quantity = Convert.ToInt32(Console.ReadLine());

			Item i = new Item(itemName, itemPrice, quantity); //CREATING NEW ITEM
		List<Item> inventoryList2 = new List<Item>();//ADDING ITEM TO LIST

		}

		public void displayItem()
		{

			string inventoryLayout = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(inventoryLayout + "\n");

			foreach (Item i in inventoryList)
			{

				string inventoryLayout2 = String.Format("{0,10}{1,10}{2,10}", i.ItemName, i.ItemPrice, i.Quantity);
				Console.WriteLine(inventoryLayout2 + "\n");

			}


		}

		public void removeItemFromInventory()
		{

			Console.WriteLine("Enter item name to remove ");
			string itemName = Console.ReadLine();

			int flagItem = 0;

			//SCANNING LIST COLLECTION
			for (int i = 0; i < inventoryList.Count; i++)
			{
				//CHECKING WHETHER USER GIVEN NAME IS EQUAL TO THE CURRENT ITEMS NAME
				//OR NOT
				if (inventoryList[i].ItemName.Equals(itemName)) //IF FOUND THE ITEM
				{
					inventoryList.RemoveAt(i);//REMOVE THE ITEM ON THAT INDEX
					Console.WriteLine("Item removed");
					flagItem = 1;
				}
			}

			if (flagItem == 0)
				Console.WriteLine("Item not found");

		}

		//SEARCH ITEM BY NAME
		public void searchItemByName(string name)
		{

			int itemFlag = 0;
			//DISPLAY HEADING
			string itemName = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(itemName + "\n");

			//SCANNING TOTAL LIST
			foreach (Item i in inventoryList)
			{

				//IF USER GIVEN NAME FOUND
				if (i.ItemName.Equals(name))
				{
					//DISPLAY THE DETAILS
					string s1 = String.Format("{0,10}{1,10}{2,10}", i.ItemName, i.ItemPrice, i.Quantity);
					Console.WriteLine(s1 + "\n");
					itemFlag = 1;
				}

			}

			if (itemFlag == 0)
				Console.WriteLine("Item not found");


		}

		//SEARCH ITEM BY PRICE
		public void searchItemByPrice(double price)
		{

			int itemFlag = 0;
			string inventoryLayout = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
			Console.WriteLine(inventoryLayout + "\n");

			//SCANNING TOTAL LIST
			foreach (Item i in inventoryList)
			{

				//IF USER GIVEN PRICE FOUND
				if (i.ItemPrice == price)
				{
					//DISPLAY THAT ITEM
					string inventoryLayout2 = String.Format("{0,10}{1,10}{2,10}", i.ItemName, i.ItemPrice, i.Quantity);
					Console.WriteLine(inventoryLayout2 + "\n");
					itemFlag = 1;
				}

			}

			if (itemFlag == 0)
				Console.WriteLine("Item not found");

		}


		public void modifyItem(string itemName)
		{


			Console.WriteLine("Enter new stock quantity for this item ");
			string stockQuantity = Console.ReadLine();

			int quantity = Convert.ToInt32(stockQuantity);

			//SCANNING EACH ITEM
			foreach (Item item in inventoryList)
			{


				if (item.Equals(itemName))//IF ITEM FOUND
				{
					item.Quantity = quantity;//CHANGING THE QUANTITY
					Console.WriteLine("quantity updated");
				}

			}

		}

	}
}

