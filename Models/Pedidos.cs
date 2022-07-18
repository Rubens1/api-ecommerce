using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("cliente.pedidos")]
    public class Pedidos
    {
        [Column("id")]
        [Display(Name = "id")]
        public int Id { get; set; }

        [Column("id_cliente")]
        [Display(Name = "Cliente")]
        [ForeignKey("Clientes")]
        public int IdCliente { get; set; }

        [Column("id_endereco")]
        [Display(Name = "Endereço")]
        [ForeignKey("ClienteEndereco")]
        public int IdEndereco { get; set; }

        [Column("valor_total")]
        [Display(Name = "Valor total")]
        public decimal ValorTotal { get; set; }

        [StringLength(100)]
        [Column("referenca")]
        [Display(Name = "Referença")]
        public string Referenca { get; set; }

        [Column("status")]
        [Display(Name = "Status")]
        public double Status { get; set; }

        [Column("status_interno")]
        [Display(Name = "Status interno")]
        public string StatusInterno { get; set; }

        [Column("criado")]
        [Display(Name = "Data criada")]
        public DateTime Criado { get; set; }

        [Column("modificado")]
        [Display(Name = "Data modificado")]
        public DateTime Modificado { get; set; }

        [Column("tipo_frete")]
        [Display(Name = "Tipo de frete")]
        public string TipoFrete { get; set; }

        [Column("valor_frete")]
        [Display(Name = "Valor do frete")]
        public decimal ValorFrete { get; set; }

        [StringLength(100)]
        [Column("rastreio")]
        [Display(Name = "Rastreio")]
        public string Rastreio { get; set; }

        [Column("forma_pagamento")]
        [Display(Name = "Forma de pagamento")]
        public string FormaPagamento { get; set; }

        public List<Clientes> Clientes { get; set; }
        
        public List<ClienteEndereco> ClienteEndereco { get; set; }
    }
}
