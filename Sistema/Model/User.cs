using Sistema.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema.Model
{
    [Table("users")]
    public class User : BaseEntity
    {

        public string Email { get; set; }
        public string AccessKey { get; set; }
        public string Cpf { get; set; }
        public string Perfil { get; set; }
        public string Nome { get; set; }
        public double Pontos { get; set; }


    }
}
