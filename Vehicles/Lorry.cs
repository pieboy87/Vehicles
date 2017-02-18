using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Lorry : Vehicle
    {
        public bool TailLift { get; set; }
        public bool TailLiftState { get;  set; }
        public int SpeedRestriction { get; set; }
        public int LoadWeight { get; set; }
        
        public Lorry(string make, string model, string colour, int weight, int loadweight, int topSpeed, bool tailLift, int numwheels, int speedrestriction, string registration) : base (make, model, colour, weight, topSpeed, registration)
        {
            base.NumWheels = numwheels;
            SpeedRestriction = speedrestriction;
            TailLift = tailLift;

            LoadWeight = loadweight;
        }


        public void RaiseLift()
        {
            // Make sure have a lift, lift is down, and 0 speed before we raise it)
            if (TailLift == true && TailLiftState == true && CurrentSpeed == 0)
            {
                //Raise the lift
                TailLiftState = false;
            }
        }

        public void LowerLift()
        {
            // Make sure have a lift, lift is up, and 0 speed before we lower it)
            if (TailLift == true && TailLiftState == false && CurrentSpeed == 0)
            {
                //lower the lift
                TailLiftState = true;
            }


        }
    }
}