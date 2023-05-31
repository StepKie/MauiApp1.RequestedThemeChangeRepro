namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		RequestedThemeChanged += (s, a) => ConfigureTheme(a.RequestedTheme);
		InitializeComponent();
		MainPage = new AppShell();
	}

	private void ConfigureTheme(AppTheme requestedTheme)
	{
		// Breakpoint set on this line will only be hit exactly ONCE (the first time the system theme changes)
		UserAppTheme = requestedTheme;
	}
}
