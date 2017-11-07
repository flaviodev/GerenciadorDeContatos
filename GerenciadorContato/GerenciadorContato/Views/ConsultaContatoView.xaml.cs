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
    public partial class ConsultaContatoView : ContentPage
    {
        private ConsultaContatoViewModel _consultaViewModel;
        private Contato _contato;

        public ConsultaContatoView(object contato)
        {
            InitializeComponent();
            _consultaViewModel = new ViewModels.ConsultaContatoViewModel();
            this.BindingContext = _consultaViewModel;

            _contato = (Contato)contato;
            PopulaCampos(_contato);
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

        private void EditarClicked(object sender, EventArgs e)
        {
            _consultaViewModel.Alterar(_contato);
        }

        private void ExcluirClicked(object sender, EventArgs e)
        {
            _consultaViewModel.Excluir(_contato);
        }

        protected override void OnAppearing()
        {
             _contato = _consultaViewModel.ObterContato(_contato.Id);
             PopulaCampos(_contato);
        }


    }
}