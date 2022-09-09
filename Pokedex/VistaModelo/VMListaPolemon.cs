using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pokedex.Vista;
using Pokedex.VistaModelo;
using Pokedex.Datos;
using Xamarin.Forms;
using Pokedex.Modelo;

namespace Pokedex.VistaModelo
{
    public class VMListaPolemon: VMBase
    {
        #region Variables

        List<MPokemon> _listaPokemon;

        #endregion

        #region Constructor
        public VMListaPolemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPoke();
        }


        #endregion

        #region Objetos

        public List<MPokemon> ListaPokemon
        {
            get { return _listaPokemon; }
            set { SetValue(ref _listaPokemon,value); }
        }

        #endregion

        #region Procesos
        public async Task IrRegistro()
        {
            await Navigation.PushAsync(new RegistroPokemon());
        }

        public async Task MostrarPoke()
        {
            var funcion = new DPokemon();
            ListaPokemon = await funcion.MostrarPokemones();
        }

        #endregion

        #region Comandos

        public ICommand IrRegistroCommand => new Command(async () => await IrRegistro());


        #endregion
    }
}
