using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challange_Repository
{ 
    public class Menu
    {
        public Menu(int mealNumber, string mealName, string mealDescription, List<string> ingredients, decimal price)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            Price = price;
        }

        public Menu()
        {

        }

        public int MealNumber { get; set; }

        public string MealName { get; set; }

        public string MealDescription { get; set; }

        public List<string> Ingredients { get; set; }

        public decimal Price { get; set; }
        
    }
}
