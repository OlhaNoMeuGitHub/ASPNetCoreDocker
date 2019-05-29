using Sistema.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema.Model
{
    [Table("Pedidos")]
    public class Pedidos : BaseEntity
    {
        
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public Guid UserId { get; set; }
        public Guid ProdutoId { get; set; }
        public Guid EnderecoId { get; set; }

        public Pedidos()
        {
            Data = DateTime.Now;
        }
    }
}
