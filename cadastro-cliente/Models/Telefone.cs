using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace cadastro_cliente.Models
{
    [Table("telefone")]
    public class Telefone
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Ddd { get; set; }
        public string numero { get; set; }
        public Cliente Cliente { get; set; }

        public Telefone()
        {
        }
    }
}
