using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.produto_variante")]
    public class ProdutosVariantes
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("id_produto")]
        [Display(Name = "Produto")]
        [ForeignKey("Produtos")]
        public int IdProduto { get; set; }

        [Column("id_tipo")]
        [Display(Name = "Tipo")]
        [ForeignKey("")]
        public int IdTipo { get; set; }

        [StringLength(100)]
        [Column("variante")]
        [Display(Name = "Variante")]
        public string Variante { get; set; } 

        public Produtos Produtos { get; set; }
    }
}
