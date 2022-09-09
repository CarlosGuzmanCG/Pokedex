using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pokedex.VistaModelo;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistroPokemon : ContentPage
    {
        public RegistroPokemon()
        {
            InitializeComponent();
            BindingContext = new VMRegistroPokemon(Navigation);
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}