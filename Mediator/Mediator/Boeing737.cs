namespace Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    public class Boeing737 : Aircraft
    {
        public Boeing737(string callSign, IAirTraficControl atc)
            : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 35000; }
        }
    }
}
