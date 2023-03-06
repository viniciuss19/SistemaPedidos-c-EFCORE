using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pedidos.Domain
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Telefone { get; set; }
        public decimal Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }

        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }

        public int Valor { get; set; }

       

    }
}
