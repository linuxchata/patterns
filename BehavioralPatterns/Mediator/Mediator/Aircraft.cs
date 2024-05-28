using System;

namespace Mediator
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Aircraft
    {
        private readonly IAirTraficControl _airTraficControl;

        private int _altitude;

        protected Aircraft(string callSign, IAirTraficControl airTraficControl)
        {
            _airTraficControl = airTraficControl;
            CallSign = callSign;

            _airTraficControl.RegisterAircraftUnderGuidence(this);
        }

        public string CallSign { get; private set; }

        public int Altitude
        {
            get
            {
                return _altitude;
            }
            set
            {
                _altitude = value;

                Console.WriteLine(GetType().Name + " " + CallSign + " is on " + _altitude + " altitude.");

                _airTraficControl.ReceiveAircraftLocation(this);
            }
        }

        public abstract int Ceiling { get; }

        public void Climb(int climb)
        {
            Altitude += climb;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Aircraft;
            if (other == null)
            {
                return false;
            }

            return string.Equals(CallSign, other.CallSign, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return CallSign.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " is on " + _altitude + " altitude.";
        }
    }
}
