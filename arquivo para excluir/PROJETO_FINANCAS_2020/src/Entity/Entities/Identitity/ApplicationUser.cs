using Entity.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Identitity
{
    public class ApplicationUser : IdentityUser
    {
        [Column("Nome")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Tipo")]
        [Display(Name = "Tipo usúario")]
        public EnumTipoUsuario? Tipo { get; set; }
    }
}
