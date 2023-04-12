namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		var w = base.CreateWindow(activationState);
		w.Width = 640;
		w.Height = 480;
		return w;
	}
}
