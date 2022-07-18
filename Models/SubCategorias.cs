using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.subcategoria")]
    public class SubCategorias
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("id_categoria")]
        [Display(Name = "Categoria")]
        [ForeignKey("Categorias")]
        public int IdCategoria { get; set; }

        [StringLength(100)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Column("slug")]
        [Display(Name = "Slug")]
        public string Slug { get; set; }

        public Categorias Categorias { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
