using System;
using System.Collections.Generic;
using _04_Challange_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_ChallangeRepoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            OutingRepo outingRepo = new OutingRepo();
            Outing item = new Outing();

            outingRepo.AddtoList(item);

            List<Outing> list = outingRepo.ReturnOutingList();

            Assert.AreEqual(1, list.Count);

        }

        [TestMethod]
        public void costTestType()
        {
            OutingRepo outingRepo = new OutingRepo();
            outingRepo.SeedList();

            double actual = outingRepo.OutingCostByType(EventType.Golf);
            double expected = 814.5;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void eventTotal()
        {
            OutingRepo outingRepo = new OutingRepo();
            outingRepo.SeedList();

            double actual = outingRepo.CalcCombCosttotal();
            double expected = 1714.5d;

            Assert.AreEqual(expected, actual);



        }

    }
}
