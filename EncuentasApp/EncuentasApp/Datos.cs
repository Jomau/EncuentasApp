using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace EncuentasApp
{
    public class Datos : Notificable
    {
        #region Atributos
        private ObservableCollection<Encuenta> encuentas;
        #endregion
        public Datos()
        {
            Encuentas = new ObservableCollection<Encuenta>();
        }

        public ObservableCollection<Encuenta> Encuentas
        {
            get { return encuentas; }
            set
            {
                encuentas = value;
                OnPropertyChanged();
            }
        }
    }
}
