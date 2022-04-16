using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffeeShop.BL;
using TeshaCoffeeShop.UI;
namespace TeshaCoffeeShop
{
    class Program
    {
        static void Main ()
        {
            CoffeeShopUI.addItems();
            int op = 0;
            while (op < 9)
            {
                op = mainMenu();
                clearScreen();
                if (op == 1)
                {
                    CoffeeShopUI.addMenuItem();
                    clearScreen();
                }
                else if (op == 2)
                {
                    CoffeeShopUI.viewCheapest();
                    clearScreen();
                }
                else if (op == 3)
                {
                    CoffeeShopUI.viewDrinksMenu();
                    clearScreen();
                }
                else if (op == 4)
                {
                    CoffeeShopUI.viewFoodMenu();
                    clearScreen();
                }
                else if (op == 5)
                {
                    CoffeeShopUI.placeOrder();
                    clearScreen();
                }
                else if (op == 6)
                {
                    CoffeeShopUI.orderFulfill();
                    clearScreen();
                }
                else if (op == 7)
                {
                    CoffeeShopUI.viewOrders();
                    clearScreen();
                }
                else if (op == 8)
                {
                    CoffeeShopUI.viewAmount();
                    clearScreen();
                }
            }
        }
        static int mainMenu ()
        {
            int op = 0;
            Console.WriteLine("1. Add a Menu item");
            Console.WriteLine("2. View the Cheapest Item in the menu");
            Console.WriteLine("3. View the Drink's Menu");
            Console.WriteLine("4. View the Food's Menu");
            Console.WriteLine("5. Add Order");
            Console.WriteLine("6. Fulfill Order");
            Console.WriteLine("7. View the Orders' List");
            Console.WriteLine("8. Total Payable Amount");
            Console.WriteLine("9. Exit");
            op = int.Parse(Console.ReadLine());
            return op;
        }
        static void clearScreen ()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
