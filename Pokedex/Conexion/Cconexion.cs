using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Pokedex.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedex-48282-default-rtdb.firebaseio.com/");
    }
}
