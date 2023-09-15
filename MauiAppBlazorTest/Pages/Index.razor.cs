using MauiAppBlazorTest.Controller;
using MauiAppBlazorTest.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PeriodicSystem.Core;

namespace MauiAppBlazorTest.Pages;

public partial class Index
{
    [Inject] 
    private ISnackbar Snackbar { get; set; }
    
    [Inject] 
    private IEndpointIdentifier EndpointIdentifier { get; set; }
    
    private HubConnection _connection;
    private const string EndpointConnect = "http://192.168.10.60:5000/set";
    

    private void Callback()
    {
        Navigation.NavigateTo("/quiz");

    }

    bool _isDialogVisible;

    protected override async Task OnInitializedAsync()
    {
        await Connect();
    }

    private async Task UpdateButtons(Dictionary<int, string> states)
    {
        foreach (var btn in ButtonModels.AllButtons)
        {
            var isActive = states[btn.Pin] != "#000000";
            btn.State = isActive ? State.Active : State.Inactive;
        }
        await InvokeAsync(StateHasChanged);
    }

    private void OpenDialog()
    {
        _isDialogVisible = !_isDialogVisible;
    }

    private async Task DialogColorButtonClicked(ColorSwitcher colorSwitcher)
    {
        foreach (var btn in ButtonModels.PassiveButtons
            .Where(btn => btn.OwnTags.Contains(colorSwitcher.WithTag)))
        {
            btn.State = colorSwitcher.ToState;
        }
        ButtonActivationController.UpdateActivatorButtons();

        await PostUpdatedStates();
    }

    private async Task DialogAllButtonClicked(State toState)
    {
        foreach (var btn in ButtonModels.AllButtons)
        {
            btn.State = toState;
        }
        await PostUpdatedStates();
    }

    private async Task PostUpdatedStates()
    {
        var dict = new Dictionary<int, string>();
        foreach (var btn in ButtonModels.AllButtons)
        {
            if (btn.State == State.Active)
            {
                var color = btn.Color == "#212121" ? "#909090" : btn.Color;
                dict.Add(btn.Pin, color);
            }
            else if (btn.State == State.Inactive)
            {
                dict.Add(btn.Pin, "#000000");
            }
        }
        await SendMessage(dict);
    }

    private async Task SingleButtonClicked(ElementButtonModel model)
    {
        if (model.ActivatesTag != Values.Tags.None)
        {
            foreach (var btn in ButtonModels.PassiveButtons
                .Where(btn => btn.OwnTags.Contains(model.ActivatesTag)))
            {
                btn.State = model.State;
            }
        }
        ButtonActivationController.UpdateActivatorButtons();
        await PostUpdatedStates();
    }

    
    private async Task Connect()
    {
        try
        {
            _connection = new HubConnectionBuilder()
            .WithUrl(EndpointConnect)
            .Build();

            _connection.On<Dictionary<int, string>>("ActiveLedsReceived", UpdateButtons);
            
            await _connection.StartAsync();
            
        }
        catch (Exception)
        {
            Snackbar.Add("Connection could not be established", Severity.Error);
        }
        
    }

    private async Task SendMessage(Dictionary<int, string> states)
    {
        try
        {
            await _connection.InvokeAsync(EndpointIdentifier.SendLeds, states);
        }
        catch (Exception)
        {
            Snackbar.Add("Connection lost", Severity.Error);
        }
        
    }

    private async Task StartAnimation(bool isRandomized)
    {
        var dict = new Dictionary<int, string>();
        foreach (var btn in ButtonModels.AllButtons)
        {
            var color = btn.Color == "#212121" ? "#909090" : btn.Color;
            dict.Add(btn.Pin, color);
        }

        var request = new LedAnimationRequest
        {
            LedColors = dict,
            Randomize = isRandomized,
            Delay = 50
        };

        try
        {
            await _connection.InvokeAsync(EndpointIdentifier.Animate, request);
        }
        catch (Exception)
        {
            Snackbar.Add("Connection lost", Severity.Error);
        }
    }

    private async Task SetClock()
    {

        await SendSignal(EndpointIdentifier.StartClock);

    }

    private async Task SendSignal(string invokeMethodName)
    {
        try
        {
            await _connection.InvokeAsync(invokeMethodName);
        }
        catch (Exception)
        {
            Snackbar.Add("Connection lost", Severity.Error);
        }
        
    }


}
