﻿using System;
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
    public partial class StoresView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        private const string Url = "http://192.168.8.100:45455/api/Stores";

        public StoresView()
        {
            InitializeComponent();

            //Items = new ObservableCollection<string>
            //{
            //    "Item 1",
            //    "Item 2",
            //    "Item 3",
            //    "Item 4",
            //    "Item 5"
            //};
            OnGetList();
			MyListView.ItemsSource = Items;
        }
        protected async void OnGetList()
        {
            try
            {
                HttpService service = new HttpService();
                JsonConvertService convert = new JsonConvertService();

                var content = await service.HttpGetRequest("http://192.168.8.100:45455/api/Stores");

                var tr = convert.ConvertToModel<List<Store>>(content);

                ObservableCollection<Store> trends = new ObservableCollection<Store>(tr);

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
