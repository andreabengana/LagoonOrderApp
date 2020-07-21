using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LagoonOrderApp.Services;
using LagoonOrderApp.Models;

namespace LagoonOrderApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrdersView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        private const string Url = "http://192.168.8.108:45455/api/Order_Detail";

        public OrdersView()
        {
            InitializeComponent();

            OnGetList();
			MyListView.ItemsSource = Items;
        }
        protected async void OnGetList()
        {
            try
            {
                HttpService service = new HttpService();
                JsonConvertService convert = new JsonConvertService();

                var content = await service.HttpGetRequest(Url);

                var tr = convert.ConvertToModel<List<Order_Detail>>(content);

                ObservableCollection<Order_Detail> trends = new ObservableCollection<Order_Detail>(tr);

                MyListView.ItemsSource = trends;

            }
            catch (Exception ey)
            {
                Debug.WriteLine("" + ey);
            }
        }
        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
