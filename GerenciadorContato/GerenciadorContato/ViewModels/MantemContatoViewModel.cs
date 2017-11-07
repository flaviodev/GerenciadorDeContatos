using GerenciadorContato.Models;
using GerenciadorContato.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GerenciadorContato.ViewModels
{
    class MantemContatoViewModel
    {

        public void Incluir(Contato contato)
        {
            using (var dados = new ContatoRepository())
            {
                dados.Insert(contato);
                _navegacaoService.NavegaParaAnterior();
            }
        }

        public void Alterar(Contato contato)
        {
            using (var dados = new ContatoRepository())
            {
                dados.Update(contato);
                _navegacaoService.NavegaParaConsultaContato(contato);
            }
        }

        private readonly Services.IMensagemService _mensagemService;
        private readonly Services.INavegacaoService _navegacaoService;

        public MantemContatoViewModel()
        {
            this._mensagemService = DependencyService.Get<Services.IMensagemService>();
            this._navegacaoService = DependencyService.Get<Services.INavegacaoService>();
        }
    }
}
