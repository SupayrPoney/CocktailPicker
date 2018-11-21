using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CocktailPicker
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            var license = File.ReadAllText("License.txt");
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(license);

            MainPage = new NavigationPage(new MainPage())
            {
                BackgroundColor = new Color(27, 73, 94),
                BarBackgroundColor = Color.FromHex("#1B495E"),

            };
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
