using System;
using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    public sealed class YyyControl : IAirTraficControl
    {
        private readonly HashSet<Aircraft> aircraftUnderGuidence;

        public YyyControl()
        {
            this.aircraftUnderGuidence = new HashSet<Aircraft>();
        }

        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            foreach (var currentAircraft in this.aircraftUnderGuidence.Where(a => !a.Equals(aircraft)))
            {
                if (Math.Abs(currentAircraft.Altitude - aircraft.Altitude) < 500)
                {
                    aircraft.Climb(1000);
                }
            }
        }

        public void RegisterAircraftUnderGuidence(Aircraft aircraft)
        {
            if (!this.aircraftUnderGuidence.Contains(aircraft))
            {
                this.aircraftUnderGuidence.Add(aircraft);
                Console.WriteLine(aircraft.GetType().Name + " " + aircraft.CallSign + " is under control.");
            }
        }
    }
}
