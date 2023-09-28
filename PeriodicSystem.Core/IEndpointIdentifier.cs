namespace PeriodicSystem.Core;

public interface IEndpointIdentifier
{
    string SendLeds { get; }
    string Animate { get; }
    string StartClock { get; }
}