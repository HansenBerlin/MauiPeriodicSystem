using MauiAppBlazorTest.Models;
using MauiAppBlazorTest.Values;

namespace MauiAppBlazorTest.Interfaces;

public interface IButtonActivationController
{
    void UpdateActivatorButtons();
    State UpdatedButtonState(Tags buttonActivatesTag);
}