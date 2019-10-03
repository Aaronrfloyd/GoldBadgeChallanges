using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challange_Repository
{
    public enum EventType { Golf, Bowling, AmusmentPark, Concert }
    public class Outing
    {
        public Outing(EventType type, int attendees, DateTime date, double costPP, double costE)
        {
            Type = type;
            Attendees = attendees;
            Date = date;
            CostPP = costPP;
            CostE = costE;
            CalcComboCost = costPP * attendees + costE;
        }


        public Outing()
        {

        }

        public EventType Type { get; set; }
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public double CostPP { get; set; }
        public double CostE { get; set; }
        public double CalcComboCost { get; set; }
        
    }
}
