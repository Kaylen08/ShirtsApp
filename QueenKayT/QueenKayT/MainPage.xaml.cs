using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace QueenKayT
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var orderItem = new TInfo();
            BindingContext = orderItem;
        }


        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var orderItem = BindingContext as TInfo;
            var shirtDb = App.Database;
            shirtDb.InsertTShirtOrder(orderItem);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage());
        }
        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TShirtList());
        }
    }
}
