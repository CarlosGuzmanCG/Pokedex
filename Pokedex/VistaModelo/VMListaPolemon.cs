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
using System.Collections.ObjectModel;

namespace Pokedex.VistaModelo
{
    public class VMListaPolemon: VMBase
    {
        #region Variables

        ObservableCollection<MPokemon> _listaPokemon;

        #endregion

        #region Constructor
        public VMListaPolemon(INavigation navigation)
        {
            Navigation = navigation;
            MostrarPoke();
        }


        #endregion

        #region Objetos

        public ObservableCollection<MPokemon> ListaPokemon
        {
            get { return _listaPokemon; }
            set { SetValue(ref _listaPokemon,value);
                OnpropertyChanged();
            }
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

        public async Task IrADetallePoke(MPokemon parametros)
        {
            await Navigation.PushAsync(new DetallePokemon(parametros));
        }

        #endregion

        #region Comandos

        public ICommand IrRegistroCommand => new Command(async () => await IrRegistro());

        public ICommand DetallePokeCommand => new Command(async ()=> await IrADetallePoke()); 


        #endregion
    }
}
