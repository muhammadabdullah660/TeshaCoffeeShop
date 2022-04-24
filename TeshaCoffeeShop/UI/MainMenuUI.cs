using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeshaCoffeeShop.UI
{
    class MainMenuUI
    {
        public static int mainMenu ()
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
        public static void clearScreen ()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
