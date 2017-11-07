using GerenciadorContato.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorContato.ViewModels.Services
{
    interface INavegacaoService
    {
        Task NavegaParaAnterior();
        Task NavegaParaRaiz();
        Task NavegaParaListaContato();
        Task NavegaParaConsultaContato(Contato contato);
        Task NavegaParaMantemContato(Contato contato, bool incluir);
    }
}
