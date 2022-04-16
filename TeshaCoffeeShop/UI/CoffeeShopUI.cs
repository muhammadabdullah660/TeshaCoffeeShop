using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffeeShop.BL;
namespace TeshaCoffeeShop.UI
{
    class CoffeeShopUI
    {
        public static CoffeeShop myCoffeeShop = new CoffeeShop("Alpha");


        public static void addItems ()
        {
            CoffeeShop.addSomeItems(myCoffeeShop);
        }
        public static void addMenuItem ()
        {
            myCoffeeShop.addMenuItem(MenuItemUI.takeInput());

        }
        public static void viewCheapest ()
        {
            string cheapest = myCoffeeShop.cheapestItem();
            Console.WriteLine(cheapest);
        }
        public static void viewDrinksMenu ()
        {
            List<string> newList = myCoffeeShop.drinksOnly();
            foreach (string item in newList)
            {
                Console.WriteLine(item);
            }
        }
        public static void viewFoodMenu ()
        {
            List<string> newList = myCoffeeShop.foodOnly();
            foreach (string item in newList)
            {
                Console.WriteLine(item);
            }
        }
        public static void placeOrder ()
        {
            Console.WriteLine("Enter name of the item you want to order");
            string name = Console.ReadLine();
            bool order = myCoffeeShop.addOrder(name);
            if (order)
            {
                Console.WriteLine("Order Added");
            }
            else
            {
                Console.WriteLine("This item is currently unavailable!");
            }

        }
        public static void orderFulfill ()
        {
            string status = myCoffeeShop.fulfillOrder();
            Console.WriteLine(status);
        }
        public static void viewOrders ()
        {
            List<string> newList = myCoffeeShop.listOrders();
            foreach (string item in newList)
            {
                Console.WriteLine(item);
            }
        }
        public static void viewAmount ()
        {
            Console.WriteLine(myCoffeeShop.dueAmount());
        }
    }
}
