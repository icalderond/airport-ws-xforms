using airports_country.Model;
using Xamarin.Forms;

namespace airports_country
{
    public partial class App : Application
    {
        public static ServiceAeropuerto servicio;
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new airports_countryPage());
            MainPage = new NavigationPage(new airports_countryPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}