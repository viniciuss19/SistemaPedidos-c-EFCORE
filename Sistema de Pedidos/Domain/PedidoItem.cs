﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Pedidos.Domain
{
    class PedidoItem
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }
        public double Desconto { get; set; }
        public int ProdutoId { get; set; }

    }
}
