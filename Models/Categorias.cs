using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.categoria")]
    public class Categorias
    {
        [Key]
        [Column("id")]
        [Display(Name="Id")]
        public int Id { get; set; }

        [StringLength(100)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Column("slug")]
        [Display(Name = "Slug")]
        public string Slug { get; set; }

        public List<SubCategorias> SubCategorias { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
