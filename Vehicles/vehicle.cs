using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }
        public int NumWheels { get; set; }
        public int TopSpeed { get;  set; }
        public int CurrentSpeed { get; set; }
        public string Registration { get; set; }
        public int SteeringPos { get; set;}

        private bool SideLight { get; set; }
        private bool FullBeam { get; set; }
        private bool LeftIndicator { get; set; }
        private bool RightIndicator { get; set; }
        public bool BrakeLight { get; set; }
        public bool ReverseLight { get; set; }


        public Vehicle(string make, string model, string colour, int weight, int topSpeed, string registration)
        {
            Make = make;
            Model = model;
            Colour = colour;
            Weight = weight;
            TopSpeed = topSpeed;
            Registration = registration;

        }

        public void Accelerate(int speedIncrease)
        {
            if (CurrentSpeed < TopSpeed)
            {
                CurrentSpeed = CurrentSpeed + speedIncrease;
                if (CurrentSpeed > TopSpeed) { CurrentSpeed = TopSpeed; }
            }
            else
            {
                CurrentSpeed = TopSpeed;
            }
        }
    
        public void Brake(int speedDecrease)
        {
            //Break Light on
            BrakeLight = true;
            //Are we moving forwards?
            if (CurrentSpeed > 0)
            {
                //slow down
                CurrentSpeed = CurrentSpeed - speedDecrease;
                //Dont slow into negative speed
                if (CurrentSpeed < 0)
                { CurrentSpeed = 0; }
            }
            //Are we moving backwards? (negative speed)
            else if (CurrentSpeed < 0)
            {
                //slow down
                CurrentSpeed = CurrentSpeed + speedDecrease;
               if (CurrentSpeed > 0)
                { CurrentSpeed = 0; }
            }
            //If we're not moving, we wont change speed.
            //Break Light off
            BrakeLight = false;
            //Reverse Light off
            ReverseLight = false;
        }
        public void Reverse(int reverseSpeed)
        {
            //Only start reversing if current speed is 0
            if (CurrentSpeed == 0)
            {
                //Reverse Light on (turned off when we break)
                ReverseLight = true;
                //Reverse
                CurrentSpeed = CurrentSpeed - reverseSpeed;
            }
        }

        public void Steer(int steerpos)
        {
            //set steering position (degrees)
            SteeringPos = steerpos;
        }

        public void HazardLight(bool hazardSwitch)
        {
            if (hazardSwitch == true)
            {
                LeftIndicator = true;
                RightIndicator = true;
            }
            else
            {
                LeftIndicator = false;
                RightIndicator = false;
            }
        }
        public void LightControl(int lightcontrol)
        {
            if (lightcontrol == 0)
            {
                //off
                SideLight = false;
                FullBeam = false;
            }
            else if (lightcontrol == 1)
            {
                //Side
                SideLight = true;
                FullBeam = false;
            }
            else if (lightcontrol == 2)
            {
                //full
                SideLight = true;
                FullBeam = true;
            }

        }


        public void IndicatorPosition(int indicate)
        {
            if (indicate == 0)
            {
                //off
                LeftIndicator = false;
                RightIndicator = false;
            }
            else if (indicate == 1)
            {
                //left
                LeftIndicator = true;
                RightIndicator = false;
            }
            else if (indicate == 2)
            {
                //right
                LeftIndicator = false;
                RightIndicator = true;
            }

        }

    }



}