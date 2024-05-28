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
        private readonly HashSet<Aircraft> _aircraftUnderGuidence;

        public YyyControl()
        {
            _aircraftUnderGuidence = new HashSet<Aircraft>();
        }

        public void ReceiveAircraftLocation(Aircraft aircraft)
        {
            foreach (var currentAircraft in _aircraftUnderGuidence.Where(a => !a.Equals(aircraft)))
            {
                if (Math.Abs(currentAircraft.Altitude - aircraft.Altitude) < 500)
                {
                    aircraft.Climb(1000);
                }
            }
        }

        public void RegisterAircraftUnderGuidence(Aircraft aircraft)
        {
            if (!_aircraftUnderGuidence.Contains(aircraft))
            {
                _aircraftUnderGuidence.Add(aircraft);
                Console.WriteLine(aircraft.GetType().Name + " " + aircraft.CallSign + " is under control.");
            }
        }
    }
}
