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
    public partial class EncuestasView : ContentPage
    {

        public EncuestasView()
        {
            InitializeComponent();
            this.BtnAgregar.Clicked += BtnAgregar_Clicked;
            MessagingCenter.Subscribe<ContentPage, Encuenta>(this, Mensajes.encuestaCompleta, (sender, args) =>
            {
                Panel.Children.Add(new Label()
                {
                    Text = args.ToString()
                });
            });

        }

        private async void BtnAgregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DetallesEncuestaView());
        }
    }
}