using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.imagens_produtos")]
    public class ImagensProdutos
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Column("id_produto")]
        [Display(Name = "Produto")]
        [ForeignKey("Produtos")]
        public int IdProduto { get; set; }

        [StringLength(100)]
        [Column("imagem")]
        [Display(Name = "Imagem")]
        public string Imagem { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
