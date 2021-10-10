using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class RoadAsphalt:Road
    {
        public RoadAsphalt(string name, int distance, int corners) : base(name, distance, corners)
        {

        }
        public RoadAsphalt() : base("Асфальт", 1000, 5)
        {

        }
        public override void PrintInfo()
        {
            base.PrintInfo();

        }
    }
}
