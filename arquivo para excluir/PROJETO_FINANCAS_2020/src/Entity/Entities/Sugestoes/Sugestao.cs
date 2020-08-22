using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Sugestoes
{
    [Table("Sugestao")]
    public class Sugestao : Base
    {

        [Display(Name = "Sugestão")]
        public string DescricaoSugestao { get; set; }

        [Display(Name = "E-mail do Usuário")]
        public string EmailUsuario { get; set; }
    }
}
