using System;

namespace Mediator
{
    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Aircraft
    {
        private readonly IAirTraficControl atc;

        private int altitude;

        protected Aircraft(string callSign, IAirTraficControl atc)
        {
            this.atc = atc;
            this.CallSign = callSign;

            this.atc.RegisterAircraftUnderGuidence(this);
        }

        public string CallSign { get; private set; }

        public int Altitude
        {
            get
            {
                return this.altitude;
            }
            set
            {
                this.altitude = value;

                Console.WriteLine(this.GetType().Name + " " + this.CallSign + " is on " + this.altitude + " altitude.");

                atc.ReceiveAircraftLocation(this);
            }
        }

        public abstract int Ceiling { get; }

        public void Climb(int climb)
        {
            this.Altitude += climb;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Aircraft;
            if (other == null)
            {
                return false;
            }

            return string.Equals(this.CallSign, other.CallSign, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return this.CallSign.GetHashCode();
        }
    }
}
