namespace MauiAppBlazorTest.Models;

public interface IButtonGrid
{
    ElementButtonModel[][] Grid { get; }
    List<ElementButtonModel> ActivatorButtons { get; }
    List<ElementButtonModel> PassiveButtons { get; }
    List<ElementButtonModel> AllButtons { get; }
}