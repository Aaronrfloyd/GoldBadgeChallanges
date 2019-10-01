using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challange_Repository
{

    public enum ClaimType { Car = 1, Home, Theft }
    public class Claim
    {
        public Claim(int claimId, ClaimType type, string description, double claimAmount, DateTime dateOfIncident, DateTime dateofClaim, bool isValid)
        {
            ClaimId = claimId;
            Type = type;
            Description = description;
            ClaimAmount = claimAmount;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateofClaim;
            IsValid = isValid;
        }
        public Claim()
        {

        }
        public int ClaimId { get; set; }
        public ClaimType Type { get; set; }
        public string Description { get; set; }
        public double ClaimAmount { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }

    }
}
