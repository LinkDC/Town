using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class CarPassenger:Car
    {
        public CarPassenger(string name, int places, int weight, int lenght) : base(name, places, weight, lenght)
        {

        }
        public CarPassenger() : base("Легковая", 5, 2300, 5)
        {

        }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
