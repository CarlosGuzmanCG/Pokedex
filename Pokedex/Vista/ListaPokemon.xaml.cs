using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex.Vista
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPokemon : ContentPage
    {
        public ListaPokemon()
        {
            InitializeComponent();
            BindingContext = new VMListaPolemon(Navigation);
        }
    }
}