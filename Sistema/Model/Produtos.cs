using Sistema.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;



namespace Sistema.Model
{
    [Table("Produtos")]
    public class Produtos : BaseEntity
    {
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
    }
}
