namespace Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign, IAirTraficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }
}
