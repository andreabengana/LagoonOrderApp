using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LagoonOrderApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VendorView : ContentPage
	{
		public VendorView ()
		{
			InitializeComponent ();
		}

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }

        private void Products_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VendorViewDetail());
        }

        private void Orders_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdersView());
        }
    }
}