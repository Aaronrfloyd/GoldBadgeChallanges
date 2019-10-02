using System;
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
            Outing item = new Outing( EventType.Golf, 13, new DateTime (1999,11,3), 16.50, 600);
            Outing item2 = new Outing(EventType.AmusmentPark, 12, new DateTime(2001, 34, 4), 25, 600);
        }

        public double CalcCombCost()
        {

        }
    }

}
