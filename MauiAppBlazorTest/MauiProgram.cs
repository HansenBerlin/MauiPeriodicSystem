using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using MauiAppBlazorTest.Interfaces;

namespace MauiAppBlazorTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
		builder.Services.AddMauiBlazorWebView();
		builder.Services.AddMudServices();
        builder.Services.AddSingleton<HttpClient>();



#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif


		return builder.Build();
	}
}
