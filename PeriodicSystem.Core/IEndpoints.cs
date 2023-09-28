namespace PeriodicSystem.Core;

public interface IEndpoints
{
    Task SendActiveLeds(Dictionary<int, string> activeLeds);
    Task RunAnimation(LedAnimationRequest animationRequest);
    Task StartClock();
}