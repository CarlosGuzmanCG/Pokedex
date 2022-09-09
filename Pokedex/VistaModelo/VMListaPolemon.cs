using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Pokedex.Vista;
using Pokedex.VistaModelo;
using Xamarin.Forms;

namespace Pokedex.VistaModelo
{
    public class VMListaPolemon: VMBase
    {
        #region Variables



        #endregion

        #region Constructor
        public VMListaPolemon(INavigation navigation)
        {
            Navigation = navigation;
        }


        #endregion

        #region Objetos



        #endregion

        #region Procesos
        public async Task IrRegistro()
        {
            await Navigation.PushAsync(new RegistroPokemon());
        }


        #endregion

        #region Comandos

        public ICommand IrRegistroCommand => new Command(async () => await IrRegistro());


        #endregion
    }
}
