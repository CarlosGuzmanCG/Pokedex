using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex.Vista;

namespace Pokedex
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegistroPokemon());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
