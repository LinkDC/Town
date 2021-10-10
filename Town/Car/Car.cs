using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Car
    {
        public Car(string name, int places, int weight, int lenght)
        {
            Name = name;
            Places = places;
            Weight = weight;
            Lenght = lenght;

        }
        public Car()
        {
            Name = "Машина";
            Places = 5;
            Weight = 2000;
            Lenght = 4;

        }
        public string Name;
        public int Places;
        public int Weight;
        public int Lenght;
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name}: {Places} мест, {Weight} кг, {Lenght} метров");
        }
        public void Drive()
        {

        }
        public void Repair()
        {

        }
    }
}
