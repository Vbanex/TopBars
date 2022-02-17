using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopBars.Business;

namespace TopBars.WPFClient
{
   public class TopBarsViewModel
    {
        public List<Menu> AllMenus
        {
            get
            {
                return Menu.allMenus();
            }
        }

        private Menu _selectedMenu = new Menu();
        public Menu SelectedMenu
        {
            get
            {
                return _selectedMenu;
            }
            set
            {
                _selectedMenu = value;
            }
        }

        private MenuItem _newMenuItem = new MenuItem();
        public MenuItem NewMenuItem
        {
            get
            {
                return _newMenuItem;
            }

            set
            {
                _newMenuItem = value;
            }
        }

        private List<MenuItem> _newMenuItems = new List<MenuItem>();
        public List<MenuItem> NewMenuItems
        {
            get
            {
                return _newMenuItems;
            }
            set
            {
                _newMenuItems = value;
            }
        }
    }
}
