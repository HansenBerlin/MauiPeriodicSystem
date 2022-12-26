using MauiAppBlazorTest.Interfaces;
using MauiAppBlazorTest.Models;
using MauiAppBlazorTest.Values;

namespace MauiAppBlazorTest.Controller;

public class ButtonActivationController : IButtonActivationController
{
    private readonly IButtonGrid _buttonGrid;

    public ButtonActivationController(IButtonGrid buttonGrid)
    {
        _buttonGrid = buttonGrid;
    }

    public void UpdateActivatorButtons()
    {
        foreach (var btn in _buttonGrid.ActivatorButtons)
        {
            btn.State = UpdatedButtonState(btn.ActivatesTag);
        }
    }

    public State UpdatedButtonState(Tags buttonActivatesTag)
    {
        int activeElements = 0;
        int totalElements = 0;
        foreach (var btn in _buttonGrid.PassiveButtons)
        {
            if (btn.OwnTags.Contains(buttonActivatesTag) || buttonActivatesTag == Tags.All)
            {
                activeElements = btn.State == State.Active ? activeElements + 1 : activeElements;
                totalElements++;
            }
        }
        return activeElements == totalElements ? State.Active : State.Inactive;
    }
}