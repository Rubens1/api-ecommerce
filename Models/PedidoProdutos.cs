using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("cliente.pedido_produtos")]
    public class PedidoProdutos
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Column("id_pedido")]
        [Display(Name = "Pedido")]
        [ForeignKey("Pedidos")]
        public int IdPedido { get; set; }

        [Column("id_produto")]
        [Display(Name = "Produto")]
        [ForeignKey("Produtos")]
        public int IdProduto { get; set; }

        [Column("quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Column("separado")]
        [Display(Name = "Separado")]
        public double Separado { get; set; }

        public List<Produtos> Produtos { get; set; }

        public List<Pedidos> Pedidos { get; set; }
    }
}
