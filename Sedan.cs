using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrences_Simmons_Landon
{
    class Sedan : IAutomobile
    {
        public double Speed { get; private set;}

        public int Wheels { get; private set;}

        public string LicensePlate { get; private set;}

        public Sedan(double speed) 
        {
            Wheels = 4;
            Speed = speed;
            LicensePlate = "GCTC-007";
        }
        public void Stringify()
        {
            Console.WriteLine($"The Sedan is traveling at speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
        }

        public void IncreaseSpeed() 
        {
            Speed += 5;        
        }

        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
