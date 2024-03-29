﻿using System.Collections.Generic;
using MauiAppBlazorTest.Values;
using MudBlazor;

namespace MauiAppBlazorTest.Models;

public class ElementButtonModel : ButtonModel
{
    public int Pin { get; }
    public bool IsHalfHeight { get; init; }
    public bool IsHalfWidth { get; init; }
    public List<Tags> OwnTags { get; init; } = new();

    private const string BaseStyle = "font-size: 1.8vw; margin: 0.1vw; text-transform: none; padding: 0; ";

    public ElementButtonModel(State state = State.Dummy, string label = "", int pin = 0, string color = "")
    {
        Pin = pin - 1;
        Color = color == "" ? CustomColor.DarkGrey : color;
        Label = label;
        State = state;
    }

    public string Style()
    {
        string color = State == State.Active ?
            $"background-color: {Color}; color: {CustomColor.White}; border-color: {Color};" :
            $"background-color: transparent; color: {Color}; border-color: {Color};";
        string height = IsHalfHeight ? "height: 2.05vw;" : "height: 4.3vw;";
        string width = IsHalfWidth ? "width: 2.05vw; min-width: 2.05vw;" : "width: 4.3vw; min-width: 4.3vw;";

        return State != State.Dummy ? BaseStyle + color + width + height : BaseStyle + width + height;
    }
}