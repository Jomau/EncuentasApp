using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EncuentasApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallesEncuestaView : ContentPage
    {
        private readonly string[] equipos = { "Colombia", "Perú", "Brasil", "Rusia", "Argentina" };
        public DetallesEncuestaView()
        {
            InitializeComponent();
            this.BtmAgregarEq.Clicked += BtmAgregarEq_Clicked;
            this.BtnAceptar.Clicked += BtnAceptar_Clicked;

        }

        private async void BtnAceptar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.EntNombre.Text) || string.IsNullOrEmpty(this.LbEquipoFav.Text))
            {
                await DisplayAlert("Datos incompletos", "Debe ingresar todos los campos", "Aceptar", null);
                return;
            }
            var encuesta = new Encuenta()
            {
                Nombre = this.EntNombre.Text,
                FechaNacimiento = this.DtNac.Date,
                EquipoFavorito = this.LbEquipoFav.Text
            };
            MessagingCenter.Send((ContentPage)this, Mensajes.encuestaCompleta, encuesta);
            await Navigation.PopAsync();
        }

        private async void BtmAgregarEq_Clicked(object sender, EventArgs e)
        {
            var equipoFavorito = await DisplayActionSheet(Literales.tituloEqFav, null, null, equipos);
            if (!string.IsNullOrEmpty(equipoFavorito))
            {
                this.LbEquipoFav.Text = equipoFavorito;
            }
        }
    }
}