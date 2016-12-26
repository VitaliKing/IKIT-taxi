using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKIT_taxi
{

    public struct Taxi
    {
        public string Name;
        public int Seat;
        public double Rest;
        public double Rate;

        public Taxi(string Name, int Seat, double Rest, double Rate)
        {
            this.Name = Name;
            this.Seat = Seat;
            this.Rest = Rest;
            this.Rate = Rate;
        }

        public bool InspecOrder(double Distance, int Pass)
        {
            if (((Rate / 100 * Distance) < Rest) && (Seat >= Pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
