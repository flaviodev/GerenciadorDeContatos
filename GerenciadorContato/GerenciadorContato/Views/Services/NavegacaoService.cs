using GerenciadorContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContato.Views.Services
{
    class NavegacaoService : ViewModels.Services.INavegacaoService
    {

        public async Task NavegaParaAnterior()
        {
            await GerenciadorContato.App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavegaParaRaiz()
        {
            await GerenciadorContato.App.Current.MainPage.Navigation.PopToRootAsync();
        }

        public async Task NavegaParaListaContato()
        {
            await GerenciadorContato.App.Current.MainPage.Navigation.PushAsync(new Views.ListaContatoView());
        }

        public async Task NavegaParaConsultaContato(Contato contato)
        {
            await GerenciadorContato.App.Current.MainPage.Navigation.PushAsync(new Views.ConsultaContatoView(contato));
        }

        public async Task NavegaParaMantemContato(Contato contato, bool incluir)
        {
            await GerenciadorContato.App.Current.MainPage.Navigation.PushAsync(new Views.MantemContatoView(contato, incluir));
        }
    }
}
