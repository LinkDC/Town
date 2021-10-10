using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class RoadWater:Road
    {
        public RoadWater(string name, int distance, int corners, double water) : base(name, distance, corners)
        {
            Water = water;
        }
        public RoadWater() : base("Болото", 25, 2)
        {
            Water = 0.5;
        }
        public double Water;
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($", {Water} метра воды");
        }
    }
}
