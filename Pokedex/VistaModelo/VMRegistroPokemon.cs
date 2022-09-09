using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex.Modelo;
using Pokedex.Datos;

namespace Pokedex.VistaModelo
{
    public class VMRegistroPokemon : VMBase
    {
        #region Variables

        string _txtColorFondo, _colorHtml, _txtColorPoder, _txtNombre,_dt, _txtNro, _txtPoder, _txtIcono;
        #endregion

        #region Constructores

        public VMRegistroPokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region Objetos
        public string TxtColorFondo
        {

            get { return _txtColorFondo; }
            set { SetValue(ref _txtColorFondo, value); }
        }
        public string TxtColorPoder
        {
            get { return _txtColorPoder; }
            set { SetValue(ref _txtColorPoder, value); }
        }

        public string TxtNombre
        {
            get { return _txtNombre; }
            set { SetValue(ref _txtNombre, value); }
        }
        public string TxtNro
        {
            get { return _txtNro; }
            set { SetValue(ref _txtNro, value); }
        }
        public string TxtPoder
        {
            get { return _txtPoder; }
            set { SetValue(ref _txtPoder, value); }
        }
        public string TxtIcono
        {
            get { return _txtIcono; }
            set { SetValue(ref _txtIcono, value); }
        }

        #endregion

        #region Procesos

        public async Task Volvel()
        {
            await Navigation.PopAsync();
        }

        public async Task Insertar()
        {
            var funcion = new DPokemon();
            var parametro = new MPokemon();

            parametro.ColorFondo = TxtColorFondo;
            parametro.ColorPoder = TxtColorPoder;
            parametro.Icono = TxtIcono;
            parametro.Nombre = TxtNombre;
            parametro.Nroorden = TxtNro;
            parametro.Poder = TxtPoder;

                await funcion.InsertarPokemon(parametro);
                
                await Volvel();
            
        }

        #endregion

        #region Comandos

        public ICommand volverCommand => new Command(async () => await Volvel());

        public ICommand InsertarCommand => new Command(async () => await Insertar());

        #endregion
    }
}
