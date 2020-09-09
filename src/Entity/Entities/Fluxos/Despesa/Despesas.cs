using Entity.Entities.Categorias;
using Entity.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Fluxos.Despesa
{
    [Table("Despesa")]
    public class Despesa : Base
    {
        [Display(Name = "Valor")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }

        [Display(Name = "Mês")]
        public int Mes { get; set; }

        [Display(Name = "Ano")]
        public int Ano { get; set; }

        [Display(Name = "TipoDespesa")]
        public EnumTipoDespesa TipoDespesa { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }

        [Display(Name = "Data de Alteração")]
        public DateTime DataAlteracao { get; set; }

        [Display(Name = "Data de Pagamento")]
        public DateTime DataPagamento { get; set; }

        [Display(Name = "Data de Vencimento")]
        public DateTime DataVencimento { get; set; }

        [Display(Name = "Pago")]
        public bool Pago { get; set; }

        [NotMapped]
        public bool DespesaAntrasada { get; set; }


        [Display(Name = "Categoria")]
        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public int IdCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
