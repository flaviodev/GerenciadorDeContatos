using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GerenciadorContato
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ViewModels.Services.IMensagemService, Views.Services.MensagemService>();
            DependencyService.Register<ViewModels.Services.INavegacaoService, Views.Services.NavegacaoService>();

            MainPage = new NavigationPage(new Views.ListaContatoView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
