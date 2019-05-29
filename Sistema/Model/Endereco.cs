using Sistema.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema.Model
{
    [Table("enderecos")]
    public class Endereco : BaseEntity
    {
        public string Nome { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public Guid UserId { get; set; }

    }
}
