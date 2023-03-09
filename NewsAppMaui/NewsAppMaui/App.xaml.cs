using NewsAppMaui.Pages;

namespace NewsAppMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new NewsPage());
	}
}
