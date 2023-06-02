using Microsoft.Extensions.Logging;

namespace ScientMeetApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Poppins-Black.ttf", "poppBlack");
                fonts.AddFont("Poppins-Medium.ttf", "poppMed");
                fonts.AddFont("Poppins-Regular.ttf", "poppReg");
                fonts.AddFont("Poppins-SemiBold.ttf", "poppSemiBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
