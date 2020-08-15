using Entity.Entities.Sismtemas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Categorias
{

    [Table("Categoria")]
    public class Categoria : Base
    {

        [Display(Name = "Código do Sistema")]
        [ForeignKey("SistemaFinanceiro")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaFinanceiro SistemaFinanceiro { get; set; }
    }
}


