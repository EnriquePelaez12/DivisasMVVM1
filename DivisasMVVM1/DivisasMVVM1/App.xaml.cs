using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DivisasMVVM1.Page;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace DivisasMVVM1
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPageView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
