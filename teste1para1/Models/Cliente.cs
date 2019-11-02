using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste1para1.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public Endereco Enderecos { get; set; }
    }
}
