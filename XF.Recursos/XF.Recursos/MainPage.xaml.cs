using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.Recursos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //code behind
        private async void btnSimples_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.SimplesPage());
        }

        private async void btnGlobal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.GeralView());
        }

        private async void btnDinamico_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.DinamicoView());
        }

        private async void btnTriggers_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Estilo.TriggersView());
        }

        private async void btnTemplate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Theme.ThemeView());
        }
    }
}
