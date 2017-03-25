namespace Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Embraer190 : Aircraft
    {
        public Embraer190(string callSign, IAirTraficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }
}
