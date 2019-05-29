using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Sistema.Model.Base
{
    public class BaseEntity
    {
        private Guid id;

        [Column("id")]
        public Guid Id { get ; set ; }

        public BaseEntity()
        {
           id = Guid.NewGuid();

        }
    }
}
