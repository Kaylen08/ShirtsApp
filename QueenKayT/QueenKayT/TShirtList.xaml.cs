using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace QueenKayT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TShirtList : ContentPage
    {
        public List<TInfo> ShirtList { get; set; }
        public TShirtList()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            ShirtList = await App.Database.GetItemsAsync();
            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as TInfo;

            DisplayAlert("Item selected", item.Name, "add");
        }

    
        }
    }





