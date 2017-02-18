using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorcycle : Vehicle
    {
        public enum Bikestyles { Custom, Sports, Commuter }
        public Bikestyles BikeStyle { get; set; }
        public int EngineSize { get; set; }

        public Motorcycle(Bikestyles bikestyle, string make, string model, string colour, int enginesize, int weight, int topSpeed, string registration) : base(make, model, colour, weight, topSpeed, registration)

        {
            BikeStyle = bikestyle;
            base.NumWheels = 2;
            EngineSize = enginesize;
        }

    }

}