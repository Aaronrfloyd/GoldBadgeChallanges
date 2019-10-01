using _01_Challange_Repository;
using System;
using System.Collections.Generic;

namespace _01_Challange_Console
{
    internal class ProgramUI
    {
        Menu_Repository _menu_Repository = new Menu_Repository();

        public void Run()
        {
            _menu_Repository.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;

            while (continueToRun)
            {
                Console.WriteLine("Enter the number you would like to see\n" +
                    "1. Add Item\n" +
                    "2. Delete Item\n" +
                    "3. See Item\n" +
                    "4. Exit\n" +
                    "5. Delete item by Number.");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddNewItem();
                        break;
                    case "2":
                        RemoveItemByName();
                        break;
                    case "3":
                        SeeAllItems();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    case "5":
                        RemoveItemByNumber();
                        break;
                }
            }
        }

        public void RemoveItemByNumber()
        {
            SeeAllItems();

            Console.WriteLine("What item would you like to remove? Please enter a number.");
            int mealNumber = int.Parse(Console.ReadLine());

            _menu_Repository.RemoveMenuItemByNumber(mealNumber);

            SeeAllItems();
        }

        public void RemoveItemByName()
        {
            SeeAllItems();

            Console.WriteLine("What item would you like to remove? Please enter a name.");
            string mealName = Console.ReadLine();

            _menu_Repository.RemoveMenuItemByName(mealName);

            SeeAllItems();
        }

        public void SeeAllItems()
        {
            List<Menu> menu = _menu_Repository.GetMenuList();

            foreach (Menu item in menu)
            {
                Console.WriteLine($"{item.MealNumber}, Meal Name: {item.MealName}\n" +
                    $" Meal Description: {item.MealDescription}\n" +
                    $" Ingredeients: {item.Ingredients}\n" +
                    $" Price: {item.Price}\n");
            }
            Console.WriteLine("Please press any key to continue...");
            Console.ReadKey();
        }
        private void AddNewItem()
        {
            Console.WriteLine("Enter the number of the meal:  ");
            int MealNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of the meal:  ");
            string MealName = Console.ReadLine();

            Console.WriteLine("Enter a description:  ");
            string MealDescription = Console.ReadLine();

            Console.WriteLine("Enter ingredients: ");
            string Ingredients = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            decimal Price = decimal.Parse(Console.ReadLine());

            Menu item = new Menu(MealNumber, MealName, MealDescription, Ingredients, Price);

            _menu_Repository.AddToList(item);

        }
    }
}
