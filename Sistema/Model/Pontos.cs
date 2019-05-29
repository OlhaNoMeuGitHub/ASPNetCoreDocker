using Sistema.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;



namespace Sistema.Model
{
    [Table("Pontos")]
    public class Pontos : BaseEntity
    {
        public Guid UserId { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public DateTime Data { get; set; }

        public Pontos()
        {
            Data = DateTime.Now;
        }
    }
}
