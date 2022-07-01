


using System;
using System.Collections.Generic;
using Milestone3;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {


            InventoryManager i1 = new InventoryManager();
            int ch;

            for (; ; )
            {

                Console.WriteLine("1.........Add item");
                Console.WriteLine("2.........Display item");
                Console.WriteLine("3.........Remove item");
                Console.WriteLine("4.........Search item by name");
                Console.WriteLine("5.........Search item by price");
                Console.WriteLine("6.........Edit/Re-stock item");
                Console.WriteLine("7.........Exit");


                Console.WriteLine("Enter choice");
                ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        i1.addItemToInventory();
                        break;
                    case 2:
                        i1.displayItem();
                        break;

                    case 3:
                        i1.removeItemFromInventory();
                        break;
                    case 4:
                        Console.WriteLine("Enter item name to search ");
                        string nameOfItem = Console.ReadLine();
                        i1.searchItemByName(nameOfItem);
                        break;

                    case 5:

                        Console.WriteLine("Enter price to search ");
                        double priceToSearch = Convert.ToDouble(Console.ReadLine());
                        i1.searchItemByPrice(priceToSearch);
                        break;

                    case 6:
                        Console.WriteLine("Enter item name to edit stock ");
                        string editItemName = Console.ReadLine();

                        i1.modifyItem(editItemName);
                        break;

                    case 7:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }
}

