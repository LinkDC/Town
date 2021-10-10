using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class TrafficLightCar:TrafficLight
    {
        public TrafficLightCar(string name, int lights, int greenTime, int yellowTime, int redTime) : base(name, lights, greenTime)
        {
            YellowTime = yellowTime;
            RedTime = redTime;
        }
        public TrafficLightCar() : base("Дорожный светофор", 3, 90)
        {
            YellowTime = 10;
            RedTime = 30;
        }
        public int YellowTime;
        public int RedTime;
        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
