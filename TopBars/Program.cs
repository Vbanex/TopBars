using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopBars.Business;

namespace TopBars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Menu> dbMenu = Menu.allMenus();
            Menu firstMenu = dbMenu[1];
            try
            {
                firstMenu.SaveNewMenuItem("Sprite", "so chilled", 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
          
            dbMenu = Menu.allMenus();

            Order customerOrder = new Order();

            foreach(Menu currentMenu in dbMenu)
            {
                foreach (MenuItem currentOrder in currentMenu.items)
                {
                    customerOrder.items.Add(currentOrder);
                }
            }
          
            Console.WriteLine($"The total is {customerOrder.Total}");
            

           
            Console.ReadKey();
        }
    }
}
