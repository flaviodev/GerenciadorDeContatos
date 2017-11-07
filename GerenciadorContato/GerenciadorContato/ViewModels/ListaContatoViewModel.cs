using GerenciadorContato.Models;
using GerenciadorContato.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GerenciadorContato.ViewModels
{
    class ListaContatoViewModel : ViewModelBase
    {

        public List<Contato> ListarContatos()
        {
            using (var dados = new ContatoRepository())
            {
                return dados.Listar();
            }
        }

        public ICommand IncluirCommand
        {
            get;
            set;
        }

        public ICommand SobreCommand
        {
            get;
            set;
        }

        private readonly Services.IMensagemService _mensagemService;
        private readonly Services.INavegacaoService _navegacaoService;

        public ListaContatoViewModel()
        {
            this.IncluirCommand = new Command(this.Incluir);
            this.SobreCommand = new Command(this.Sobre);

            this._mensagemService = DependencyService.Get<Services.IMensagemService>();
            this._navegacaoService = DependencyService.Get<Services.INavegacaoService>();
        }

        public async void Selecionar(Contato contato)
        {
            await this._navegacaoService.NavegaParaConsultaContato(contato);
        }

        private async void Incluir()
        {
            await this._navegacaoService.NavegaParaMantemContato(new Contato(), true);
        }

        private async void Sobre()
        {
            await this._mensagemService.MostraMensagemAsync("Sobre ...");
        }
    }
}
