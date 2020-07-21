using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LagoonOrderApp.Views;
namespace LagoonOrderApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage ()
		{
			InitializeComponent ();
		}

        private void StudentButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void VendorButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VendorLoginPage());
        }
    }
}