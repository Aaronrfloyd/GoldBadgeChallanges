using _04_Challange_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challange_Console
{
    internal class ProgramUI
    {
        OutingRepo _OutingRepo = new OutingRepo();

        public void Run()
        {
            _OutingRepo.SeedList();
                RunMenu();
        }

        public void RunMenu()
        {
            Console.WriteLine("Choose a menu item.\n" +
                "1. Display a list of all outings.\n" +
                "2. Add outing to a list.\n" +
                "3. Total cost for combined outings.\n" +
                "4. Total cost for types of outings. \n" +
                "5.  Exit.")
        }
    }
}
