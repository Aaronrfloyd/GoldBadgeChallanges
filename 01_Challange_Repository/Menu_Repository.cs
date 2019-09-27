using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challange_Repository
{
     public class Menu_Repository
     {
        List<Menu_Repository> _menu_Repositories = new List<Menu_Repository>();

        public void AddToList(Menu_Repository content)
        {
            _menu_Repositories.Add(content);
        }

        public List<Menu_Repository> GetMenu_Repositories()
        {
            return _menu_Repositories;
        }

        public void RemoveMenu_Repository(string mealNumber)
        {
            foreach(Menu_Repository item in _menu_Repositories)
            {
                if(item.MealNumber == mealNumber)
                {
                    _menu_Repositories.Remove(item);
                    break;
                }
            }
        }
         
        public void SeedList()
        {

        }

     }
}
