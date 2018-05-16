using System;
using System.Collections.Generic;
using System.Text;

namespace EncuentasApp
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    public  class Notificable : INotifyPropertyChanged
    {
        #region Interfaz
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
