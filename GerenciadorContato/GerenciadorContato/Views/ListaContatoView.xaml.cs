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
    public partial class ListaContatoView : ContentPage
    {
        private ListaContatoViewModel _listaViewModel;


        public ListaContatoView()
        {
            InitializeComponent();
            _listaViewModel = new ViewModels.ListaContatoViewModel();
            this.BindingContext = _listaViewModel;
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            this.Lista.ItemsSource = _listaViewModel.ListarContatos();
        }

        protected override void OnAppearing()
        {
            this.AtualizarLista();
        }

        private void Selecionar(object sender, SelectedItemChangedEventArgs e)
        {
            _listaViewModel.Selecionar((Contato)Lista.SelectedItem);
        }


    }
}