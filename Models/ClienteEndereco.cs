using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("cliente.endereco")]
    public class ClienteEndereco
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Column("id_cliente")]
        [Display(Name = "Cliente")]
        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }

        [StringLength(100)]
        [Column("estado")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [StringLength(100)]
        [Column("cidade")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [StringLength(10)]
        [Column("cep")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [StringLength(100)]
        [Column("endereco")]
        [Display(Name = "Endereco")]
        public string Endereco { get; set; }

        [StringLength(100)]
        [Column("complemento")]
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
        
        public List<Clientes> Clientes { get; set; }

        public Pedidos Pedidos { get; set; }

    }
}
