using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.Recursos.Estilo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    //mutex c# ==> declara a classe no volatile quando nao quero q o c#
    public partial class DinamicoView : ContentPage
    {
        //propriedade para identificar o estilo
        bool temaPadrao;

        public DinamicoView()
        {
            InitializeComponent();

            temaPadrao = true;
            Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];


        }

        private void OnClick_AlterarEstilo(object sender, EventArgs args)
        {
            if (temaPadrao)
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoVermelho"];
                temaPadrao = false;
            }
            else
            {
                Resources["TextoEstiloDinamico"] = Resources["TextoAzul"];
                temaPadrao = true;
            }
        }

        private bool desligarRelogio = false;

        protected override void OnAppearing()
        {
            desligarRelogio = false;

            //a cada um segundo, busca a hora do dispositivo para atualizar a hora
            //start timer, estarta uma nova thread pelo recurso de Dispatcher
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                Resources["Hora"] = DateTime.Now.ToString();
                return !desligarRelogio;
            });
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            desligarRelogio = true;
            base.OnDisappearing();
        }
    }
}