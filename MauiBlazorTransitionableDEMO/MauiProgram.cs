using Microsoft.AspNetCore.Components.WebView.Maui;


namespace MauiBlazorTransitionableDEMO;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.Services.AddScoped<BlazorTransitionableRoute.IRouteTransitionInvoker,
			BlazorTransitionableRoute.DefaultRouteTransitionInvoker>();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
	

		return builder.Build();
	}
}
