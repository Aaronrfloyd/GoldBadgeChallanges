using System;
using System.Collections.Generic;
using _01_Challange_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challange_Tests
{
    [TestClass]
    public class MenuRepository_Tests
    {

        [TestMethod]
        public void AddToListTest()
        {
            Menu item = new Menu();
            Menu_Repository menuRepo = new Menu_Repository();

            menuRepo.AddToList(item);

            List<Menu> menu = menuRepo.GetMenuList();

            int actual = menu.Count;

            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void RemoveMenu_Repository()
        {
            Menu item = new Menu();
            Menu_Repository menuRepo = new Menu_Repository();

            menuRepo.AddToList(item);
            List<Menu> menu = menuRepo.GetMenuList();

            menuRepo.RemoveMenuItemByName(item.MealName);
            int actual = menu.Count;

            Assert.AreEqual(0, actual);


        }

        [TestMethod]
        public void RemoveMenuItemByNumber_GiveValidMenuNumber_ShouldReturnCorrectCount()
        {
            Menu item = new Menu(1, "burger", "something", "stuff", 5.99m);
            Menu itemTwo = new Menu(12, "burgertwo", "something else", "stuff else", 10.99m);

            Menu_Repository menuRepo = new Menu_Repository();

            menuRepo.AddToList(item);
            menuRepo.AddToList(itemTwo);

            List<Menu> menus = menuRepo.GetMenuList();

            menuRepo.RemoveMenuItemByNumber(12);

            int actual = menus.Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
