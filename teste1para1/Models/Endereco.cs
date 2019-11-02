using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste1para1.Models
{
    public class Endereco
    {
        public Endereco(string logradouro, int clienteRef)
        {
            this.Logradouro = logradouro;
            this.ClienteRef = clienteRef;
        }
        public Endereco()
        {
        }
        public int EnderecoId { get; set; }

        public string Logradouro { get; set; }

        public int ClienteRef { get; set; }
        public Cliente Clientes { get;  set; }
    }
}
