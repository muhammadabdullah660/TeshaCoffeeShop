using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeshaCoffeeShop.BL
{
    class CoffeeShop
    {
        private string name;
        private List<MenuItem> menuItemsList = new List<MenuItem>();
        private List<string> ordersList = new List<string>();
        public CoffeeShop (string name)
        {
            this.name = name;
        }
        public string getName ()
        {
            return name;
        }
        public List<MenuItem> getmenuItemsList ()
        {
            return menuItemsList;
        }
        public List<String> getordersList ()
        {
            return ordersList;
        }
        public void addMenuItem (MenuItem newMenuItem)
        {
            menuItemsList.Add(newMenuItem);
        }
        public bool addOrder (string name)
        {
            foreach (MenuItem item in menuItemsList)
            {
                if (item.getName() == name)
                {
                    ordersList.Add(name);
                    return true;
                }
            }
            return false;
        }
        public string fulfillOrder ()
        {
            if (ordersList.Count != 0)
            {
                string name = ordersList[0];
                ordersList.RemoveAt(0);
                return $"{name} is Ready";
            }
            else
            {
                return "All orders have been fulfilled!";
            }
        }
        public List<string> listOrders ()
        {
            return ordersList;
        }
        public double dueAmount ()
        {
            double price = 0;
            foreach (string name in ordersList)
            {
                foreach (MenuItem item in menuItemsList)
                {
                    if (item.getName() == name)
                    {
                        int p = item.getPrice();
                        price += p;
                    }
                }
            }
            return price;
        }
        public string cheapestItem ()
        {
            MenuItem item = menuItemsList[0];
            for (int i = 1 ; i < menuItemsList.Count ; i++)
            {
                if (menuItemsList[i].getPrice() < item.getPrice())
                {
                    item = menuItemsList[i];
                }
            }
            string cheapest = item.getName();
            return cheapest;
        }
        public List<String> drinksOnly ()
        {
            List<MenuItem> drinksList = menuItemsList.Where(item => item.getType() == "drink").ToList();
            List<string> drinks = drinksList.Select(items => items.getName()).ToList();
            return drinks;
        }
        public List<String> foodOnly ()
        {
            List<MenuItem> foodList = menuItemsList.Where(item => item.getType() == "food").ToList();
            List<string> food = foodList.Select(items => items.getName()).ToList();
            return food;
        }
        public static void addSomeItems (CoffeeShop myCoffeeShop)
        {
            myCoffeeShop.addMenuItem(new MenuItem("orange juice" , "drink" , 60));
            myCoffeeShop.addMenuItem(new MenuItem("lemonade" , "drink" , 50));
            myCoffeeShop.addMenuItem(new MenuItem("cranberry juice" , "drink" , 100));
            myCoffeeShop.addMenuItem(new MenuItem("pineapple juice" , "drink" , 100));
            myCoffeeShop.addMenuItem(new MenuItem("lemon iced tea" , "drink" , 120));
            myCoffeeShop.addMenuItem(new MenuItem("vanilla chai latte" , "drink" , 150));
            myCoffeeShop.addMenuItem(new MenuItem("hot chocolate" , "drink" , 140));
            myCoffeeShop.addMenuItem(new MenuItem("iced coffee" , "drink" , 140));
            myCoffeeShop.addMenuItem(new MenuItem("tuna sandwich" , "food" , 300));
            myCoffeeShop.addMenuItem(new MenuItem("ham and cheese sandwich" , "food" , 300));
            myCoffeeShop.addMenuItem(new MenuItem("egg sandwich" , "food" , 200));
            myCoffeeShop.addMenuItem(new MenuItem("steak" , "food" , 900));
            myCoffeeShop.addMenuItem(new MenuItem("hamburger" , "food" , 600));
            myCoffeeShop.addMenuItem(new MenuItem("cinnamon roll" , "food" , 150));

        }
    }
}
