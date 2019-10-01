using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challange_Repository
{
    public class ClaimRepository
    {
        Queue<Claim> _claimsQueue = new Queue<Claim>();

        public Queue<Claim> SeeAllClaims()
        {
            return _claimsQueue;
        }
        //take care of next claim
        public Claim TakeCareOfTheNextClaim()
        {
            return _claimsQueue.Dequeue();
        }

        public void AddNewClaim(Claim item)
        {
            _claimsQueue.Enqueue(item);
           
        }

        public void SeedList()
        {
            Claim item = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00, new DateTime(2018, 4, 11), new DateTime(2018, 4, 18), true);
            Claim item1 = new Claim(2, ClaimType.Home, "House fire in Kitchen.", 4000.00, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), true);
            Claim item2 = new Claim(3, ClaimType.Theft, "Stolen pancakes", 4.00, new DateTime(2018, 4, 27), new DateTime(2018, 6, 01), false);
            _claimsQueue.Enqueue(item);
            _claimsQueue.Enqueue(item1);
            _claimsQueue.Enqueue(item2);

        }
    }
}
