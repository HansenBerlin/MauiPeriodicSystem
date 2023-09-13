using MauiAppBlazorTest.Controller;
using MauiAppBlazorTest.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Mime;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MauiAppBlazorTest.Pages;

public partial class Index
{
    

    private void Callback()
    {
        Navigation.NavigateTo("/quiz");

    }

    const string EndpointMultiple = "http://192.168.10.60:5000/set";
    const string EndpointGetState = "http://192.168.10.60:5000/active";
    bool _isDialogVisible;
    private int _cachedValue = 0;

   

    private bool Changed(Dictionary<int, bool> serverValues)
    {
        int cachedValue = 0;
        foreach (var kv in serverValues)
        {
            cachedValue += kv.Key * Convert.ToInt32(kv.Value);
        }
        bool serverValuesHaveChanged = _cachedValue != cachedValue;
        _cachedValue = serverValuesHaveChanged ? cachedValue : _cachedValue;
        return serverValuesHaveChanged;
    }

    private async Task UpdateButtons()
    {
        var response = await HttpClient.GetAsync(EndpointGetState);
        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadFromJsonAsync<Dictionary<int, bool>>();
            if (Changed(content) == false)
            {
                return;
            }
            foreach (var btn in ButtonModels.AllButtons)
            {
                var isActive = content[btn.Pin];
                btn.State = isActive ? State.Active : State.Inactive;
            }
            StateHasChanged();
        }
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
        //StateHasChanged();

        await PostUpdatedStates();
    }

    private async Task DialogAllButtonClicked(State toState)
    {
        foreach (var btn in ButtonModels.AllButtons)
        {
            btn.State = toState;
        }
        //StateHasChanged();

        await PostUpdatedStates();
    }

    private async Task PostUpdatedStates()
    {
        //var dict = new Dictionary<int, string>();
        //var dict2 = new Dictionary<int, bool>();
        //foreach (var btn in ButtonModels.AllButtons)
        //{
        //    if (btn.State == State.Active)
        //    {
        //        var color = btn.Color == "#212121" ? "#909090" : btn.Color;
        //        dict.Add(btn.Pin, color);
        //        dict2.Add(btn.Pin, true);
        //    }
        //    else if (btn.State == State.Inactive)
        //    {
        //        dict.Add(btn.Pin, "#000000");
        //        dict2.Add(btn.Pin, false);
        //    }
        //}
        ////var json = new StringContent(
        ////    JsonSerializer.Serialize(dict),
        ////    Encoding.UTF8,
        ////    MediaTypeNames.Application.Json);
        ////await HttpClient.PostAsync(EndpointMultiple, json);
        //var message = new Message() { ActiveLeds = dict2 };
        //await SendMessage(message);
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

    private HubConnection _connection;
    private const string EndpointConnect = "http://127.0.0.1:5000/message";
    private async Task Connect()
    {
        try
        {
            _connection = new HubConnectionBuilder()
            .WithUrl(EndpointConnect)
            .Build();
            _connection.On<string>("MessageReceived", async message =>
            {
                Console.WriteLine($"Message received: {message}");
                await InvokeAsync(StateHasChanged);
            });
            
            await _connection.StartAsync();
            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
            Console.WriteLine(ex.Message.ToString());
            Console.WriteLine(ex.StackTrace.ToString());
        }
        
    }

    private async Task SendMessage()
    {
        await _connection.InvokeAsync("SendMessage", "Hello" + DateTime.Now);
        //Debug.Assert(_webSocket != null, nameof(_webSocket) + " != null");
        //if (_webSocket.State == WebSocketState.Open)
        //{     
        //    var messageJson = JsonSerializer.Serialize(message);
        //    var bytes = Encoding.UTF8.GetBytes(messageJson);
        //    //var message = $"Hello from {name} at {DateTime.Now}";
        //    //var bytes = Encoding.UTF8.GetBytes(message);
        //    await _webSocket.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None);
        //}
    }

    
}
