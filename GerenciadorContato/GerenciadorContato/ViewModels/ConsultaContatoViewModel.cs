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
    class ConsultaContatoViewModel
    {
        private readonly Services.IMensagemService _mensagemService;
        private readonly Services.INavegacaoService _navegacaoService;

        public ConsultaContatoViewModel()
        {
            this._mensagemService = DependencyService.Get<Services.IMensagemService>();
            this._navegacaoService = DependencyService.Get<Services.INavegacaoService>();
        }

        public async void Alterar(Contato contato)
        {
            await this._navegacaoService.NavegaParaMantemContato(contato, false);
        }

        public async void Excluir(Contato contato)
        {
            using (var dados = new ContatoRepository())
            {
                dados.Delete(contato);
                await _navegacaoService.NavegaParaAnterior();
            }
        }

        public Contato ObterContato(int id)
        {
            using (var dados = new ContatoRepository())
            {
                return dados.ObterPeloId(id);
            }
        }

    }
}
