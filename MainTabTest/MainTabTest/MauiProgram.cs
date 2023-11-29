using MainTabTest.ViewModels;
using Microsoft.Extensions.Logging;
using Prism;
using Prism.Ioc;

namespace MainTabTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UsePrism(prism =>
			{
				prism.ConfigureServices(container =>
				{
					container.RegisterForNavigation<MainTabPage, MainTabPageViewModel>();
					container.RegisterForNavigation<InnerTabA, InnerTabAViewModel>();
					container.RegisterForNavigation<InnerTabB, InnerTabBViewModel>();
					container.RegisterForNavigation<InnerTabC, InnerTabCViewModel>();
					container.RegisterForNavigation<InnerTabD, InnerTabDViewModel>();
					container.RegisterForNavigation<InnerTabE, InnerTabEViewModel>();
				})
				.RegisterTypes(containerRegistry =>
				{
                })
				.OnAppStart("MainTabPage");
			})
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

