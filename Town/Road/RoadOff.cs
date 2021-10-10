using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class RoadOff:Road
    {
        public RoadOff(string name, int distance, int corners, int pit) : base(name, distance, corners)
        {
            Pit = pit;
        }
        public RoadOff() : base("Внедорожье", 150, 53)
        {
            Pit = 1000;
        }
        public int Pit;
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($", {Pit} ям");
        }
    }
}
