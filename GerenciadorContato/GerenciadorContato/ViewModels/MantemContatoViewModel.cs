using GerenciadorContato.Models;
using GerenciadorContato.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GerenciadorContato.ViewModels
{
    class MantemContatoViewModel
    {

        public Endereco endereco { get; set; }

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
/*
        public Endereco ConsultaCep(string cep)
        {
            HttpClient _Client = new HttpClient();
            var content = _Client.GetStringAsync("http://api.postmon.com.br/v1/cep/"+cep);
            Endereco _endereco = JsonConvert.DeserializeObject<Endereco>(content);

            return _endereco;
        }
        */

        private readonly Services.IMensagemService _mensagemService;
        private readonly Services.INavegacaoService _navegacaoService;
        private readonly Services.IRestService _restService;

        public MantemContatoViewModel()
        {
            this._mensagemService = DependencyService.Get<Services.IMensagemService>();
            this._navegacaoService = DependencyService.Get<Services.INavegacaoService>();
            this._restService = DependencyService.Get<Services.IRestService>();
        }
    }
}
