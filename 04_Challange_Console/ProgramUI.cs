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

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Choose a menu item.\n" +
                "1. Display a list of all outings.\n" +
                "2. Add outing to a list.\n" +
                "3. Total cost for combined outings.\n" +
                "4. Total cost for types of outings. \n" +
                "5.  Exit.");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        displayOutings();
                        break;
                    case "2":
                        AddList();
                        break;
                    case "3":
                        totalCostCombine();
                        break;
                    case "4":
                        totalCostForType();
                        break;
                    case "5":
                        continueToRun = false;
                        break;


                }
            }
        }
        public void displayOutings()
        {
            List<Outing> outingList = _OutingRepo.ReturnOutingList();
            foreach (Outing outing in outingList)
            {
                Console.WriteLine($"{outing.Type}\n" +
                    $"{outing.Date}\n" +
                    $"Number of Attendees: {outing.Attendees}\n" +
                    $"Cost for Event:$ {outing.CostE}\n" +
                    $"Cost per Person:$ {outing.CostPP}\n" +
                    $"Total cost:$ {outing.CalcComboCost}");
            }
            Console.ReadKey();
        }
        public void AddList()
        {
            Console.WriteLine("What type of event?;\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement\n" +
                "4. Concert\n");
            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);

            EventType type = (EventType)typeAsInt;

            Console.WriteLine("What date?: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("How many people?: ");
            int attendees = int.Parse(Console.ReadLine());
                
            Console.WriteLine("what is the event cost?: ");
            double costE = double.Parse(Console.ReadLine());
                
            Console.WriteLine("Cost per person?: ");
            double costPP = double.Parse(Console.ReadLine());

            Outing item = new Outing(type, attendees, date, costE, costPP);

            Console.ReadLine();

            _OutingRepo.AddtoList(item);
        }

        public void totalCostCombine()
        {
            double finalCost = _OutingRepo.CalcCombCosttotal();
            Console.WriteLine($"Total cost of all outing {finalCost}\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
         
        public void totalCostForType()
        {
            Console.WriteLine("What outing type would you like to see total cost:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert\n");

            EventType eventType = (EventType)int.Parse(Console.ReadLine()) - 1;
            double typeCost = _OutingRepo.OutingCostByType(eventType);
            Console.WriteLine($"Total cost of all types of outings {typeCost}\n");
            Console.ReadKey();
        }

    }

}
