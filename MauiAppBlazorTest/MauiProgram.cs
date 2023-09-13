using System.Net.Http;
using MauiAppBlazorTest.Controller;
using MauiAppBlazorTest.Interfaces;
using MauiAppBlazorTest.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using MudBlazor.Services;

namespace MauiAppBlazorTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
        builder.Services.AddScoped<IButtonGrid, ButtonGrid>();
        builder.Services.AddScoped<IButtonActivationController, ButtonActivationController>();
		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddMudServices();
        builder.Services.AddSingleton<HttpClient>();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		//builder.Logging.AddDebug();
#endif
		
		return builder.Build();
	}
}
