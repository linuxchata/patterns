namespace Mediator
{
    /// <summary>
    /// The 'Mediator' interface
    /// </summary>
    public interface IAirTraficControl
    {
        void ReceiveAircraftLocation(Aircraft aircraft);

        void RegisterAircraftUnderGuidence(Aircraft aircraft);
    }
}
