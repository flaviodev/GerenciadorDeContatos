using GerenciadorContato.Models;
using GerenciadorContato.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GerenciadorContato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MantemContatoView : ContentPage
    {
        private Contato _contato;
        private bool _inlcluir;

        private MantemContatoViewModel _mantemViewModel;

        public MantemContatoView(object contato, bool incluir)
        {
            InitializeComponent();
            _mantemViewModel = new ViewModels.MantemContatoViewModel();
            this.BindingContext = _mantemViewModel;

            _contato = (Contato)contato;
            _inlcluir = incluir;

            PopulaCampos(_contato);

            if (_inlcluir)
            {
                this.Title = "Novo Contato";
            }
            else
            {
                this.Title = "Alterar Contato";
            }
        }

        private void PopulaCampos(Contato contato)
        {
            this.Nome.Text = contato.Nome;
            this.Email.Text = contato.Email;
            this.Telefone.Text = contato.Email;
            this.Rua.Text = contato.Rua;
            this.Numero.Text = contato.Numero.ToString();
            this.Complemento.Text = contato.Complemento;
            this.Bairro.Text = contato.Bairro;
            this.Cidade.Text = contato.Cidade;
            this.Estado.Text = contato.Estado;
            this.Cep.Text = contato.Cep;
        }

        public void SalvarClicked()
        {
            _contato.Nome = this.Nome.Text;
            _contato.Email = this.Email.Text;
            _contato.Telefone = this.Telefone.Text;

            _contato.Rua = this.Rua.Text;
            _contato.Numero = int.Parse(this.Numero.Text);
            _contato.Complemento = this.Complemento.Text;
            _contato.Bairro = this.Bairro.Text;
            _contato.Cidade = this.Cidade.Text;
            _contato.Estado = this.Estado.Text;
            _contato.Cep = this.Cep.Text;

            if (_inlcluir)
            {
                _mantemViewModel.Incluir(_contato);
            }
            else
            {
                _mantemViewModel.Alterar(_contato);
            }
        }
    }
}