using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffeeShop.BL;
using TeshaCoffeeShop.UI;
using TeshaCoffeeShop.DL;
namespace TeshaCoffeeShop
{
    class Program
    {
        static void Main ()
        {
            CoffeeShopUI.loadItemsFromFile();
            CoffeeShopUI.loadShopFromFile();
            int op = 0;
            while (op < 9)
            {
                op = MainMenuUI.mainMenu();
                MainMenuUI.clearScreen();
                if (op == 1)
                {
                    CoffeeShopUI.addMenuItem();
                    MainMenuUI.clearScreen();
                }
                else if (op == 2)
                {
                    CoffeeShopUI.viewCheapest();
                    MainMenuUI.clearScreen();
                }
                else if (op == 3)
                {
                    CoffeeShopUI.viewDrinksMenu();
                    MainMenuUI.clearScreen();
                }
                else if (op == 4)
                {
                    CoffeeShopUI.viewFoodMenu();
                    MainMenuUI.clearScreen();
                }
                else if (op == 5)
                {
                    CoffeeShopUI.placeOrder();
                    MainMenuUI.clearScreen();
                }
                else if (op == 6)
                {
                    CoffeeShopUI.orderFulfill();
                    MainMenuUI.clearScreen();
                }
                else if (op == 7)
                {
                    CoffeeShopUI.viewOrders();
                    MainMenuUI.clearScreen();
                }
                else if (op == 8)
                {
                    CoffeeShopUI.viewAmount();
                    MainMenuUI.clearScreen();
                }
            }
            CoffeeShopUI.storeShopIntoFile();
        }

    }
}
