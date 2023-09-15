namespace PeriodicSystem.Core;

public class EndpointIdentifier : IEndpointIdentifier
{
    public string SendLeds => nameof(IEndpoints.SendActiveLeds);
    public string Animate => nameof(IEndpoints.RunAnimation);
    public string StartClock => nameof(IEndpoints.StartClock);
}