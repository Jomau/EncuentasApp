using System;
using System.Collections.Generic;
using System.Text;

namespace EncuentasApp
{
    public class Encuenta
    {
        #region Propiedades
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string EquipoFavorito { get; set; }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}";
        }
        #endregion

    }
}
