using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LagoonOrderApp.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using LagoonOrderApp.Services;

namespace LagoonOrderApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VendorAddProd : ContentPage
	{
        public ObservableCollection<string> Items { get; set; }
        private const string Url = "http://192.168.0.105:45455/api/Products";
        public VendorAddProd ()
		{
			InitializeComponent ();
		}

        private void Submit_Clicked(object sender, EventArgs e)
        {
            Product model = new Product();

            HttpService http = new HttpService();

            model.ProductName = enProdName.Text;
            model.Price = Int32.Parse(enProdPrice.Text);
            model.PreparationTime = DateTime.Parse(enPrepTime.Time.ToString());
            model.ProductDescription = enProdDesc.Text;
            model.ProductType = enProdType.Text;
            

            var result = http.HttpPostRequest("http://192.168.8.100:45455/api/Products", model);
        }
    }
}