using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
   public class Car : Vehicle
    {
        public enum styles { HatchBack, Estate, Sports, Convertable, Saloon }
        public styles Style { get; set; }

        public Car(styles style, string make, string model, string colour, int weight, int topSpeed, string registration) : base (make, model, colour, weight, topSpeed, registration)
        {
            Style = style;
            base.NumWheels = 4;

        }

    }
}