using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TeshaCoffeeShop.BL;
namespace TeshaCoffeeShop.DL
{
    class CoffeeShopDL
    {
        public static void storeIntoFile (string path , CoffeeShop C)
        {
            StreamWriter f = new StreamWriter(path , false);
            string orderListName = "";
            for (int i = 0 ; i < C.getordersList().Count ; i++)
            {
                if (i != C.getordersList().Count - 1)
                {
                    orderListName += C.getordersList()[i] + ";";
                }
                else
                {
                    orderListName += C.getordersList()[i];
                }
            }
            f.WriteLine(C.getName() + "," + orderListName);
            f.Flush();
            f.Close();
        }
        public static bool loadFromFile (string path , CoffeeShop C)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string name = splittedRecord[0];
                    string[] splittedRecordSub = splittedRecord[1].Split(';');
                    C.setName(name);
                    for (int i = 0 ; i < splittedRecordSub.Length ; i++)
                    {
                        MenuItem M = C.isMenuItemExist(splittedRecordSub[i]);
                        if (M != null)
                        {
                            C.addOrder(M.getName());
                        }
                    }
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
