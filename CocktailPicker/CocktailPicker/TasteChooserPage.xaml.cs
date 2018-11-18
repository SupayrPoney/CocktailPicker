using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CocktailPicker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TasteChooserPage : ContentPage
	{
		public TasteChooserPage (string alcohol_name)
		{
			InitializeComponent ();
		}
	}
}