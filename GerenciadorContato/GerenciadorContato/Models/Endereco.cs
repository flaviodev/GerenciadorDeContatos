using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GerenciadorContato.Models
{
    class Endereco
    {
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string logradouro { get; set; }
        public Estado estado_info { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }

    }
}
