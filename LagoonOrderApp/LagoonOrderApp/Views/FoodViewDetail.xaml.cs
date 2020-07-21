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
	public partial class FoodViewDetail : ContentPage
	{

        public ObservableCollection<string> Items { get; set; }
        private const string Url = "http://192.168.8.100:45455/api/Products";
        int IDProd = 0;
        public FoodViewDetail(string image, string desc, DateTime prepTime, string Name, int Price, int id)
		{
			InitializeComponent();


            Description.Text = desc;
            lblProdName.Text = Name;
            lblPrice.Text = Price.ToString();
            lblDateTime.Text = prepTime.Minute.ToString();

            lblPrice2.Text = Price.ToString();
            IDProd = id;

        }
        
        private void PlaceOrder_Clicked(object sender, EventArgs e)
        {

            HttpService http = new HttpService();

            Order_Detail model = new Order_Detail();

            model.ID_Order = IDProd;
            model.ID_StoreProduct = IDProd;
            model.PickupTime = DateTime.Parse(enTimePickup.Time.ToString());
            model.Quantity = Int32.Parse(enQty.Text);
            model.CashAmount = Int32.Parse(enCashOnHand.Text);
            model.TotalAmount = Int32.Parse(lblPrice.Text) * Int32.Parse(enQty.Text);
            model.Status = "hello";

            var result2 = http.HttpPostRequest("http://192.168.8.100:45455/api/Order_Detail", model);

            Vendor_Order_Detail model2 = new Vendor_Order_Detail();

            model.ID_Order = IDProd;
            model.ID_StoreProduct = IDProd;
            model.PickupTime = DateTime.Parse(enTimePickup.Time.ToString());
            model.Quantity = Int32.Parse(enQty.Text);
            model.CashAmount = Int32.Parse(enCashOnHand.Text);
            model.TotalAmount = Int32.Parse(lblPrice.Text) * Int32.Parse(enQty.Text);
            model.Status = "hello";

            var result = http.HttpPostRequest("http://192.168.8.100:45455/api/Vendor_Order_Detail", model);
        }
    }
}