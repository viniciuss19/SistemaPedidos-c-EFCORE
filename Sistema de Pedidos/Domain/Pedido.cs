using Sistema_de_Pedidos.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pedidos.Domain
{
    class Pedido
    {
         public int id{ get; set; } 
         public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime IniciadoEm { get; set; }
        public DateTime FinalizadoEm { get; set; }

        public TipoFrete TipoFrete { get; set; }

        public string Obervacao { get; set; }

        public ICollection<PedidoItem> Itens { get; set; }
        public StatusPedido Status { get; set; }
    }
}
