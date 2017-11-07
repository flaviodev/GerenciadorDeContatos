using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContato.Views.Services
{
    class MensagemService : ViewModels.Services.IMensagemService
    {
        public async Task MostraMensagemAsync(string mensagem)
        {
            await GerenciadorContato.App.Current.MainPage.DisplayAlert("Mensagem", mensagem, "ok");
        }
    }
}
