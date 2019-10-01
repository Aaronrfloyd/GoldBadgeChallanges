using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challange_Repository
{
     public class Menu_Repository
     {
        List<Menu> _menuList = new List<Menu>();

        public Menu_Repository()
        {
        }

        public void AddToList(Menu content)
        {
            _menuList.Add(content);
        }

        public List<Menu> GetMenuList()
        {
            return _menuList;
        }

        public void RemoveMenuItemByName(string mealName)
        {
            foreach(Menu item in _menuList)
            {
                if(item.MealName == mealName)
                {
                    _menuList.Remove(item);
                    break;
                }
            }
        }

        public void RemoveMenuItemByNumber(int mealNumber)
        {
            foreach(Menu item in _menuList)
            {
                if(item.MealNumber == mealNumber)
                {
                    _menuList.Remove(item);
                    break;
                }
            }
        }
         
        public void SeedList()
        {
            Menu item = new Menu(1, "Burger", "Delicious Burger", "Lettuce, tomato, onion", 4.99m);
            Menu item2 = new Menu(2, "Hot Dog", "Chicago Dog", "Relish, peppers, mustard", 3.99m);
            Menu item3 = new Menu(3, "Nachos", "Loaded Nachos", "Beans, cheese, Jalapeno", 5.99m);

            AddToList(item);
            AddToList(item2);
            AddToList(item3);
        } 
     }
}
