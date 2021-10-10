using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Road
    {
        public Road(string name, int distance, int corners)
        {
            Name = name;
            Distance = distance;
            Corners = corners;
        }
        public Road()
        {
            Name = "Дорога";
            Distance = 1000;
            Corners = 5;
        }
        public int Distance;
        public int Corners;
        public string Name;
        public virtual void PrintInfo()
        {
            Console.Write($"{Name}: {Distance} км, {Corners} поворотов");
        }
        public void Repair()
        {

        }
    }
}
