using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CocktailPicker
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void OnAlcoholChosen(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string alcohol_name = button.Text;

            var alcoholChosenPage = new TasteChooserPage(alcohol_name);
            await Navigation.PushAsync(alcoholChosenPage);

        }
    }
}
