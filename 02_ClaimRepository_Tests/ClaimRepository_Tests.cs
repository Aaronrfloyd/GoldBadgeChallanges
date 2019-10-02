using System;
using System.Collections.Generic;
using _02_Challange_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_ClaimRepository_Tests
{
    [TestClass]
    public class ClaimRepository_Tests
    {

        Claim item = new Claim();
        ClaimRepository claimRepo = new ClaimRepository();
      
        [TestMethod]
        public void AddToQueueTest()
        {
            //Arrange

            Claim item = new Claim(1, ClaimType.Car, "Car accident on 465", 400.00, new DateTime(2018, 4, 11), new DateTime(2018, 4, 18), true);
            Claim item1 = new Claim(2, ClaimType.Home, "House fire in Kitchen.", 4000.00, new DateTime(2018, 4, 25), new DateTime(2018, 4, 27), true);
            Claim item2 = new Claim(3, ClaimType.Theft, "Stolen pancakes", 4.00, new DateTime(2018, 4, 27), new DateTime(2018, 6, 01), false);

            //Act
             Queue<Claim> _claimsQueue= claimRepo.SeeAllClaims();
            _claimsQueue.Enqueue(item);
            _claimsQueue.Enqueue(item1);
            _claimsQueue.Enqueue(item2);

            //Assert
            int actual = _claimsQueue.Count;
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }
    }
}
