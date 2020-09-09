using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Fluxos.Compras
{
    [Table("ItemCompra")]
    public class ItemCompra : Base
    {
        [Display(Name = "Valor")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Comprado")]
        public bool Comprado { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; }

        [Display(Name = "Data de Compra")]
        public DateTime DataCompra { get; set; }


        [Display(Name = "Compra")]
        [ForeignKey("Compra")]
        [Column(Order = 1)]
        public int IdCompra { get; set; }
        public virtual Compra Compra { get; set; }
    }
}
