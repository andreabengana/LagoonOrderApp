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
	public partial class VendorLoginPage : ContentPage
	{
		public VendorLoginPage ()
		{
			InitializeComponent ();
		}

        private void VendorLoginButton_Clicked(object sender, EventArgs e)
        {
            if(vendorUsernameEntry.Text == "vendor" && vendorPasswordEntry.Text == "qwertyuiop")
            {
                Navigation.PushAsync(new VendorView());
            }
            else
            {
                DisplayAlert("Error", "Wrong Credentials", "OK");
            }
        }
    }
}