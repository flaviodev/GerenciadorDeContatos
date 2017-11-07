
using SQLite.Net.Interop;

namespace GerenciadorContato.ViewModels.Services
{
    public interface IConfiguracaoService
    {
        string DiretorioDB { get; }

        ISQLitePlatform Plataforma { get; }
    }
}
