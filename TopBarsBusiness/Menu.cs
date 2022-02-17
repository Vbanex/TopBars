using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopBars.Business.dsTopBarsTableAdapters;

namespace TopBars.Business
{
   public class Menu
    {
        public List<MenuItem> items { get; set; }
        public string Name { get; set; }
        private int _menuId;
        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void SaveNewMenuItem(String Name, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Name;
            item.Description = Description;
            item.Price = Price;

            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter();
            taMenuItem.InsertNewMenuItem(item.Title, item.Description, item.Price, _menuId);
           // Console.WriteLine("New menu Item Added\n");
        }

        public static List<Menu> allMenus()
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter(); 
            foreach(dsTopBars.MenuRow menuRow in dtMenu.Rows)
            {
                Menu currentmenu = new Menu();
                currentmenu.Name = menuRow.Name;
                currentmenu._menuId = menuRow.Id;
                allMenus.Add(currentmenu);
                var dtMenuItem = taMenuItem.GetMenuItemByMenuId(menuRow.Id);
                foreach(dsTopBars.MenuItemRow menuItemRow in dtMenuItem.Rows)
                {
                    currentmenu.AddNewMenuItem(menuItemRow.Name, menuItemRow.Description, menuItemRow.Price);
                }
                
            }
            return allMenus;
        }

        public void AddNewMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            items.Add(item);
        }

    }
}
