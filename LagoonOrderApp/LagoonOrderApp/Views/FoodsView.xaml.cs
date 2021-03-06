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
    public partial class FoodsView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        private const string Url = "http://192.168.8.100:45455/api/Products";
        public FoodsView()
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

                var content = await service.HttpGetRequest(Url);

                var tr = convert.ConvertToModel<List<Product>>(content);

                ObservableCollection<Product> trends = new ObservableCollection<Product>(tr);

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

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            var dataItem = e.Item as Product; 

            await Navigation.PushAsync(new FoodViewDetail(dataItem.ProductImage, dataItem.ProductDescription, (DateTime)dataItem.PreparationTime, dataItem.ProductName, (int)dataItem.Price, dataItem.ID_Product));

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}

