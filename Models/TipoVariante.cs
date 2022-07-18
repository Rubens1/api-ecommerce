using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.tipo_variante")]
    public class TipoVariante
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [StringLength(100)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
