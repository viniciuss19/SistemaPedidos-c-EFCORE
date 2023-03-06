using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Sistema_de_Pedidos.ValueObjects;

namespace Sistema_de_Pedidos
{
    class Cliente
    {
        public int Id { get; set; }
        public string CodigoBarras { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public decimal Valor { get; set; }
        public TipoProduto TipoProduto { get; set; }

        public int Telefone { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public string Estado     { get; set; }
        public decimal CEP { get; set; }





    }
}
