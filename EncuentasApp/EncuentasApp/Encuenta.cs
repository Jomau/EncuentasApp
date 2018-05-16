using System;
using System.Collections.Generic;
using System.Text;

namespace EncuentasApp
{
    public class Encuenta
    {
        #region Atributo
        public string equipoFavorito;
        #endregion
        #region Propiedades
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public string EquipoFavorito {
            get { return equipoFavorito; }
            set {
                equipoFavorito = value;
                switch (equipoFavorito) {
                    case "Colombia":
                        Color = "Yellow";
                        break;
                    case "Peru":
                        Color = "Red";
                        break;
                    case "Brasil":
                        Color = "Green";
                        break;
                    case "Rusia":
                        Color = "Brown";
                        break;
                    case "Alemania":
                        Color = "Pink";
                        break;
                    case "Argentina":
                        Color = "Blue";
                        break;
                    default:
                        Color = "Purple";
                        break;
                }
            }
        }

        public string Color { get; set; }
        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"{Nombre}|{FechaNacimiento}|{EquipoFavorito}|{Color}";
        }
        #endregion

    }
}
