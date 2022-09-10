using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Modelo;
using Pokedex.Conexion;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace Pokedex.Datos
{
    public class DPokemon
    {
        public async Task InsertarPokemon(MPokemon parametros)
        {
            await Cconexion.firebase.Child("Pokemon").PostAsync(new MPokemon()
            {
                ColorFondo = parametros.ColorFondo,
                Icono = parametros.Icono,
                Nombre = parametros.Nombre,
                Nroorden = parametros.Nroorden,
                Poder = parametros.Poder,
                ColorPoder = parametros.ColorPoder
            });

        }

        // 
        //public async Task<List<MPokemon>> MostrarPokemones()
        //{
        //    return (await Cconexion.firebase.Child("Pokemon")
        //        .OnceAsync<MPokemon>())
        //        .Select(item => new MPokemon
        //        {
        //            IdPOkemon = item.Key,
        //            Nombre = item.Object.Nombre,
        //            ColorFondo = item.Object.ColorFondo,
        //            ColorPoder = item.Object.ColorPoder,
        //            Nroorden = item.Object.Nroorden,
        //            Poder = item.Object.Poder,
        //            Icono = item.Object.Icono
        //        }
        //        ).ToList();
        //}

        public async Task<ObservableCollection<MPokemon>> MostrarPokemones()
        {
            var data = await Task.Run(()=> Cconexion.firebase
                .Child("Pokemon")
                .AsObservable<MPokemon>()
                .AsObservableCollection());

            return data;
        }

    }
}
