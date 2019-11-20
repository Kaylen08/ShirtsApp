using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace QueenKayT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        public List<TInfo> ShirtList { get; set; }
        public OrderPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ShirtList = await App.Database.GetItemsAsync();
            BindingContext = this;
        }
    }
}