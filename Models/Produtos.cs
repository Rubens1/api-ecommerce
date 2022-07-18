using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("admin.produtos")]
    public class Produtos
    {
        [Column("id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("id_categoria")]
        [Display(Name = "Categoria")]
        [ForeignKey("Categorias")]
        public int IdCategoria { get; set; }

        [Column("id_subcategoria")]
        [Display(Name = "Subcategoria")]
        [ForeignKey("SubCategorias")]
        public int IdSubcategoria { get; set; }

        [StringLength(100)]
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [StringLength(100)]
        [Column("video")]
        [Display(Name = "Vídeo")]
        public string Video { get; set; }

        [Column("descricao")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Column("preco_promocao")]
        [Display(Name = "Preco de promoção")]
        public decimal? PrecoPromocao { get; set; }

        [Column("preco_venda")]
        [Display(Name = "Preço de venda")]
        public decimal PrecoVenda { get; set; }

        [Column("id")]
        [Display(Name = "id")]
        public double Peso { get; set; }

        [Column("altura")]
        [Display(Name = "Altura")]
        public double Altura { get; set; }

        [Column("largura")]
        [Display(Name = "Largura")]
        public double Largura { get; set; }

        [Column("comprimento")]
        [Display(Name = "Comprimento")]
        public double Comprimento { get; set; }

        [StringLength(100)]
        [Column("codigo")]
        [Display(Name = "Código")]
        public string? Codigo { get; set; }

        [StringLength(100)]
        [Column("posicao")]
        [Display(Name = "Posição")]
        public string Posicao { get; set; }

        [Column("data_cadastrado")]
        [Display(Name = "Data Cadastrado")]
        public DateTime DataCadastrado { get; set; }

        [StringLength(100)]
        [Column("slug")]
        [Display(Name = "Slug")]
        public string Slug { get; set; }

        public Categorias Categorias { get; set; }

        public SubCategorias SubCategorias { get; set; }

        public List<ProdutosVariantes> ProdutosVariantes { get; set; }

        public List<PedidoProdutos> PedidoProdutos { get; set; }

        public List<ImagensProdutos> ImagensProdutos { get; set; }
    }
}
