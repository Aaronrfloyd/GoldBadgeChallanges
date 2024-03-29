﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challange_Repository
{
    public class OutingRepo
    {
        List<Outing> outingList = new List<Outing>();

        public List<Outing> ReturnOutingList()
        {
            return outingList;
        }
        public void AddtoList(Outing item)
        {
            outingList.Add(item);
        }

        public void SeedList()
        {
            Outing item = new Outing(EventType.Golf, 13, new DateTime(1999, 11, 3), 16.50, 600);
            Outing item2 = new Outing(EventType.AmusmentPark, 12, new DateTime(2001, 12, 4), 25, 600);

            AddtoList(item);
            AddtoList(item2);
        }

        public double CalcCombCosttotal()
        {
            double cost = 0;
            foreach (Outing outing in outingList)
            {
                cost = cost + outing.CalcComboCost;
            }
            return cost;
        }

        public double OutingCostByType(EventType type)
        {
            double cost = 0;
            foreach (Outing outing in outingList)
            {
                if (outing.Type == type)
                {
                    cost = cost + outing.CalcComboCost;
                }
            }
            return cost;

        }
    }
}
