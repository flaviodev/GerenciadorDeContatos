using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;

namespace GerenciadorContato.Models
{
    class Estado
    {
        public string area_km2 { get; set; }
        public string codigo_ibge { get; set; }
        public string nome { get; set; }
    }
}
