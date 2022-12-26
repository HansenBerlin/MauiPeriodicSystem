using MauiAppBlazorTest.Values;
using MudBlazor;

namespace MauiAppBlazorTest.Models;

public class ButtonModel
{
    public State State { get; set; }
    public string Color { get; init; }
    public string Label { get; init; }
    public Tags ActivatesTag { get; init; } = Tags.None;
    
    public Variant GetVariant()
    {
        return State == State.Active ? Variant.Filled : Variant.Outlined;
    }
}