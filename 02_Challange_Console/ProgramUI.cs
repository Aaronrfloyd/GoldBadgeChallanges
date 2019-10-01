using _02_Challange_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challange_Console
{
    internal class ProgramUI
    {
        ClaimRepository _claimsQueue = new ClaimRepository();

        public void Run()
        {
            _claimsQueue.SeedList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Choose a menu item.\n" +
                    "1. See all claims.\n" +
                    "2. Take care of next claim.\n" +
                    "3. Enter a new claim.\n" +
                    "4. Exit");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        SeeAllOfTheClaims();
                        break;
                    case "2":
                        TakeCareOfTheNextClaim();
                        break;
                    case "3":
                        CreateANewClaim();
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                }
            }
        }

        public void SeeAllOfTheClaims()
        {
            Queue<Claim> claims = _claimsQueue.SeeAllClaims();
            Console.WriteLine("ClaimID\t" +
                "Type\t" +
                "Description\t" +
                "Amount\t" +
                "Date Of Accident\t" +
                "Date Of Incident\t" +
                "Is Valid\t");


            foreach (Claim item in claims)
            {
                Console.WriteLine(item.ClaimId + "\t" +
                   item.Type + "\t" +
                   item.Description + "\t" +
                   item.ClaimAmount + "\t" +
                   item.DateOfIncident + "\t" +
                   item.DateOfClaim + "\t" +
                   item.IsValid + "\t");
            }
            Console.ReadLine();
            Console.Clear();
            
        }

        private void CreateANewClaim()
        {
            Console.WriteLine("What is the claim Id?:  ");
            int claimId = int.Parse(Console.ReadLine());

            Console.WriteLine("What type of claim?;\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3.Theft\n");
            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);

            ClaimType claim = (ClaimType)typeAsInt;

            Console.WriteLine("What is the description?: ");
            string description = Console.ReadLine();

            Console.WriteLine("How much is the claim amount?: ");
            double claimAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("What was the date of the Incident?: ");
            DateTime dateOfIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What is the date of the Claim?: ");
            DateTime dateOfClaim = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Is this valid, True or False?: ");
            bool isValid = bool.Parse(Console.ReadLine());

            Claim item = new Claim(claimId, claim, description, claimAmount, dateOfIncident, dateOfClaim, isValid);
            Console.ReadLine();

            _claimsQueue.AddNewClaim(item);

            //RunMenu();


        }
        
        public void TakeCareOfTheNextClaim()
        {
            Queue<Claim> claimQueue = _claimsQueue.SeeAllClaims();
                Claim claim= claimQueue.Peek();
            Console.WriteLine($"{claim.ClaimId}\n" +
                $"{claim.Type}\n" +
                $"{claim.Description}\n" +
                $"{claim.ClaimAmount}\n" +
                $"{claim.DateOfIncident}\n" +
                $"{claim.DateOfClaim}\n" +
                $"{claim.IsValid}\n");

            Console.WriteLine("Do you want to deal with this claim now?(y/n):  ");
            string userInput = Console.ReadLine().ToLower();

            switch(userInput)
            {
                case "y":
                    _claimsQueue.TakeCareOfTheNextClaim();
                    break;
                case "n":
                    //RunMenu();
                    break;
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();

        }
       
    }
}
