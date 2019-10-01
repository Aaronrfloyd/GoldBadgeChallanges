using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challange_Repository
{
    public class Claim_Repository
    {
        List<Claim> _claimsList = new List<Claim>();

        public void AddtoList(Claim claim)
        {
            _claimsList.Add(claim);
        }

        public List<Claim> GetClaims()
        {
            return _claimsList;
        }

        public void RemoveClaimsList(int ClaimId)
        {

        }
    }
}
