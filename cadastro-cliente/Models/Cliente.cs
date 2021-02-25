using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace cadastro_cliente.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Telefone> Telefones { get; set; }

        public Cliente(){
            Telefones = new List<Telefone>();
        }

        public void adicionarTelefone(string Ddd, string numero) {

            Telefone telefone = new Telefone();
            telefone.Ddd = Ddd;
            telefone.numero = numero;

            this.Telefones.Add(telefone);
        }
    }
}
