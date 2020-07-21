using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LagoonOrderApp.Views;

namespace LagoonOrderApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Food_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FoodsView());
        }


        private void Orders_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrdersView());
        }

        private void Stores_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StoresView());
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }
}
