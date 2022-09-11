using Pokedex.Modelo;
using Pokedex.Vista;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pokedex.VistaModelo
{
    public class VMDetallePokemon:VMBase
    {
        #region Variables
        
        public MPokemon parametrosReci { get; set; }
        #endregion

        #region Constructor
        public VMDetallePokemon(INavigation navigation, MPokemon parametrosObtenidos)
        {
            Navigation = navigation;
            parametrosReci = parametrosObtenidos;
        }
        #endregion
    }
}
