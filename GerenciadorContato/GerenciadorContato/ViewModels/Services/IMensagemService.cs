using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContato.ViewModels.Services
{
    interface IMensagemService
    {
        Task MostraMensagemAsync(string mensagem);
    }
}
