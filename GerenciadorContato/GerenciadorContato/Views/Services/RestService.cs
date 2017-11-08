using GerenciadorContato.ViewModels.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciadorContato.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace GerenciadorContato.Views.Services
{
    class RestService : IRestService
    {
        HttpClient client;

        public RestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<Endereco> EnderecoPeloCepAsync(string cep)
        {
            Endereco endereco = null;

            var uri = new Uri(string.Format("http://api.postmon.com.br/v1/cep/{0}", cep));
            var response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                endereco = JsonConvert.DeserializeObject<Endereco>(content);
            }

            return endereco;
        }
    }
}
