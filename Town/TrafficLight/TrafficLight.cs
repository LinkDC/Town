using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class TrafficLight
    {
        public TrafficLight(string name, int lights, int greenTime)
        {
            Name = name;
            Lights = lights;
            GreenTime = greenTime;
        }
        public TrafficLight()
        {
            Name = "Светофор";
            Lights = 3;
            GreenTime = 25;
        }
        public string Name;
        public int Lights;
        public int GreenTime;
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Lights} лампочки");
        }
        public virtual void Light()
        {

        }
        public virtual void Repair()
        { 
        }
    }
}
