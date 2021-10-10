using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class CarJeep:Car
    {
        public CarJeep(string name, int places, int weight, int lenght) : base(name, places, weight, lenght)
        {

        }
        public CarJeep() : base("Внедорожник", 7, 4000, 6)
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();

        }

        public void Mountain_Drive()
        {

        }
    }
}
