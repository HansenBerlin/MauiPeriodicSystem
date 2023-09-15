namespace PeriodicSystem.Core;

public class LedAnimationRequest
{
    public Dictionary<int, string> LedColors { get; set; } = new();
    public int Delay { get; set; } = 100;
    public bool Randomize { get; set; } = false;
}