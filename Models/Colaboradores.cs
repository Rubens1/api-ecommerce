using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.colaboradores")]
    public class Colaboradores
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

        [StringLength(100)]
        [Column("senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [StringLength(100)]
        [Column("imagem")]
        [Display(Name = "Imagem")]
        public string Img { get; set; }

        [Column("cargo")]
        [Display(Name = "Cargo")]
        public int Cargo { get; set; }
    }
}
