using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeshaCoffeeShop.BL;
namespace TeshaCoffeeShop.UI
{
    class MenuItemUI
    {
        public static MenuItem takeInput ()
        {
            Console.WriteLine("Enter Item Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Item Type:");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Item Price:");
            int price = int.Parse(Console.ReadLine());
            MenuItem newItem = new MenuItem(name , type , price);
            return newItem;
        }

    }
}
