using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("cliente.informacao")]
    public class Clientes
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [StringLength(100)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Column("email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(20)]
        [Column("cpf")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [StringLength(100)]
        [Column("senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("data_criado")]
        [Display(Name = "Data criada")]
        public DateTime Criado { get; set; }

        public ClienteEndereco ClienteEndereco { get; set; }

        public Pedidos Pedidos { get; set; }
    }
}
