using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Town
{
    class Town
    {
        public string Name { get; set; }
        public List<Road> Road { get; set; }
        public List<Car> Car { get; set; }
        public List<TrafficLight> Trafficlight { get; set; }
        public Town(string name, List<Road> road, List<Car> car, List<TrafficLight> trafficlight)
        {
            Name = name;
            Road = road;
            Car = car;
            Trafficlight = trafficlight;
        }
        public Town()
        {
            Name = "";
            Road = new List<Road>();
            Car = new List<Car>();
            Trafficlight = new List<TrafficLight>();
        }

        public void AddTrafficLight()
        {
            Trafficlight.Add(new TrafficLightCar());
        }
        public void AddTrafficLightPassenger()
        {
            Trafficlight.Add(new TrafficLightPassenger());
        }
        public void AddRoadAsphalt()
        {
            Road.Add(new RoadAsphalt());
        }
        public void AddRoadOff()
        {
            Road.Add(new RoadOff());
        }
        public void AddRoadWater()
        {
            Road.Add(new RoadWater());
        }
        public void AddCarPassenger()
        {
            Car.Add(new CarPassenger());
        }
        public void AddCarJeep()
        {
            Car.Add(new CarJeep());
        }
    }
}
