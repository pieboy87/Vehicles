using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a car
            Car Focus1 = new Car(Car.styles.HatchBack, "Ford", "Focus", "Blue", 1850, 120, "WG14 BXG");

            // Create a Lorry
            Lorry Lorry1 = new Lorry("Volvo", "FH16", "Mystic Fjord",57000,12000, 56, true, 10, 55, "CWT 064");

            // Create a Motorcycle
            Motorcycle Suzuki1 = new Motorcycle(Motorcycle.Bikestyles.Commuter, "Suzuki", "GSF600", "Green", 600, 140, 110, "P28 WTX");

            //Work the Car
            //Lights on
            Focus1.LightControl(2);
            //Indicate left
            Focus1.IndicatorPosition(1);
            //Steer left
            Focus1.Steer(-15);
            // Pull away
            Focus1.Accelerate(10);
            //Straighten up
            Focus1.Steer(0);
            //Stop indicating
            Focus1.IndicatorPosition(0);
            //Speed up 
            Focus1.Accelerate(50);

            //Work the Lorry
            //Lower the tail lift
            Lorry1.LowerLift();
            //Hazard Lights on
            Lorry1.HazardLight(true);
            //Raise the tail
            Lorry1.RaiseLift();
                       
           
        }
    }
}
