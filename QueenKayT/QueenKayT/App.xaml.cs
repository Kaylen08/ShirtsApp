    using System;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    using System.IO;

    namespace QueenKayT
    {
        public partial class App : Application
        {
            public App()
            {
                InitializeComponent();
                MainPage = new NavigationPage(new MainPage());
            }

            private void InitializeComponent()
            {
            }

            static TDatabase database;
            public static TDatabase Database
            {
                get
                {
                    if (database == null)
                    {
                        database = new TDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "QueenKayT.db3"));
                    }
                    return database;
                }
            }
        }
    }


   